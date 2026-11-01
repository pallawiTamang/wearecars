using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using WeAreCarsRentalSystem.Models;

namespace WeAreCarsRentalSystem.Services
{
    /// <summary>
    /// Manages the collection of vehicle rentals, persistence, and reference numbering.
    /// Supports session-based storage with local JSON backup for reliability.
    /// </summary>
    public static class BookingService
    {
        private static readonly List<Booking> _bookings = new();
        private static int _nextReferenceSequence = 1001;
        private static readonly object _syncLock = new();

        // Local storage file path in application local data directory
        private static readonly string StorageFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "WeAreCarsRentalSystem",
            "rented_cars.json"
        );

        static BookingService()
        {
            InitializeData();
        }

        /// <summary>
        /// Initializes repository by attempting to load persisted bookings, or seeding default sample bookings for demonstration.
        /// </summary>
        private static void InitializeData()
        {
            lock (_syncLock)
            {
                bool loaded = TryLoadFromFile();

                if (!loaded || _bookings.Count == 0)
                {
                    // Seed initial sample rentals so the Rented Cars screen is populated and ready for immediate demonstration
                    SeedInitialBookings();
                    TrySaveToFile();
                }

                // Update reference sequence to exceed highest existing reference number
                UpdateNextSequenceNumber();
            }
        }

        private static void SeedInitialBookings()
        {
            _bookings.Clear();

            // Sample 1: John Smith renting a Family Car
            _bookings.Add(new Booking
            {
                BookingReference = "WAC-2026-1001",
                Customer = new Customer("John", "Smith", "14 High Street, Sunderland", 34, true),
                RentalDays = 3,
                CarType = CarType.FamilyCar,
                FuelType = FuelType.Petrol,
                HasUnlimitedMileage = false,
                HasBreakdownCover = true,
                BaseRentalCost = 75.00m,
                CarSurcharge = 50.00m,
                FuelSurcharge = 0.00m,
                UnlimitedMileageCost = 0.00m,
                BreakdownCoverCost = 6.00m,
                TotalPrice = 131.00m,
                BookingDate = DateTime.Now.AddDays(-2),
                Status = BookingStatus.Active
            });

            // Sample 2: Sarah Jenkins renting an SUV with Hybrid
            _bookings.Add(new Booking
            {
                BookingReference = "WAC-2026-1002",
                Customer = new Customer("Sarah", "Jenkins", "88 Park Avenue, Sunderland", 28, true),
                RentalDays = 7,
                CarType = CarType.SUV,
                FuelType = FuelType.Hybrid,
                HasUnlimitedMileage = true,
                HasBreakdownCover = true,
                BaseRentalCost = 175.00m,
                CarSurcharge = 65.00m,
                FuelSurcharge = 30.00m,
                UnlimitedMileageCost = 70.00m,
                BreakdownCoverCost = 14.00m,
                TotalPrice = 354.00m,
                BookingDate = DateTime.Now.AddDays(-1),
                Status = BookingStatus.Active
            });
        }

        private static void UpdateNextSequenceNumber()
        {
            foreach (var b in _bookings)
            {
                if (b.BookingReference.StartsWith("WAC-2026-"))
                {
                    string numPart = b.BookingReference.Substring("WAC-2026-".Length);
                    if (int.TryParse(numPart, out int num) && num >= _nextReferenceSequence)
                    {
                        _nextReferenceSequence = num + 1;
                    }
                }
            }
        }

        /// <summary>
        /// Generates a unique, professional booking reference number (e.g. "WAC-2026-1003").
        /// </summary>
        public static string GenerateBookingReference()
        {
            lock (_syncLock)
            {
                string reference = $"WAC-2026-{_nextReferenceSequence}";
                _nextReferenceSequence++;
                return reference;
            }
        }

        /// <summary>
        /// Adds and permanently commits a newly confirmed booking to the system.
        /// </summary>
        /// <param name="booking">The confirmed Booking instance</param>
        public static void ConfirmBooking(Booking booking)
        {
            if (booking == null) throw new ArgumentNullException(nameof(booking));

            lock (_syncLock)
            {
                _bookings.Insert(0, booking); // Most recent at the top
                TrySaveToFile();
            }
        }

        /// <summary>
        /// Returns all currently registered vehicle bookings.
        /// </summary>
        public static IReadOnlyList<Booking> GetAllBookings()
        {
            lock (_syncLock)
            {
                return _bookings.ToList().AsReadOnly();
            }
        }

        /// <summary>
        /// Searches and filters bookings by text query (matching customer name or booking reference).
        /// </summary>
        public static List<Booking> SearchBookings(string query, CarType? carTypeFilter = null)
        {
            lock (_syncLock)
            {
                var queryable = _bookings.AsEnumerable();

                if (!string.IsNullOrWhiteSpace(query))
                {
                    string q = query.Trim().ToLowerInvariant();
                    queryable = queryable.Where(b =>
                        b.BookingReference.ToLowerInvariant().Contains(q) ||
                        b.CustomerFullName.ToLowerInvariant().Contains(q) ||
                        b.CustomerAddress.ToLowerInvariant().Contains(q));
                }

                if (carTypeFilter.HasValue)
                {
                    queryable = queryable.Where(b => b.CarType == carTypeFilter.Value);
                }

                return queryable.ToList();
            }
        }

        /// <summary>
        /// Safely saves current bookings to local JSON file.
        /// </summary>
        private static bool TrySaveToFile()
        {
            try
            {
                string dir = Path.GetDirectoryName(StorageFilePath)!;
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(_bookings, options);
                File.WriteAllText(StorageFilePath, json);
                return true;
            }
            catch
            {
                // Never crash the application if local file storage encounters permissions or IO locks
                return false;
            }
        }

        /// <summary>
        /// Safely loads bookings from local JSON storage if present.
        /// </summary>
        private static bool TryLoadFromFile()
        {
            try
            {
                if (!File.Exists(StorageFilePath))
                    return false;

                string json = File.ReadAllText(StorageFilePath);
                var loaded = JsonSerializer.Deserialize<List<Booking>>(json);
                if (loaded != null && loaded.Count > 0)
                {
                    _bookings.Clear();
                    _bookings.AddRange(loaded);
                    return true;
                }
            }
            catch
            {
                // Gracefully ignore corrupt/malformed files
            }
            return false;
        }
    }
}
