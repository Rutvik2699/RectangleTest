using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RectangleTest;

namespace RectangleUnitTests
{
    public class RectangleTest
    {
        [TestFixture]
        public class RectangleUnitTests
        {

            //Test number 1
            [Test]
            public void ValidRectangle_Input1()
            {

                //Arrange
                int length = 1;
                Rectangle rect = new Rectangle();

                //Act
                int actual = rect.GetLength();

                //Assert
                Assert.AreEqual(length, actual);

            }

            //Test number 2
            [Test]
            public void ValidRectangle_Input15and50()
            {

                //Arrange
                int length = 15;
                int width = 50;

                int expectedLength = 15;
                Rectangle rect = new Rectangle(length,width);

                //Act
                int actual = rect.GetLength();

                //Assert
                Assert.AreEqual(expectedLength, actual);

            }

            //Test number 3
            [Test]
            public void ValidRectangle_Input_NegativeParameters()
            {

                //Arrange
                int length = -20;
                int width = 50;

                int expectedLength = 20;
                Rectangle rect = new Rectangle(length,width);

                //Act
                int actual = rect.GetLength();

                //Assert
                Assert.AreEqual(expectedLength, actual);

            }
            //Test number 4
            [Test]
            public void SetLength_Input3()
            {

                //Arrange
                int length = 3;


                int expectedLength = 3;
                Rectangle rect = new Rectangle();

                //Act
                int actual = rect.SetLength(length);

                //Assert
                Assert.AreEqual(expectedLength, actual);

            }

            //Test number 5
            [Test]
            public void SetLength_Overwrite_Length()
            {

                //Arrange
                int length = 3;
                int width = 5;

               
                Rectangle rect = new Rectangle(length,width);


                int SetNewLength = 6;
                rect.SetLength(SetNewLength);
                //Act
                int actual = rect.GetLength();

                //Assert
                Assert.AreEqual(SetNewLength, actual);

            }

            //Test number 6
            [Test]
            public void SetLength_Check_for_less_than1()
            {

                //Arrange
                int length = 0;
                


                Rectangle rect = new Rectangle();


               
                //Act
                int actual = rect.GetLength();

                //Assert
                Assert.Throws<Exception>(() => rect.SetLength(length));

            }


            //Test number 7
            [Test]
            public void ValidRectangle_Width_Input1()
            {

                //Arrange
                int width = 1;
                Rectangle rect = new Rectangle();

                //Act
                int actual = rect.GetLength();

                //Assert
                Assert.AreEqual(width, actual);

            }

            //Test number 8
            [Test]
            public void ValidRectangle_Width_Input33and55()
            {

                //Arrange
                int length = 33;
                int width = 55;

                int expectedWidth = 55;
                Rectangle rect = new Rectangle(length, width);

                //Act
                int actual = rect.GetWidth();

                //Assert
                Assert.AreEqual(expectedWidth, actual);

            }

            //Test number 9
            [Test]
            public void ValidRectangle_Width_Input_NegativeParameters()
            {

                //Arrange
                int length = 20;
                int width = -50;

                int expectedWidth = 50;
                Rectangle rect = new Rectangle(length, width);

                //Act
                int actual = rect.GetWidth();

                //Assert
                Assert.AreEqual(expectedWidth, actual);

            }



            //Test number 10
            [Test]
            public void SetWidth_Input5()
            {

                //Arrange
                int width = 5;


                int expectedWidth = 5;
                Rectangle rect = new Rectangle();

                //Act
                int actual = rect.SetWidth(width);

                //Assert
                Assert.AreEqual(expectedWidth, actual);

            }

            //Test number 11
            [Test]
            public void SetWidth_Overwrite_Width()
            {

                //Arrange
                int length = 3;
                int width = 5;


                Rectangle rect = new Rectangle(length,width);


                int SetNewWidth = 9;
                rect.SetWidth(SetNewWidth);
                //Act
                int actual = rect.GetWidth();

                //Assert
                Assert.AreEqual(SetNewWidth, actual);

            }

            //Test number 12
            [Test]
            public void SetWidth_Check_for_less_than1()
            {

                //Arrange
                int width = 0;



                Rectangle rect = new Rectangle();



                //Act
                int actual = rect.GetWidth();

                //Assert
                Assert.Throws<Exception>(() => rect.SetLength(width));

            }

            //Test number 13
            [Test]
            public void Perimeter_length3width6_Return18()
            {

                //Arrange
                int length = 3;
                int width = 6;

                int expectedResult = 18;

                Rectangle rect = new Rectangle(length,width);



                //Act
                int actual = rect.GetPerimeter();

                //Assert
                Assert.AreEqual(expectedResult, actual);

            }

            //Test number 14
            [Test]
            public void Perimeter_NegativeInput_PositiveReturns()
            {

                //Arrange
                int length = -6;
                int width = -9;

                int expectedResult = 30;

                Rectangle rect = new Rectangle(length, width);



                //Act
                int actual = rect.GetPerimeter();

                //Assert
                Assert.AreEqual(expectedResult, actual);

            }

            //Test number 15
            [Test]
            public void Perimeter_throws_exception_when_input_zero()
            {

                //Arrange
                int length = 0;
                int width = 0;

               

                Rectangle rect = new Rectangle(length, width);

                //Act
              

                //Assert
                Assert.Throws<Exception>(()=> rect.GetPerimeter());

            }

            //Test number 16
            [Test]
            public void Area_length5width2_Return10()
            {

                //Arrange
                int length = 5;
                int width = 2;

                int expectedResult = 10;

                Rectangle rect = new Rectangle(length, width);



                //Act
                int actual = rect.GetArea();

                //Assert
                Assert.AreEqual(expectedResult, actual);

            }

            //Test number 17
            [Test]
            public void Area_NegativeInput_PositiveReturns()
            {

                //Arrange
                int length = -5;
                int width = -4;

                int expectedResult = 20;

                Rectangle rect = new Rectangle(length, width);



                //Act
                int actual = rect.GetArea();

                //Assert
                Assert.AreEqual(expectedResult, actual);

            }

            //Test number 18
            [Test]
            public void Area_throws_exception_when_input_zero()
            {

                //Arrange
                int length = 0;
                int width = 0;



                Rectangle rect = new Rectangle(length, width);

                //Act


                //Assert
                Assert.Throws<Exception>(() => rect.GetArea());

            }



        }
    }
}
