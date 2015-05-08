using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Impl
{
    public class CourseDao : GenericDao<Course>, ICourseDao
    {
        override protected IRowMapper<Course> GetRowMapper()
        {
            return new CourseRowMapper();
        }
        public IList<Course> GetAllCourses()
        {
            string command = @"SELECT * FROM Course ORDER BY courseID ASC";
            IList<Course> Courses = ExecuteQueryWithRowMapper(command);
            return Courses;
        }

        public Course GetCourseByName(string name)
        {
            string command = @"SELECT * FROM Course WHERE courseName = @name";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("name", DbType.String).Value = name;

            IList<Course> Courses = ExecuteQueryWithRowMapper(command, parameters);
            if (Courses.Count > 0)
            {
                return Courses[0];
            }

            return null;
        }

        public Course InsertCourse()
        {
            string sql = @"INSERT INTO [dbo].[Course]([courseID],[courseName],[courseDescription])
                             VALUES
                               (@Id,
                                @Name
                               ,@description);SELECT CAST(scope_identity() AS int);";
            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = "5";
            parameters.Add("Name", DbType.String).Value = "Account";
            parameters.Add("description", DbType.String).Value = "All Pass";
            IList<Course> Courses = ExecuteQueryWithRowMapper(sql, parameters);

            return Courses[0];

        }
    }
}
