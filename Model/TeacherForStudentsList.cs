using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TeacherForStudentsList:List<TeacherForStudents>
    {
        public TeacherForStudentsList() { }
        public TeacherForStudentsList(IEnumerable<TeacherForStudents> list) : base(list) { }
        public TeacherForStudentsList(IEnumerable<BaseEntity> list) : base(list.Cast<TeacherForStudents>().ToList()) { }
    }
}
