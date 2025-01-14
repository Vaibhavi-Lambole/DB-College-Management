using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DB_College_Management.Data.Entity 
{
    public class Student
    {
        [Key]
        [MaxLength(length: 30)]
        public string PRN { get; set; }

        [MaxLength(length: 100)]
        public string Name { get; set; }

        public DateTime BirthDay { get; set; }

        public int Age { get; set; }

        public long MobileNo { get; set; }

        public int Year { get; set; }
        
        [MaxLength(length: 50)]
        [EmailAddress]
        public string Email { get; set; }

        public string Address { get; set; }

        public List<Professor> Professors { get; set; }

        public Department Department { get; set; }

        public Student(string name, string pRN, string email, long mobileNo, string address, DateTime birthDay, int year, int age)
        {
            Name = name;
            PRN = pRN;
            Email = email;
            MobileNo = mobileNo;
            Address = address;
            BirthDay = birthDay;
            Year = year;
            Age = age;
        }
    }
}