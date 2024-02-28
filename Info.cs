using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Info
    {
        String Name;
        String Address;
        int Age;
        String Gender;

        public void info(string Name,String Address, int Age, String Gender) {
            this.Name = Name;
            this.Address = Address;
            this.Age = Age;
            this.Gender = Gender;
        }
        public String getName()
        {
            return Name;
        }
        public String getAddress()
        {
            return Address;
        }
        public int getAge()
        {
            return Age;
        }
        public String getGender()
        {
            return Gender;
        }
    }
}
