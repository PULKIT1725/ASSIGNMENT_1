using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASSIGNMENT_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            //1-> calculate total price and apply 10% dis if price>3000
            /*int n = 5;
            int[] prices = new int[n];
            Console.WriteLine("prices of items");
            for (int i = 0; i < n; i++)
            {                
                string elem = Console.ReadLine();
                prices[i] = Convert.ToInt32(elem);
            }
                int total_price = prices.Sum();
            Console.WriteLine("sum of prices"+total_price);
            if (total_price > 3000)
                {
                    int discount = (total_price / 100) * 10;
                    Console.WriteLine("discount = " + discount);
                    total_price = total_price - discount;
                    Console.WriteLine("price after deduct discount = "+total_price);
            }Console.ReadLine();*/

            //2-> Convert temp Celcius into Fahernite
            /*string number = Console.ReadLine();
            int temp;
            temp = Convert.ToInt32(number);
            if (temp > 0) {
                int F = (temp * 9 / 5) + 32;
                Console.WriteLine("tempreature in Fahernite = "+F);
            }
            else
            {
                Console.WriteLine("Input tempreature greater than zero");
            }*/

            //3-> ATM system ( check balance, withdraw money, deposit money )
            /*Console.WriteLine("Input your card here");
            Console.WriteLine("Please wait while fetching your account details");
            Console.WriteLine("your options are " +
                "1. check balance" +
                "2. deposit money" +
                "3. withdraw money");
            int balance = int.Parse(Console.ReadLine());
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine(balance);
            }
            else if (option == 2)
            {
                int enter_amount = int.Parse(Console.ReadLine());
                balance = balance + enter_amount;
            }
            else if (option == 3)
            {
                int amount = int.Parse((Console.ReadLine()));
                balance = balance - amount;
            }
            else
            {
                Console.WriteLine("wrong input");
            }*/






            //4-> marks of five subjects and average of that
            /*int n = 5;
            int[] marks = new int[n];
            Console.WriteLine("marks of subjects");
            for (int i = 0; i < n; i++)
            {
                string elem = Console.ReadLine();
                marks[i] = Convert.ToInt32(elem);
            }
            int total_marks = marks.Sum();
            Console.WriteLine("average obtained");
            int avg = total_marks / n;
            Console.WriteLine(avg);
            if (avg > 90) 
            {
                Console.WriteLine("Grades A");
            }else if (avg > 80)
            {
                Console.WriteLine("Grades B");
            }else if(avg > 70)
            {
                Console.WriteLine("Grades C");
            }else if (avg > 50)
            {
                Console.WriteLine("Grades D");
            }else if( avg > 33)
            {
                Console.WriteLine("Grades E");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            Console.ReadLine();*/

            //5-> check entered password has 8 char with at least 1 uppercase and lowercase letter and 1 number
            /*string instructions = "password has minimum 8 characters" +
                "one uppercase letter" +
                "one lowercase letter" +
                "one number" +
                "one special character";
            Console.WriteLine(instructions);
            string password = Console.ReadLine();
            int len = password.Length;
            if (len < 8) 
            {
                Console.WriteLine("please enter password that contains minimum 8 characters");
            }
            else 
            {
                if (password.Length < 8)
                {
                    Console.WriteLine("Password must be at least 8 characters long.");
                }

                if (!Regex.IsMatch(password, "[A-Z]"))
                {
                    Console.WriteLine("Password must contain at least one uppercase letter.");
                }

                if (!Regex.IsMatch(password, "[a-z]"))
                {
                    Console.WriteLine("Password must contain at least one lowercase letter.");
                }

                if (!Regex.IsMatch(password, "[0-9]"))
                {
                    Console.WriteLine("Password must contain at least one number.");
                }
            }*/




            //6-> calculate fare of taxi ride. First 2 kms = 20rs. and additional charges as per km. inlude night surcharge after 10pm.
            /*Console.WriteLine("total distance travelled");
            string total_distance_travelled = Console.ReadLine();
            int total_distance = Convert.ToInt32(total_distance_travelled);
            Console.WriteLine("charge as per km ");
            string charge_as_per_km = Console.ReadLine();
            int km_charge = Convert.ToInt32(charge_as_per_km);
            int total_fare = 20+(total_distance-2)*km_charge;
            string[] time = {"10pm","11pm","0am","1am","2am","3am","4am","5am","6am"};
            Console.WriteLine("passenger leave time");
            string leave_time = Console.ReadLine();
            for (int i = 0; i < time.Length; i++)
            {
                if (leave_time == time[i]) 
                {
                    int surcharge = 200;
                    total_fare = total_fare + surcharge;
                }
            }
            Console.WriteLine("your total fare is = "+total_fare);
            Console.ReadLine();*/

            //7-> track attendace of 5 days , calculate total attended days by student and identify student which has perfect attendance
            /*int day = 5;
            String[] attendance = new string[day];
            int total_present = 0;
            int total_absent = 0;
            for (int i = 0; i < day; i++)
            {
                Console.WriteLine("mark p as present and a as absent");
                string input = Console.ReadLine().ToUpper();
                if (input == "P")
                {
                    attendance[i] = "P";  // Present
                    total_present++;
                }
                else if (input == "A")
                {
                    attendance[i] = "A"; // Absent
                    total_absent++;
                }
                else
                {
                    Console.WriteLine("Wrong input. Please input correctly P or A");
                    i--; // again take input for same day
                }
            }
            Console.WriteLine("total present in 5 days = "+total_present);
            Console.WriteLine("total absent in 5 days = "+total_absent);
            if (total_present == 5) 
            {
                Console.WriteLine("prefect attendence");
            }
            Console.ReadLine();
            */


            //8-> check month name in which expense is highest and lowest in a year
            /*int months = 12;
            string[] monthname = { "January","February","March","April","May","June","July","August","September","October","November","December"};
            int[] expenses = new int[months];
            int maxindex = 0;
            int minindex = 0;
            for (int i = 0; i < months; i++)
            {
                string elem = Console.ReadLine();
                expenses[i] = Convert.ToInt32(elem);
            }
            int highest = expenses.Max();
            int lowest = expenses.Min();
            for (int i = 1; i < expenses.Length; i++)
            {
                if (highest == expenses[i])
                {
                    maxindex = i;
                    Console.WriteLine("index of max expense = " + maxindex);
                    Console.ReadLine();
                }
            }
            for (int i = 1; i < expenses.Length; i++)
            { 
                if (lowest == expenses[i])
                {
                    minindex = i;
                    Console.WriteLine("index of min expense = " + minindex);
                    Console.ReadLine();
                }
            }
            Console.WriteLine("The string at the max index is: " + monthname[maxindex]);
            Console.WriteLine("The string at the min index is: " + monthname[minindex]);
            Console.ReadLine() ;*/

            



            //10-> calculate monthly salary based on hourly wage(earning of an hour) and 4 week in months
            /*int hourly_wage = int.Parse(Console.ReadLine());
            int total_hours_in_a_week = int.Parse(Console.ReadLine());
            int weekly_salary = hourly_wage*total_hours_in_a_week;
            int monthly_salary = weekly_salary * 4;
            Console.WriteLine(monthly_salary);
            Console.ReadLine();*/
        }
    }
}

