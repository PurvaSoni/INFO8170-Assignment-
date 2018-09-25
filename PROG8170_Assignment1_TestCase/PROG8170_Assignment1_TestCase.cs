using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prog8170_Assignment1;
using NUnit.Framework;

namespace PROG8170_Assignment1_TestCase
{

    [TestFixture]
    class PROG8170_Assignment1_TestCase
    {
        [Test]
        public void GetLength_input3_expectLengthEquals3()
        {
            //Arrange
            int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.GetLength();

            //Assert
            Assert.AreEqual(length, l);
        }
        
        [Test]

        public void SetLength_input5_expectLengthEquals6()
        {
            //Error while running
            int length = 6;
            Rectangle testRectangle1 = new Rectangle();

            //Act 
            testRectangle1.SetLength(length);

            //Assert
            Assert.AreEqual(length, 6);

        }

        [Test]
        public void GetWidth_input3_expectWidthEquals3()
        {
            //Arrange
            int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.GetWidth();

            //Assert
            Assert.AreEqual(width, w);
        }

        [Test]

        public void SetWidth_input5_expectWidthEquals5()
        {
            //Arrange
            int width = 5;
            Rectangle testRectangle1 = new Rectangle();

            //Act 
            testRectangle1.SetLength(width);

            //Assert
            Assert.AreEqual(width, 5);

        }


        [Test]

        public void GetPerimeter_input2_expectoutputequals8_()
        {
            //Arrange
            int l = 2;
            int w = 2;
            Rectangle testRectangle1 = new Rectangle(l,w);

            //Act 
            int perimeter = testRectangle1.GetParameter();

            //Assert
            Assert.AreEqual(perimeter, 8);
        }
 
        [Test]
        public void getArea_input2_expectAreaequals4()
        {
            //Arrange
            int l = 2;
            int w = 2;
            Rectangle testReactangle = new Rectangle(l, w);

            //Act
            int area = testReactangle.GetArea();

            //Assert
            Assert.AreEqual(area, 4);
            
        }
    }
}
