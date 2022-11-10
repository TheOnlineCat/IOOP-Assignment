using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    internal class Student
    {
        private string name;
        private string studentID;
        private string level;
        private string IC;
        private string address;
        private string email;
        private string contactNum;
        private string sub1;
        private string sub2; 
        private string sub3;

        public Student(string name,string studentID)
        {
            this.name = name;
            this.studentID = studentID;
        }

        public Student(string name, string studentID, string level, string iC, string address, string email, string contactNum, string sub1, string sub2, string sub3) : this(name, studentID)
        {
            this.level = level;
            IC = iC;
            this.address = address;
            this.email = email;
            this.contactNum = contactNum;
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
        }   


    }
}
