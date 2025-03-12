using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    using System;

    public sealed class SecuritySystem
    {
        public string SystemName { get; set; }

        public SecuritySystem(string systemName)
        {
            SystemName = systemName;
        }

        public void Activate()
        {
            Console.WriteLine($"{SystemName} is now active.");
        }

        public void Deactivate()
        {
            Console.WriteLine($"{SystemName} is now deactivated.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the sealed class
            SecuritySystem security = new SecuritySystem("Home Security System");

            // Use the sealed class methods
            security.Activate();
            security.Deactivate();

            // Uncommenting the following lines will cause a compilation error
            /*
            AdvancedSecuritySystem advancedSecurity = new AdvancedSecuritySystem("Advanced Security System");
            advancedSecurity.RunDiagnostics();
            */
        }
    }
}
