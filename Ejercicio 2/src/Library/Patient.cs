using System;
using System.Text;

namespace Library
{
    public class Patient
    {
        private string name;
        public string Name 
        {
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            } 
        }
        private string id;
        public string Id 
        {
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    id = value;
                }
            } 
        }
        private string phoneNumber;
        public string PhoneNumber 
        {
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    phoneNumber = value;
                }
            } 
        }
        public Patient(string name, string id, string phoneNumber)
        {
            this.name = name;
            this.id = id;
            this.phoneNumber = phoneNumber;
        }
    }
}