using KuasCore.Dao;
using KuasCore.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Testing.Microsoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCoreTests.Dao
{
    [TestClass]
   public class CourseDaoUnitTest : AbstractDependencyInjectionSpringContextTests
    {
        #region 單元測試 Spring 必寫的內容

        override protected string[] ConfigLocations
        {
            get
            {
                return new String[] { 
                    // assembly://MyAssembly/MyNamespace/ApplicationContext.xml
                    "~/Config/KuasCoreDatabase.xml",
                    "~/Config/CourseText.xml" 
                };
            }
        }

        #endregion
        public ICourseDao CourseDao { get; set; }

        [TestMethod]
        public void TestCourseDao_GetCourseByName()
        {
            Course course = CourseDao.GetCourseByName("Java");
            Assert.IsNotNull(course);
            Console.WriteLine("課程編號為 = " + course.courseID);
            Console.WriteLine("課程名稱為 = " + course.courseName);
            Console.WriteLine("課程描述為 = " + course.courseDescription);
        }
        [TestMethod]
        public void TestCourseDao_InsertCourse()
        {
            Course course = CourseDao.InsertCourse();
            Assert.IsNotNull(course);
            Console.WriteLine("新增成功" );
            
        }

    }
}
