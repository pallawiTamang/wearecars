using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WeAreCarsRentalSystem.Utilities;

namespace WeAreCarsRentalSystem
{
    internal static class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AttachConsole(int dwProcessId);

        private const int ATTACH_PARENT_PROCESS = -1;

        /// <summary>
        /// The main entry point for the WeAreCars Rental System desktop application.
        /// Supports standard GUI launch as well as headless '--run-tests' assessment audits.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // Check if test harness execution was requested via command-line arguments
            if (args != null && args.Length > 0 && (args[0] == "--run-tests" || args[0] == "-t" || args[0] == "/test"))
            {
                bool allPassed = RegressionTester.RunAllTests(out string report);

                // Attach to calling console output stream if available
                if (AttachConsole(ATTACH_PARENT_PROCESS))
                {
                    try
                    {
                        var stdOut = Console.OpenStandardOutput();
                        var writer = new StreamWriter(stdOut) { AutoFlush = true };
                        Console.SetOut(writer);
                        Console.WriteLine("\n" + report);
                    }
                    catch
                    {
                        // Fallback safely if stream redirection cannot be bound
                    }
                }

                // Record results to a local file in output directory
                string auditLogPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestResults.txt");
                File.WriteAllText(auditLogPath, report);

                Environment.Exit(allPassed ? 0 : 1);
                return;
            }

            // Normal application launch: Begin at the Splash Screen
            ApplicationConfiguration.Initialize();
            Application.Run(new Forms.SplashForm());
        }
    }
}