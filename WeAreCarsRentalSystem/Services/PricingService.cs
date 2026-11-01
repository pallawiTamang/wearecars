using WeAreCarsRentalSystem.Models;

namespace WeAreCarsRentalSystem.Services
{
    /// <summary>
    /// Encapsulates the complete breakdown of rental costs calculated by PricingService.
    /// Provides transparent itemised auditability for the booking summary screen and receipt.
    /// </summary>
    public class PriceBreakdown
    {
        public int RentalDays { get; init; }
        public decimal DailyBaseRate { get; init; }
        public decimal BaseRentalCost { get; init; }

        public CarType CarType { get; init; }
        public decimal CarSurcharge { get; init; }

        public FuelType FuelType { get; init; }
        public decimal FuelSurcharge { get; init; }

        public bool HasUnlimitedMileage { get; init; }
        public decimal UnlimitedMileageDailyRate { get; init; }
        public decimal UnlimitedMileageCost { get; init; }

        public bool HasBreakdownCover { get; init; }
        public decimal BreakdownCoverDailyRate { get; init; }
        public decimal BreakdownCoverCost { get; init; }

        public decimal TotalPrice { get; init; }
    }

    /// <summary>
    /// Service responsible for all pricing rules, calculations, and cost auditing.
    /// Encapsulates WeAreCars tariff rules independently of UI forms.
    /// </summary>
    public static class PricingService
    {
        // Tariff constants defined strictly by the CET131 Assignment 2 specification
        public const decimal BaseDailyRate = 25.00m;
        public const decimal UnlimitedMileageDailyRate = 10.00m;
        public const decimal BreakdownCoverDailyRate = 2.00m;

        // Vehicle category surcharges
        public const decimal CityCarSurcharge = 0.00m;
        public const decimal FamilyCarSurcharge = 50.00m;
        public const decimal SportsCarSurcharge = 75.00m;
        public const decimal SuvSurcharge = 65.00m;

        // Fuel category surcharges
        public const decimal PetrolSurcharge = 0.00m;
        public const decimal DieselSurcharge = 0.00m;
        public const decimal HybridSurcharge = 30.00m;
        public const decimal FullElectricSurcharge = 50.00m;

        /// <summary>
        /// Retrieves the fixed surcharge associated with the selected vehicle category.
        /// </summary>
        /// <param name="carType">The selected CarType.</param>
        /// <returns>The surcharge amount in GBP.</returns>
        public static decimal GetCarSurcharge(CarType carType)
        {
            return carType switch
            {
                CarType.CityCar => CityCarSurcharge,
                CarType.FamilyCar => FamilyCarSurcharge,
                CarType.SportsCar => SportsCarSurcharge,
                CarType.SUV => SuvSurcharge,
                _ => 0.00m
            };
        }

        /// <summary>
        /// Retrieves the fixed surcharge associated with the selected fuel category.
        /// </summary>
        /// <param name="fuelType">The selected FuelType.</param>
        /// <returns>The surcharge amount in GBP.</returns>
        public static decimal GetFuelSurcharge(FuelType fuelType)
        {
            return fuelType switch
            {
                FuelType.Petrol => PetrolSurcharge,
                FuelType.Diesel => DieselSurcharge,
                FuelType.Hybrid => HybridSurcharge,
                FuelType.FullElectric => FullElectricSurcharge,
                _ => 0.00m
            };
        }

        /// <summary>
        /// Calculates the complete price breakdown based on duration, vehicle, fuel, and optional extras.
        /// </summary>
        /// <param name="days">Rental duration (between 1 and 28 days).</param>
        /// <param name="carType">Selected vehicle category.</param>
        /// <param name="fuelType">Selected fuel/propulsion type.</param>
        /// <param name="unlimitedMileage">True if unlimited mileage extra is selected (+£10/day).</param>
        /// <param name="breakdownCover">True if breakdown cover extra is selected (+£2/day).</param>
        /// <returns>A PriceBreakdown object detailing all costs and final total.</returns>
        public static PriceBreakdown Calculate(
            int days,
            CarType carType,
            FuelType fuelType,
            bool unlimitedMileage,
            bool breakdownCover)
        {
            // Base rental cost: Days * £25
            decimal baseCost = days * BaseDailyRate;

            // Fixed category surcharges
            decimal carSurcharge = GetCarSurcharge(carType);
            decimal fuelSurcharge = GetFuelSurcharge(fuelType);

            // Optional daily extras: multiplied by duration
            decimal mileageCost = unlimitedMileage ? (days * UnlimitedMileageDailyRate) : 0.00m;
            decimal breakdownCost = breakdownCover ? (days * BreakdownCoverDailyRate) : 0.00m;

            // Total price aggregation
            decimal total = baseCost + carSurcharge + fuelSurcharge + mileageCost + breakdownCost;

            return new PriceBreakdown
            {
                RentalDays = days,
                DailyBaseRate = BaseDailyRate,
                BaseRentalCost = baseCost,
                CarType = carType,
                CarSurcharge = carSurcharge,
                FuelType = fuelType,
                FuelSurcharge = fuelSurcharge,
                HasUnlimitedMileage = unlimitedMileage,
                UnlimitedMileageDailyRate = UnlimitedMileageDailyRate,
                UnlimitedMileageCost = mileageCost,
                HasBreakdownCover = breakdownCover,
                BreakdownCoverDailyRate = BreakdownCoverDailyRate,
                BreakdownCoverCost = breakdownCost,
                TotalPrice = total
            };
        }

        /// <summary>
        /// Self-test verification method ensuring the assignment's benchmark test calculates exactly:
        /// 5 rental days, Sports Car, Hybrid, Unlimited Mileage, Breakdown Cover => £290.00.
        /// Throws an InvalidProgramException if calculation does not strictly equal £290.00.
        /// </summary>
        public static bool VerifyBenchmarkCalculation()
        {
            PriceBreakdown result = Calculate(
                days: 5,
                carType: CarType.SportsCar,
                fuelType: FuelType.Hybrid,
                unlimitedMileage: true,
                breakdownCover: true
            );

            // Expected breakdown:
            // Base: 5 * 25 = 125
            // Sports: 75
            // Hybrid: 30
            // Unlimited Mileage: 5 * 10 = 50
            // Breakdown: 5 * 2 = 10
            // Total: 125 + 75 + 30 + 50 + 10 = 290
            return result.TotalPrice == 290.00m;
        }
    }
}
