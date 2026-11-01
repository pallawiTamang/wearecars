using System;
using WeAreCarsRentalSystem.Services;

namespace WeAreCarsRentalSystem.Models
{
    /// <summary>
    /// Represents a vehicle rental booking in the WeAreCars management system.
    /// Stores customer details, selected options, itemised cost breakdown, and status.
    /// </summary>
    public class Booking
    {
        public string BookingReference { get; set; } = string.Empty;
        public Customer Customer { get; set; } = new Customer();
        public int RentalDays { get; set; }

        public CarType CarType { get; set; }
        public FuelType FuelType { get; set; }

        public bool HasUnlimitedMileage { get; set; }
        public bool HasBreakdownCover { get; set; }

        public decimal BaseRentalCost { get; set; }
        public decimal CarSurcharge { get; set; }
        public decimal FuelSurcharge { get; set; }
        public decimal UnlimitedMileageCost { get; set; }
        public decimal BreakdownCoverCost { get; set; }
        public decimal TotalPrice { get; set; }

        public DateTime BookingDate { get; set; } = DateTime.Now;
        public BookingStatus Status { get; set; } = BookingStatus.Active;

        // UI Binding and Display Helper Properties
        public string CustomerFullName => Customer?.FullName ?? string.Empty;
        public string CustomerAddress => Customer?.Address ?? string.Empty;
        public int CustomerAge => Customer?.Age ?? 0;
        public string DrivingLicenceStatus => (Customer?.HasValidDrivingLicence == true) ? "Verified" : "Invalid/None";

        public string CarTypeDisplay => CarType switch
        {
            CarType.CityCar => "City Car (£0)",
            CarType.FamilyCar => "Family Car (+£50)",
            CarType.SportsCar => "Sports Car (+£75)",
            CarType.SUV => "SUV (+£65)",
            _ => CarType.ToString()
        };

        public string FuelTypeDisplay => FuelType switch
        {
            FuelType.Petrol => "Petrol (£0)",
            FuelType.Diesel => "Diesel (£0)",
            FuelType.Hybrid => "Hybrid (+£30)",
            FuelType.FullElectric => "Full Electric (+£50)",
            _ => FuelType.ToString()
        };

        public string ExtrasDisplay
        {
            get
            {
                if (HasUnlimitedMileage && HasBreakdownCover)
                    return "Unlimited Mileage, Breakdown Cover";
                if (HasUnlimitedMileage)
                    return "Unlimited Mileage";
                if (HasBreakdownCover)
                    return "Breakdown Cover";
                return "None";
            }
        }

        public string TotalPriceFormatted => $"£{TotalPrice:F2}";
        public string BookingDateFormatted => BookingDate.ToString("yyyy-MM-dd HH:mm");

        public Booking()
        {
        }

        /// <summary>
        /// Factory helper to instantiate a Booking populated directly from a Customer and calculated PriceBreakdown.
        /// </summary>
        public static Booking CreateFromBreakdown(
            string reference,
            Customer customer,
            PriceBreakdown breakdown)
        {
            return new Booking
            {
                BookingReference = reference,
                Customer = customer,
                RentalDays = breakdown.RentalDays,
                CarType = breakdown.CarType,
                FuelType = breakdown.FuelType,
                HasUnlimitedMileage = breakdown.HasUnlimitedMileage,
                HasBreakdownCover = breakdown.HasBreakdownCover,
                BaseRentalCost = breakdown.BaseRentalCost,
                CarSurcharge = breakdown.CarSurcharge,
                FuelSurcharge = breakdown.FuelSurcharge,
                UnlimitedMileageCost = breakdown.UnlimitedMileageCost,
                BreakdownCoverCost = breakdown.BreakdownCoverCost,
                TotalPrice = breakdown.TotalPrice,
                BookingDate = DateTime.Now,
                Status = BookingStatus.Active
            };
        }
    }
}
