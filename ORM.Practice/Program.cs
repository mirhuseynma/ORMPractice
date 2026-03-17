using Microsoft.EntityFrameworkCore;
using ORM.Practice.Data;
using ORM.Practice.Models;

namespace ORM.Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDBContext db = new AppDBContext();
            #region Add Group
            //db.Groups.AddRange
            //    (
            //    new Group { Name = "Pa202" },
            //    new Group { Name = "Pa203" },
            //    new Group { Name = "Pa204" },
            //    new Group { Name = "Pa205" },
            //    new Group { Name = "Pa206" }    
            //    );
            //db.SaveChanges();
            #endregion

            #region Delete Group
            //var deleteToGroup = db.Groups.FirstOrDefault(x => x.Id == 2);
            //if (deleteToGroup != null)
            //{
            //    db.Groups.Remove(deleteToGroup);
            //    db.SaveChanges();
            //    Console.WriteLine($"Group with ID {deleteToGroup.Id} has been deleted.");
            //}
            #endregion

            #region Add student to database
            //db.Students.AddRange
            //    (
            //    new Student { Name = "John", Surname = "Doe", Age = 20, GroupId = 1 },
            //    new Student { Name = "Jane", Surname = "Smith", Age = 22, GroupId = 1 },
            //    new Student { Name = "Alice", Surname = "Johnson", Age = 19, GroupId = 2 },
            //    new Student { Name = "Bob", Surname = "Brown", Age = 21, GroupId = 2 },
            //    new Student { Name = "Charlie", Surname = "Davis", Age = 23, GroupId = 3 },
            //    new Student { Name = "Eve", Surname = "Miller", Age = 20, GroupId = 3 },
            //    new Student { Name = "Frank", Surname = "Wilson", Age = 22, GroupId = 4 },
            //    new Student { Name = "Grace", Surname = "Taylor", Age = 21, GroupId = 4 },
            //    new Student { Name = "Hank", Surname = "Anderson", Age = 19, GroupId = 5 },
            //    new Student { Name = "Ivy", Surname = "Thomas", Age = 20, GroupId = 5 }
            //    );
            //db.SaveChanges();
            //Console.WriteLine("Students have been added to the database.");
            #endregion

            #region Remove student
            //var studentToDelete = db.Students.First(x => x.Id == 4);
            //if (studentToDelete != null)
            //{
            //    db.Students.Remove(studentToDelete);
            //    db.SaveChanges();
            //}
            //Console.WriteLine($"Student with ID {studentToDelete.Id} has been deleted.");
            #endregion

            #region Uptade student
            //var studentToUpdate = db.Students.FirstOrDefault(s => s.Id == 2);
            //if (studentToUpdate != null)
            //{
            //    studentToUpdate.Name = "Mirhuseyn";
            //    db.SaveChanges();
            //}
            //Console.WriteLine("Student has been updated.");
            #endregion

            #region Get students from database  
            var students = db.Students
                .AsNoTracking()
                .ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}, GroupId: {student.GroupId}");
            }
            #endregion
        }
    }
}
