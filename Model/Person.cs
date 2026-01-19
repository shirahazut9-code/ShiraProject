using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
     public class Person: BaseEntity
    {
        private string first_name;
        private string last_name;
        private City  citycode;

        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public City Citycode { get => citycode; set => citycode = value; }
    }
}
