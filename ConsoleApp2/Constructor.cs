using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Constructor
    {
        class GameScore
        {
            string user;
            int age;
            public GameScore()
            {
                user = "Siva";
                age = 28;
                Console.WriteLine("Previous User {0} and he was {1} year old", user, age);
            }
            public GameScore(string name, int age1)
            {
                user = name;
                age = age1;
                Console.WriteLine("Current User {0} and he is {1} year old", user, age);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                GameScore gs = new GameScore();
                GameScore gs1 = new GameScore("Clark", 35);


                Student s1 = new Student("Jack", 2);

                // copy constructor
                Student s2 = new Student(s1);
                Console.WriteLine(s2.Display);


                Account a1 = new Account(101, "Sonoo");
                Account a2 = new Account(102, "Mahesh");
                a1.display();
                a2.display();
                Console.ReadLine();


            }
        }


        
        class Student
        {
            private string name;
            private int rank;

            public Student(Student s)
            {
                name = s.name;
                rank = s.rank;
            }

            public Student(string name, int rank)
            {
                this.name = name;
                this.rank = rank;
            }

            public string Display
            {
                get
                {
                    return " Student " + name + " got Rank " + rank.ToString();
                }
            }
          
        }
    }
    public class Account
    {
        public int id;
        public String name;
        public static float rateOfInterest;
        public Account(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
        static Account()
        {
            rateOfInterest = 9.5f;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + rateOfInterest);
        }
    }
}

    

