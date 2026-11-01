namespace WeAreCarsRentalSystem.Models
{
    /// <summary>
    /// Represents an authenticated staff member operating the WeAreCars desktop management terminal.
    /// </summary>
    public class Staff
    {
        /// <summary>
        /// Gets or sets the unique staff identification username (e.g. "sta001").
        /// </summary>
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the staff member's display name.
        /// </summary>
        public string DisplayName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the staff member's role (e.g. "Rental Agent", "Manager").
        /// </summary>
        public string Role { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the timestamp when the current session was authenticated.
        /// </summary>
        public DateTime LoginTime { get; set; }

        public Staff()
        {
        }

        public Staff(string username, string displayName, string role)
        {
            Username = username;
            DisplayName = displayName;
            Role = role;
            LoginTime = DateTime.Now;
        }
    }
}
