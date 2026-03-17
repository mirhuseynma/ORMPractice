using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Practice.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        // many to one relationship with Group
        public int GroupId { get; set; } 
        public Group Group { get; set; }

        // one to one relationship with Profile
        public Profile Profile { get; set; }

        // many to many relationship with Course
        public List<StudentCourse> StudentsCourses { get; set; } = null!;

    }
}
