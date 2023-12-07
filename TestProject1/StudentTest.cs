using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClassLibrary;

namespace TestProject1
{
    public class StudentTest
    {
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student();
            student.Name = "Masudha";
            // Act
            string studentName = student.Name;
            // Assert
            Assert.AreEqual("Masudha", studentName);
        }
        [Test]
        public void TestStudentAddress()
        {
            // Arrange
            Student student = new Student();
            student.Address = "123 Main St";
            // Act
            string studentAddress = student.Address;
            // Assert
            Assert.AreEqual("123 Main St", studentAddress);
        }
    }
}
