using System;
using System.Collections.Generic;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student(1234543);
            s.email = "reed.schuerman@dsu.edu";
            var r = new Student(1234543);
            r.email = "reed.schuerman@dsu.edu";
            s.phoneNumber = "123456";
            s.phoneNumber = "1234567890";
            s.printLogs();
        }
    }
}
