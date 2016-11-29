using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the indetify. if it's a leader please press 1, if not, please press 2.");
            int indetify = Convert.ToInt32(Console.ReadLine());
            string idNumber, fullName, dateOfBirth;
            string faction = string.Empty, position = string.Empty;
            Console.WriteLine("Please enter ID Number.");
            idNumber = Console.ReadLine();
            Console.WriteLine("Please enter Full Name.");
            fullName = Console.ReadLine();
            Console.WriteLine("Please enter Date of Birth.");
            dateOfBirth = Console.ReadLine();
            if (indetify == 1)
            {
                Console.WriteLine("Please enter Faction.");
                faction = Console.ReadLine();
                Console.WriteLine("Please enter Position.");
                position = Console.ReadLine();

                Citizen leader = new Leader(idNumber, fullName, dateOfBirth, faction, position);
            }
            else
            {
                Citizen citizen = new Citizen(idNumber, fullName, dateOfBirth);
            }

            Console.WriteLine("ID Number:{0}", idNumber);
            Console.WriteLine("Full Name:{0}", fullName);
            Console.WriteLine("Date of Birth:{0}", dateOfBirth);
            if (indetify == 1)
            {
                Console.WriteLine("Faction:{0}", faction);
                Console.WriteLine("Position:{0}", position);
            }
        }
    }

    class Citizen
    {
        protected string idNumber;
        protected string fullName;
        protected DateTime dateOfBirth;

        public Citizen()
        {

        }

        public Citizen(string id, string name, string birthday)
        {
            idNumber = id;
            fullName = name;
            dateOfBirth = Convert.ToDateTime(birthday);
        }

        public void showCitizenInfo()
        {
            Console.WriteLine("ID:Number: " + idNumber);
            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine("Date of Birth: " + dateOfBirth);
        }
    }

    sealed class Leader : Citizen
    {
        protected string faction;
        protected string position;

        public Leader(string id, string name, string birthday, string party, string work)
        {
            idNumber = id;
            fullName = name;
            dateOfBirth = Convert.ToDateTime(birthday);
            faction = party;
            position = work;
        }

        public void showLeaderInfo()
        {
            Console.WriteLine("Faction: " + faction);
            Console.WriteLine("Position:: " + position);
        }
    }
}
