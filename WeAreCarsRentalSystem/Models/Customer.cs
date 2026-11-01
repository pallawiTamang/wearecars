namespace WeAreCarsRentalSystem.Models
{
    /// <summary>
    /// Represents the customer hiring a vehicle in the WeAreCars Rental System.
    /// Encapsulates mandatory customer identification and licensing requirements.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets the customer's first name.
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the customer's surname.
        /// </summary>
        public string Surname { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the full residential address of the customer.
        /// </summary>
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the customer's age in completed years.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets whether the customer has presented a valid driving licence.
        /// Mandatory requirement: If false, car rental bookings cannot proceed.
        /// </summary>
        public bool HasValidDrivingLicence { get; set; }

        /// <summary>
        /// Gets the customer's formatted full name for display.
        /// </summary>
        public string FullName => $"{FirstName} {Surname}".Trim();

        /// <summary>
        /// Initializes a default Customer instance.
        /// </summary>
        public Customer()
        {
        }

        /// <summary>
        /// Initializes a Customer instance with required values.
        /// </summary>
        public Customer(string firstName, string surname, string address, int age, bool hasValidDrivingLicence)
        {
            FirstName = firstName;
            Surname = surname;
            Address = address;
            Age = age;
            HasValidDrivingLicence = hasValidDrivingLicence;
        }
    }
}
