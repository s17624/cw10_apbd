using cw10.DTOs.Requests;
using cw10.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw10.Services
{
    public class EfStudentDbService : IStudentDbService
    {
        private readonly s17624Context db;

        public EfStudentDbService(s17624Context _db)
        {
            db = _db;
        }


        public Student GetStudent(string index)
        {
            var student = db.Student.Where(s => s.IndexNumber == index).Single();
            return student;
        }

        public IEnumerable<Student> GetStudents()
        {
            var students = db.Student.ToList();
            return students;
        }

        public Student UpdateStudent(Student student)
        {
            db.Attach(student);
            db.Entry(student).State = EntityState.Modified;
            db.SaveChanges();
            return GetStudent(student.IndexNumber);
        }

        public void DeleteStudent(string index)
        {
            var student = new Student
            {
                IndexNumber = index
            };
            db.Attach(student);
            db.Remove(student);
            db.SaveChanges();
        }

        public Enrollment PromoteStudent(StudentPromotionDTO promotion)
        {
            var result = db.Enrollment.FromSqlRaw("EXECUTE procedurePromoteStudents {0}, {1}", 
                promotion.Studies, promotion.Semester).AsEnumerable().First();
            return result;
        }

        public Enrollment EnrollStudent(StudentEnrollmentDTO enrollment)
        {
            var student = new Student
            {
                FirstName = enrollment.FirstName,
                LastName = enrollment.LastName,
                BirthDate = enrollment.BirthDate,
                IndexNumber = enrollment.IndexNumber
            };

            var studies = db.Studies.Where(s => s.Name == enrollment.Studies).Single();

            Enrollment e1 = db.Enrollment.Where(e1 => e1.IdStudy == studies.IdStudy && e1.Semester == 1).Single();
            if(e1 == null)
            {
                var e2 = new Enrollment
                {
                    Semester = 1,
                    IdStudy = studies.IdStudy,
                    StartDate = DateTime.UtcNow
                };
                db.Enrollment.Add(e2);
                e1 = e2;
            }

            student.IdEnrollmentNavigation = e1;
            db.Student.Add(student);
            db.SaveChanges();
            return e1;

        }
    }
}
