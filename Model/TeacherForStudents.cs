using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TeacherForStudents: BaseEntity
    {
        private Student students;
        private Teacher teach;

        public Student Students { get => students; set => students = value; }
        public Teacher Teach { get => teach; set => teach = value; }
    }
}
