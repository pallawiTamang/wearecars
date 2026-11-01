namespace WeAreCarsRentalSystem.Models
{
    /// <summary>
    /// Represents the vehicle category available for rental.
    /// Each category has an associated fixed surcharge defined by the business rules:
    /// City Car (£0), Family Car (£50), Sports Car (£75), SUV (£65).
    /// </summary>
    public enum CarType
    {
        CityCar,
        FamilyCar,
        SportsCar,
        SUV
    }

    /// <summary>
    /// Represents the propulsion/fuel category of the rental vehicle.
    /// Each option carries an associated surcharge:
    /// Petrol (£0), Diesel (£0), Hybrid (£30), Full Electric (£50).
    /// </summary>
    public enum FuelType
    {
        Petrol,
        Diesel,
        Hybrid,
        FullElectric
    }

    /// <summary>
    /// Represents the operational status of a rental booking.
    /// </summary>
    public enum BookingStatus
    {
        Active,
        Completed,
        Cancelled
    }
}
