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

                Leader leader = new Leader(idNumber, fullName, dateOfBirth, faction, position);
                leader.showCitizenInfo(); //考点：对象调用方法
                leader.showLeaderInfo();
            }
            else
            {
                Citizen citizen = new Citizen(idNumber, fullName, dateOfBirth); //考点：通过对象调用类
                citizen.showCitizenInfo();
            }
        }
    }

    class Citizen
    {
        protected string idNumber; //考点：定义类的字段
        protected string fullName;
        protected DateTime dateOfBirth;

        public Citizen()
        {

        }

        public Citizen(string id, string name, string birthday) //考点：类的构造
        {
            idNumber = id;
            fullName = name;
            dateOfBirth = Convert.ToDateTime(birthday);
        }

        public void showCitizenInfo() //考点：定义方法
        {
            Console.WriteLine("ID:Number: " + idNumber);
            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine("Date of Birth: " + dateOfBirth);
        }
    }

    sealed class Leader : Citizen //考点：类的继承
    {
        protected string faction;
        protected string position;

        public Leader(string id, string name, string birthday, string party, string work) //考点：类的构造
        {
            idNumber = id;
            fullName = name;
            dateOfBirth = Convert.ToDateTime(birthday);
            faction = party;
            position = work;
        }

        public void showLeaderInfo() //考点：定义方法
        {
            Console.WriteLine("Faction: " + faction);
            Console.WriteLine("Position:: " + position);
        }
    }
}
