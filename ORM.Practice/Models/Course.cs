using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Practice.Models
{
    internal class Course
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Size { get; set; }

        // many to many relationship with Student
        public List<StudentCourse> StudentsCourses { get; set; } = null!;

    }
}
