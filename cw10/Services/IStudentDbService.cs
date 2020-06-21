using cw10.DTOs.Requests;
using cw10.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw10.Services
{
    public interface IStudentDbService
    {

        public Student GetStudent(string index);

        public IEnumerable<Student> GetStudents();

        public Student UpdateStudent(Student student);
        public void DeleteStudent(string index);

        public Enrollment PromoteStudent(StudentPromotionDTO promotion);

        public Enrollment EnrollStudent(StudentEnrollmentDTO enrollment);

       

    }
}
