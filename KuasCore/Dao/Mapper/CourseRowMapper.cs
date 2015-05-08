using KuasCore.Models;
using Spring.Data.Generic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Mapper
{
    class CourseRowMapper : IRowMapper<Course>
    {
        public Course MapRow(IDataReader dataReader, int rowNum)
        {
            Course target = new Course();

            target.courseID = dataReader.GetString(dataReader.GetOrdinal("courseID"));
            target.courseName = dataReader.GetString(dataReader.GetOrdinal("courseName"));
            target.courseDescription = dataReader.GetString(dataReader.GetOrdinal("courseDescription"));

            return target;
        }
    }
}
