using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Practice.Models
{
    internal class Profile
    {
        // one to one relationship with Student
        public int Id { get; set; }
        public string Address { get; set; } = string.Empty;

        // foreign key for Student
        public int StudentId { get; set; } 
        public Student Student { get; set; }
    }
}
