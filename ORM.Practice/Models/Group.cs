using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Practice.Models
{
    internal class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // one to many relationship with Student    
        public List<Student> Students { get; set; }
    }
}
