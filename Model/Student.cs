using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student: Person 
    {
        private int phon_number;

        public int Phon_number { get => phon_number; set => phon_number = value; }
    }
}
