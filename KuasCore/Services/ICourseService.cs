using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Services
{
    public interface  ICourseService
    {
        IList<Course> GetAllCourses();
        Course GetCourseByName(string name);
        Course InsertCourse();
    }
}
