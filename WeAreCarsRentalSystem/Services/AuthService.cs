using WeAreCarsRentalSystem.Models;

namespace WeAreCarsRentalSystem.Services
{
    /// <summary>
    /// Service managing staff authentication and session state.
    /// Strictly adheres to the CET131 Assignment 2 fixed credential specifications:
    /// Username: sta001
    /// Password: givemethekeys123
    /// </summary>
    public static class AuthService
    {
        // Fixed staff credentials prescribed by assignment specification
        public const string RequiredUsername = "sta001";
        public const string RequiredPassword = "givemethekeys123";

        /// <summary>
        /// Gets the currently authenticated staff session, or null if logged out.
        /// </summary>
        public static Staff? CurrentStaff { get; private set; }

        /// <summary>
        /// Returns true if a staff member is currently authenticated in the system.
        /// </summary>
        public static bool IsAuthenticated => CurrentStaff != null;

        /// <summary>
        /// Validates entered credentials against the required assignment credentials.
        /// Provides exact, contextual feedback messages for blank or incorrect credentials.
        /// </summary>
        /// <param name="username">Entered username</param>
        /// <param name="password">Entered password</param>
        /// <param name="errorMessage">Out parameter receiving friendly validation explanation</param>
        /// <returns>True if authentication succeeds; otherwise false.</returns>
        public static bool Authenticate(string? username, string? password, out string errorMessage)
        {
            string trimmedUser = username?.Trim() ?? string.Empty;
            string rawPassword = password ?? string.Empty;

            // Check if both fields are empty
            if (string.IsNullOrWhiteSpace(trimmedUser) && string.IsNullOrEmpty(rawPassword))
            {
                errorMessage = "Please enter your staff username and password.";
                return false;
            }

            // Check if username is empty
            if (string.IsNullOrWhiteSpace(trimmedUser))
            {
                errorMessage = "Please enter your staff username.";
                return false;
            }

            // Check if password is empty
            if (string.IsNullOrEmpty(rawPassword))
            {
                errorMessage = "Please enter your staff password.";
                return false;
            }

            // Fixed credential comparison
            if (string.Equals(trimmedUser, RequiredUsername, StringComparison.Ordinal) &&
                string.Equals(rawPassword, RequiredPassword, StringComparison.Ordinal))
            {
                CurrentStaff = new Staff(RequiredUsername, "Staff Member (sta001)", "Rental Agent");
                errorMessage = string.Empty;
                return true;
            }

            // Incorrect credential feedback
            errorMessage = "Invalid username or password.";
            return false;
        }

        /// <summary>
        /// Terminates the current staff session.
        /// </summary>
        public static void Logout()
        {
            CurrentStaff = null;
        }
    }
}
