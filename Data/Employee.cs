using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Data
{
    public class Employees
    {

        public string FullName { get; set; }
        public string jobTitle { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        //conditional properties
        public string GenderColor
        {
            get { return GenderColor; }
            set
            {
                GenderColor = value;
                if (Gender == "male")
                {
                    GenderColor = "blue";
                }
                else
                {
                    GenderColor = "pink";
                }

            }
        }

        public int count { get; internal set; }
    }
}
