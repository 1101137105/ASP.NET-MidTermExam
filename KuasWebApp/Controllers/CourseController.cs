using KuasCore.Models;
using KuasCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace KuasWebApp.Controllers
{
    public class CourseController : ApiController
    {
        public ICourseService CourseService { get; set; }
        [HttpGet]
        public IList<Course> GetAllEmployees()
        {
            var employees = CourseService.GetAllCourses();
            return employees;
        }

        [HttpGet]
        [ActionName("byName")]
        public Course GetCourseByName(string name)
        {
            var course = CourseService.GetCourseByName(name);

            if (course == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return course;
        }

    }
}