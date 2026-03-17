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

            #region AddProfile
            //db.Profiles.AddRange
            //    (
            //        new Profile { Address = "123 Main St", StudentId = 1 },
            //        new Profile { Address = "456 Elm St", StudentId = 2 },
            //        new Profile { Address = "789 Oak St", StudentId = 5 },
            //        new Profile { Address = "321 Pine St", StudentId = 6 },
            //        new Profile { Address = "654 Maple St", StudentId = 7 },
            //        new Profile { Address = "987 Cedar St", StudentId = 8 },
            //        new Profile { Address = "111 Birch St", StudentId = 9 },
            //        new Profile { Address = "222 Spruce St", StudentId = 10 }
            //    );
            //db.SaveChanges();
            #endregion

            #region AddCourse
            //db.Courses.AddRange
            //    (
            //        new Course { Name = "Mathematics", Size = 30 },
            //        new Course { Name = "Physics", Size = 25 },
            //        new Course { Name = "Chemistry", Size = 20 },
            //        new Course { Name = "Biology", Size = 15 },
            //        new Course { Name = "History", Size = 10 }
            //    );
            //db.SaveChanges();
            //Console.WriteLine("Courses have been added to the database.");
            #endregion

            #region Add StudentCourse
            //db.StudentCourses.AddRange
            //(
            //    new StudentCourse { StudentId = 2, CourseId = 1 },
            //    new StudentCourse { StudentId = 5, CourseId = 4 },
            //    new StudentCourse { StudentId = 6, CourseId = 5 },
            //    new StudentCourse { StudentId = 7, CourseId = 1 },
            //    new StudentCourse { StudentId = 8, CourseId = 2 },
            //    new StudentCourse { StudentId = 9, CourseId = 3 },
            //    new StudentCourse { StudentId = 10, CourseId = 4 }
            //);
            //db.SaveChanges();
            //Console.WriteLine("StudentCourses have been added to the database.");
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
            //var studentToDelete = db.Students.First(x => x.Id == 1);
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
            //var students = db.Students
            //    .AsNoTracking()
            //    .ToList();
            //foreach (var student in students)
            //{
            //    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}, GroupId: {student.GroupId}");
            //}
            #endregion

            #region Get Student with Course
            //var studentsWithGroup = db.Students
            //    .Include(s => s.StudentsCourses)
            //    .ThenInclude(sc => sc.Course)
            //    .AsNoTracking()
            //    .ToList();

            //foreach (var student in studentsWithGroup)
            //{
            //    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}");
            //    foreach (var studentCourse in student.StudentsCourses)
            //    {
            //        Console.WriteLine($"  Enrolled in: {studentCourse.Course.Name}");
            //    }
            //}
            #endregion

            #region get student by id with course  
            int studentId = 2; // Example student ID
            var studentWithCourses = db.StudentCourses
                .Where(s => s.StudentId == studentId)
                .Select(sc => new
                {
                    StudentName = sc.Student.Name,
                    Courses = sc.Course.Name
                })
                .AsNoTracking() 
                .ToList();
            foreach (var item in studentWithCourses)
            {
                Console.WriteLine($"Student: {item.StudentName}, Course: {item.Courses}");
            }
            #endregion
        }
    }
}
