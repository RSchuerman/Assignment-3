using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_3
{
    public class Student
    {
        public readonly List<string> logs = new List<string>(100);

        //Fields
        public readonly double _id;
        private string _name;
        private string _major;
        private string _startDate;
        private string _anticipatedGradDate;
        private string _state;
        private string _email;
        private string _phoneNumber;
        private string _mailingAddress;
        public readonly Boolean _isPrivateStudent;

        #region Properties
        public string name
        {
            get { return _name; }
            set 
            { 
                _name = value;
                logSuccess("name");
            }
        }
        public string major
        {
            get { return _major; }
            set 
            { 
                _major = value;
                logSuccess("major");
            }
        }
        public string startDate
        {
            get { return _startDate; }
            set 
            {
                if (value.Length == 6 && value.All(char.IsDigit))
                {
                    _startDate = value;
                    logSuccess("startDate");
                }
                else
                {
                    _startDate = "None";
                    Console.WriteLine("Not a valid start date");
                    logFail("startDate");
                }
            }
        }
        public string anticipatedGradDate
        {
            get { return _anticipatedGradDate; }
            set 
            {
                if (value.Length == 6 && value.All(char.IsDigit))
                {
                    _anticipatedGradDate = value;
                    logSuccess("anticipatedGradDate");
                }
                else
                {
                    _anticipatedGradDate = "None";
                    Console.WriteLine("Not a valid graduation date");
                    logFail("anticipateGradDate");
                }
            }
        }
        public string state
        {
            get { return _state; }
            set 
            { 
                _state = value;
                logSuccess("state");
            }
        }
        public string email
        {
            get { return _email; }
            set 
            {
                if( value.Contains("@trojans.dsu.edu"))
                {
                    _email = value;
                    logSuccess("email");
                }
                else
                {
                    _email = "None";
                    Console.WriteLine("Not a valid email address");
                    logFail("email");
                }
            }
        }
        public string phoneNumber
        {
            get 
            {
                if (_isPrivateStudent)
                    return "Restricted";
                else
                    return _phoneNumber; 
            }
            set 
            {
                if (value.Length == 10)
                {
                    _phoneNumber = value;
                    logSuccess("phoneNumber");
                }
                else
                {
                    _phoneNumber = "None";
                    Console.WriteLine("Not a valid phone number");
                    logFail("phoneNumber");
                }
            }
        }
        public string mailingAddress
        {
            get 
            {
                if (_isPrivateStudent)
                    return "Restricted";
                else
                    return _mailingAddress; 
            }
            set 
            { 
                _mailingAddress = value;
                logSuccess("mailingAddress");
            }
        }
        #endregion

        //Constructors
        public Student(double id, Boolean privateStudent)
        {
            _id = id;
            _name = "None";
            _major = "None";
            _startDate = "None";
            _anticipatedGradDate = "None";
            _state = "None";
            _email = "None";
            _phoneNumber = "None";
            _mailingAddress = "None";
            _isPrivateStudent = privateStudent;
            logNewStudent();
        }

        public Student(double id, string n_name, string n_major, string n_startDate, string n_anticipatedGradDate, string n_state, string n_email, string n_phoneNumber, string n_mailingAddress, Boolean privateStudent)
        {
            _id = id;
            name = n_name;
            major = n_major;
            startDate = n_startDate;
            anticipatedGradDate = n_anticipatedGradDate;
            state = n_state;
            email = n_email;
            phoneNumber = n_phoneNumber;
            mailingAddress = n_mailingAddress;
            _isPrivateStudent = privateStudent;
            logNewStudent();
         }

        //Destructor
        ~Student()
        {
        }

        //Methods
        private void logSuccess(string field)
        {
            logs.Add(field + ".ChangeSuccess." + _id + "\n");
        }
        private void logFail(string field)
        {
            logs.Add(field + ".ChangeFailure." + _id + "\n");
        }
        private void logNewStudent()
        {
            logs.Add("NewStudentSuccess." + _id + "\n");
        }

        public void printLogs()
        {
            foreach (string a in logs)
                Console.WriteLine(a);
        }
        
        public void printStudent()
        {
            Console.WriteLine("ID: " + _id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Major: " + major);
            Console.WriteLine("Start Date: " + startDate.Substring(0,2) + "/" + startDate.Substring(2,4));
            Console.WriteLine("Anticipated Graduation Date: " + anticipatedGradDate.Substring(0,2) + "/" + anticipatedGradDate.Substring(2,4));
            Console.WriteLine("State: " + state);
            Console.WriteLine("Email Address: " + email);
            if (!phoneNumber.Contains("Restricted"))
                Console.WriteLine("Phone Number: (" + phoneNumber.Substring(0, 3) + ")" + phoneNumber.Substring(3, 3) + "-" + phoneNumber.Substring(6, 4));
            else
                Console.WriteLine("Phone Number: Restricted");
            Console.WriteLine("Mailing Address: " + mailingAddress);
            Console.WriteLine("");
        }
    }
}
