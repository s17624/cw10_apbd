using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using cw10.DTOs.Requests;
using cw10.Models;
using cw10.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentEntrollmentsController : ControllerBase
    {
        private readonly IStudentDbService dbService;


        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(dbService.GetStudents());
        }

        [HttpGet("{index}")]
        public IActionResult GetStudents(string index)
        {
            return Ok(dbService.GetStudent(index));
        }

        [HttpPut]
        public IActionResult UpdateStudent(Student student)
        {
            if(String.IsNullOrEmpty(student.IndexNumber))
            {
                return BadRequest("Student index is mandatory!");
            }
            
            return Ok(dbService.UpdateStudent(student));
        }

        [HttpDelete("{index}")]
        public IActionResult DeleteStudent(string index)
        {
            dbService.DeleteStudent(index);
            return Ok("Record deleted");
        }

        [Route("promotion")]
        [HttpPost]
        public IActionResult PromoteStudent(StudentPromotionDTO promotion)
        {
            return Created("enrollments/promotions", new EnrollmentDTO(dbService.PromoteStudent(promotion)));
        }

        [HttpPost()]
        public IActionResult EnrollStudent(StudentEnrollmentDTO enrollment)
        {
            try
            {
                var result = dbService.EnrollStudent(enrollment);
                return Ok(new EnrollmentDTO(result));
            }catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return BadRequest("Incomplete data");
        }



    }
}