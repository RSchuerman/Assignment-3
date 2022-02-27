using System;
using System.Collections.Generic;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> logs = new List<string>(100);
            var s = new Student(123456789);
            s.email = "reed.schuerman@trojans.dsu.edu";
            var r = new Student(1234543);
            r.email = "reed.schuerman@trojans.dsu.edu";
            s.phoneNumber = "123456";
            s.phoneNumber = "1234567890";
            s.anticipatedGradDate = "022024";
            s.anticipatedGradDate = "0224";
            s.startDate = "082020";
            s.startDate = "0820";

            var n = new Student(101060649);
            n.name = "Reed Owen Schuerman";
            n.major = "Computer Science";
            n.startDate = "082020";
            n.anticipatedGradDate = "052024";
            n.state = "Minnesota";
            n.email = "reed.schuerman@trojans.dsu.edu";
            n.phoneNumber = "5078296798";
            n.mailingAddress = "106 West Thomas Ave Marshall MN 56258";

            var q = new Student(10, "Billy Bob Jones", "Exercise Science", "082021", "052025", "Iowa", "Billy.Jones@trojans.dsu.edu", "6058675309", "The White House");

            

            //compile all logs together and prints them out
            foreach ( string a in s.logs)
                logs.Add(a);
            foreach( string a in r.logs)
                logs.Add(a);
            foreach (string a in n.logs)
                logs.Add(a);
            foreach (string a in q.logs)
                logs.Add(a);

            foreach (string a in logs)
                Console.WriteLine(a);

            //Prints Students
            n.printStudent();
            q.printStudent();

        }       
    }
}
