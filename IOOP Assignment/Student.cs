using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP_Assignment
{
    internal class Student
    {
        private string name;
        private string username;
        private string level;
        private string IC;
        private string address;
        private string email;
        private string contactNum;
        private string sub1;
        private string sub2; 
        private string sub3;
        
        public Student(string username)
        {
            this.username = username;
        }
        public Student(string name,string username)
        {
            this.name = name;
            this.username = username;
        }

        public Student(string name, string username, string level, string IC, string address, string email, string contactNum, string sub1, string sub2, string sub3)
        {
            this.level = level;
            this.IC = IC;
            this.address = address;
            this.email = email;
            this.contactNum = contactNum;
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
            this.name = name;
            this.username = username;
        }   

        public string Info(string username)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString());
            con.Open();

            SqlCommand cmd2 = new SqlCommand("select IC,Email,Level,ContactNumber,Address,DateEnrolled,Subject1,Subject2,Subject3 from [Students] where Username ='" + username + "'", con);
            string all = cmd2.ExecuteReader().ToString();
            return all;
            Console.WriteLine(all[0]);
            Console.WriteLine(all[1]);
            Console.WriteLine(all[2]);
            Console.WriteLine(all[3]);
            Console.WriteLine(all[4]);  
            Console.WriteLine(all[5]);
            Console.WriteLine(all[6]);
            Console.WriteLine(all[7]);
            Console.WriteLine(all[8]);
            
        }
    }
}
