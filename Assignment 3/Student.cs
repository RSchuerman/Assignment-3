using System;
using System.Collections.Generic;

namespace Assignment_3
{
    public class Student
    {
        List<string> logs = new List<string>(100);

        //Fields
        private readonly int _id;
        private string _name;
        private string _major;
        private string _startDate;
        private string _anticipatedGradDate;
        private string _state;
        private string _email;
        private string _phoneNumber;
        private string _mailingAddress;

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
                _startDate = value;
                logSuccess("startDate");
            }
        }
        public string anticipatedGradDate
        {
            get { return _anticipatedGradDate; }
            set 
            { 
                _anticipatedGradDate = value;
                logSuccess("anticipatedGradDate");
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
                _email = value;
                logSuccess("email");
            }
        }
        public string phoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (value.Length == 10)
                {
                    _phoneNumber = value;
                    logSuccess("phoneNumber");
                }
                else
                {
                    Console.WriteLine("Not a valid phone number");
                    logFail("phoneNumber");
                }
            }
        }
        public string mailingAddress
        {
            get { return _mailingAddress; }
            set 
            { 
                _mailingAddress = value;
                logSuccess("mailingAddress");
            }
        }
        #endregion

        //Constructors
        public Student(int id)
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
        
        }

        public Student(int id, string name, string major, string startDate, string anticipatedGradDate, string state, string email, string phoneNumber, string mailingAddress)
        {
            _id = id;
            _name = name;
            _major = major;
            _startDate = startDate;
            _anticipatedGradDate = anticipatedGradDate;
            _state = state;
            _email = email;
            _phoneNumber = phoneNumber;
            _mailingAddress = mailingAddress;
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

        public void printLogs()
        {
            foreach (string a in logs)
                Console.WriteLine(a);
        }
        
    }
}
