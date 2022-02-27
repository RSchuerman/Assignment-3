using System;
using System.Collections.Generic;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> logs = new List<string>(100);

            var a = new Student(1, "Billy Bob Jones", "Exercise Science", "082021", "052025", "Iowa", "Billy.Jones@trojans.dsu.edu", "6058675309", "The White House", false);
            /* Extra Students
            var b = new Student(2, "Billy Bob Jones", "Exercise Science", "082021", "052025", "Iowa", "Billy.Jones@trojans.dsu.edu", "6058675309", "The White House", false);
            var c = new Student(3, "Billy Bob Jones", "Exercise Science", "082021", "052025", "Iowa", "Billy.Jones@trojans.dsu.edu", "6058675309", "The White House", false);
            var d = new Student(4, "Billy Bob Jones", "Exercise Science", "082021", "052025", "Iowa", "Billy.Jones@trojans.dsu.edu", "6058675309", "The White House", false);
            var e = new Student(5, "Billy Bob Jones", "Exercise Science", "082021", "052025", "Iowa", "Billy.Jones@trojans.dsu.edu", "6058675309", "The White House", false);
            var f = new Student(6, "Billy Bob Jones", "Exercise Science", "082021", "052025", "Iowa", "Billy.Jones@trojans.dsu.edu", "6058675309", "The White House", false);
            var g = new Student(7, "Billy Bob Jones", "Exercise Science", "082021", "052025", "Iowa", "Billy.Jones@trojans.dsu.edu", "6058675309", "The White House", false);
            var h = new Student(8, "Billy Bob Jones", "Exercise Science", "082021", "052025", "Iowa", "Billy.Jones@trojans.dsu.edu", "6058675309", "The White House", false);
            var i = new Student(9, "Billy Bob Jones", "Exercise Science", "082021", "052025", "Iowa", "Billy.Jones@trojans.dsu.edu", "6058675309", "The White House", false);
            */
            var j = new Student(101060649, true);
            j.name = "Reed Owen Schuerman";
            j.major = "Computer Science";
            j.startDate = "082020";
            j.anticipatedGradDate = "052024";
            j.state = "Minnesota";
            j.email = "reed.schuerman@trojans.dsu.edu";
            j.phoneNumber = "5078296798";
            j.mailingAddress = "106 West Thomas Ave Marshall MN 56258";

            //compile all logs together and prints them out
            foreach (string z in a.logs)
                logs.Add(z);
            /* Extra Students
            foreach (string z in b.logs)
                logs.Add(z);
            foreach (string z in c.logs)
                logs.Add(z);
            foreach (string z in d.logs)
                logs.Add(z);
            foreach (string z in e.logs)
                logs.Add(z);
            foreach (string z in f.logs)
                logs.Add(z);
            foreach (string z in g.logs)
                logs.Add(z);
            foreach (string z in h.logs)
                logs.Add(z);
            foreach (string z in i.logs)
                logs.Add(z);
            */
            foreach (string z in j.logs)
                logs.Add(z);

            foreach (string z in logs)
                Console.WriteLine(z);

            //Prints Students
            a.printStudent();
            /* Extra Students
            b.printStudent();
            c.printStudent();
            d.printStudent();
            e.printStudent();
            f.printStudent();
            g.printStudent();
            h.printStudent();
            i.printStudent();
            */
            j.printStudent();

        }       
    }
}
