using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleCAdvance.Entities
{
    public class Student
    {
        string id;
        string name;
        DateTime birthDay;
        [Required]
        public DateTime BirthDay {get; set;}
        public String FullName {get; set;}
        public string ID
        {
            get {return id;}
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("id cannot be null");
                }
                id = value;
            }
        }
        Student(string id, string name, DateTime birthDay)
        {
            this.ID = id;
            this.FullName = name;
            this.BirthDay = birthDay;
        }
        public String getName()
        {
            string[] nameParts = FullName.Trim().Split(' ');
            return nameParts[nameParts.length - 1];
        }
        public String getFirstName()
        {
            string[] nameParts = FullName.Trim().Split(' ');
            return nameParts[nameParts[0]];
        }
    }
}