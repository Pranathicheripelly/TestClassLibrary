using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClassLibrary;

namespace TestProject1
{
    [TestFixture]
    public class TeacherTest
    {
        [Test]
        public void TestTeacherName()
        {
            // Arrange
            Teacher myTeacher = new Teacher();
            myTeacher.Name = "Raju";
            // Act
            string teacherName = myTeacher.Name;
            // Assert
            Assert.AreEqual("Raju", teacherName);
        }
        [Test]
        public void TestClassId()
        {
            // Arrange
            Teacher myTeacher = new Teacher();
            myTeacher.Id = 1;
            // Act
            int tecaherId = myTeacher.Id;
            // Assert
            Assert.AreEqual(1, tecaherId);
        }
    }
}
