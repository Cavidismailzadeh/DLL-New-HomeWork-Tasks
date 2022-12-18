using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DLL_Homework_Task
{
    public class Doctor
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public string GetFullDataDoctor()
        {
            return $"Name: {Name} Surname: {Surname} Address: {Address} Birthday {Birthday} ";
        }
    }
}




   

