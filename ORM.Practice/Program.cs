using ORM.Practice.Data;
using ORM.Practice.Models;

namespace ORM.Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDBContext db = new AppDBContext();
            #region Add student to database
            //db.Students.AddRange
            //    (
            //    new Student { Name = "John", Surname = "Doe", Age = 20 },
            //    new Student { Name = "Jane", Surname = "Smith", Age = 22 },
            //    new Student { Name = "Alice", Surname = "Johnson", Age = 19 },
            //    new Student { Name = "Bob", Surname = "Brown", Age = 21 },
            //    new Student { Name = "Charlie", Surname = "Davis", Age = 23 }
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
            var students = db.Students.ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}");
            }
            #endregion
        }
    }
}
