using cw10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw10.DTOs.Requests
{
    public class EnrollmentDTO
    {
        public EnrollmentDTO(Enrollment enrollment)
        {
            IdEnrollment = enrollment.IdEnrollment;
            Semester = enrollment.Semester;
            IdStudy = enrollment.IdStudy;
            StartDate = enrollment.StartDate;
        }

        public int IdEnrollment { get; set; }
        public int Semester { get; set; }
        public int IdStudy { get; set; }
        public DateTime StartDate { get; set; }
    }
}
