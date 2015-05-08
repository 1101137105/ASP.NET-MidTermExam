using KuasCore.Dao;
using KuasCore.Dao.Impl;
using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Services.Impl
{
    public class CourseService :ICourseService
    {
        public ICourseDao CourseDao = new CourseDao();

        public IList<Course> GetAllCourses()
        {
            return CourseDao.GetAllCourses();
        }

        public Course GetCourseByName(string name)
        {
            return CourseDao.GetCourseByName(name);
        }


        public Course InsertCourse()
        {
            return CourseDao.InsertCourse();
        }
    }
}
