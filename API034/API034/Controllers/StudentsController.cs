using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API034.Models;

namespace API034.Controllers
{
    public class StudentsController : ApiController
    {
        static List<Student> students = new List<Student>()
        {
            new Student() { Id = 1, Name = "Tom" },
            new Student() { Id = 2, Name = "Sam" },
            new Student() { Id = 3, Name = "John" }
        };

        //public HttpResponseMessage Get()
        public IHttpActionResult Get()
        {
            //return Request.CreateResponse(HttpStatusCode.OK, students);
            return Ok(students);
        }

        //public HttpResponseMessage Get(int id)
        public IHttpActionResult Get(int id)
        {
            Student student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                //return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Student not found");
                //return NotFound();
                return Content(HttpStatusCode.NotFound, "Student not found");
            }
            //return Request.CreateResponse(HttpStatusCode.OK, student);
            return Ok(student);
        }
    }
}
