using LabaratoryWorkNum34;

namespace TestColor
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0.345, 0.654, 0.6765)]
        [TestCase(0.3000, 0.600, 0.6700)]
        [TestCase(0.1, 0.1, 0.1)]
        [TestCase(0.0000345, 0.0000654, 0.00006765)]
        [TestCase(0.0, 0.0, 0.0)]
        [TestCase(1, 1, 1)]
        public void TestToString(double red, double green, double blue)
        {
            //Arange
            ColorRGB color = new ColorRGB();
            color = ColorRGB.ColorInRGB(red, green, blue);
            //Act
            var str = color.ToString();

            //Assert

            Assert.AreEqual($"RGB({red}/{green}/{blue}) CMY({color.Cyan}/{color.Magenta}/{color.Yellow})", str);
        }

        [Test]
        public void TestConstructor()
        {
            //Arange
            ColorRGB rgb = new ColorRGB();
            //Act
            var r = rgb.Red;
            var g = rgb.Green;
            var b = rgb.Blue;
            //Assert
            Assert.AreEqual(r, 0.0);
            Assert.AreEqual(g, 0.0);
            Assert.AreEqual(b, 0.0);

        }

        [TestCase(0.543, 0.654, 0.765)]
        [TestCase(0.0, 0.0, 0.0)]
        [TestCase(0.00034, 0.0000654, 0.000765)]
        [TestCase(0.54300, 0.65400, 0.76500)]
        [TestCase(1, 1, 1)]
        [TestCase(1, 1 + (double)0.1e-322, 1 + (double)0.1e-322)]
        public void TestConstructorColorInRGB(double red, double green, double blue)
        {
            //Arrage
            ColorRGB color = new ColorRGB();
            color = ColorRGB.ColorInRGB(red, green, blue);
            //Act
            var r = color.Red;
            var g = color.Green;
            var b = color.Blue;
            //Assert
            Assert.AreEqual(red, r);
            Assert.AreEqual(green, g);
            Assert.AreEqual(blue, b);
        }


        private void CreateFractionInRGB()
        {
            ColorRGB color = new ColorRGB();
            color = ColorRGB.ColorInRGB(1, 1.0001, 0.654);
        }

        [Test]

        public void TestConstructorColorInRGB()
        {
            Assert.Throws<ArgumentException>(CreateFractionInRGB);
        }

        private void CreateFractionInRGB1()
        {
            ColorRGB color = new ColorRGB();
            color = ColorRGB.ColorInRGB(1, 1, -0.001);
        }

        [Test]



        public void TestConstructorColorInRGB1()
        {
            Assert.Throws<ArgumentException>(CreateFractionInRGB1);
        }





        [TestCase(0.543, 0.654, 0.765)]
        [TestCase(0.0, 0.0, 0.0)]
        [TestCase(0.00034, 0.0000654, 0.000765)]
        [TestCase(0.54300, 0.65400, 0.76500)]
        [TestCase(1, 1, 1)]
        [TestCase(1 + (double)0.1e-322, 1 + (double)0.1e-322, 1 + (double)0.1e-322)]
        public void TestConstructorColorInCMY(double cyan, double magenta, double yellow)
        {
            //Arrage
            ColorRGB color = new ColorRGB();
            color = ColorRGB.ColorInCMY(cyan, magenta, yellow);
            //Act
            var r = color.Red;
            var g = color.Green;
            var b = color.Blue;
            //Assert
            Assert.AreEqual(1 - cyan, r);
            Assert.AreEqual(1 - magenta, g);
            Assert.AreEqual(1 - yellow, b);
        }





        private void CreateFractionInCMY()
        {
            ColorRGB color = new ColorRGB();
            color = ColorRGB.ColorInCMY(1, 1.0001, 0.654);
        }

        [Test]



        public void TestConstructorColorInCMY()
        {
            Assert.Throws<ArgumentException>(CreateFractionInCMY);
        }



        private void CreateFractionInCMY1()
        {
            ColorRGB color = new ColorRGB();
            color = ColorRGB.ColorInCMY(1, 1, -0.001);
        }

        [Test]



        public void TestConstructorColorInCMY1()
        {
            Assert.Throws<ArgumentException>(CreateFractionInCMY1);
        }







        [TestCase(new double[] { 0.45, 0.65, 0.1 }, new double[] { 0.45, 0.1, 0.78 })]
        [TestCase(new double[] { 0.45, 0.65, 0.76 }, new double[] { 0.0, 0.0, 0.0 })]

        public void TestOperatorPlus(double[] arr1, double[] arr2)
        {
            //Arrage
            ColorRGB color1 = new ColorRGB();
            color1 = ColorRGB.ColorInRGB(arr1[0], arr1[1], arr1[2]);

            ColorRGB color2 = new ColorRGB();
            color2 = ColorRGB.ColorInRGB(arr2[0], arr2[1], arr2[2]);
            //Act

            var red = (color1 + color2).Red;
            var green = (color1 + color2).Green;
            var blue = (color1 + color2).Blue;

            //Assert
            Assert.AreEqual(arr1[0] + arr2[0], red);
            Assert.AreEqual(arr1[1] + arr2[1], green);
            Assert.AreEqual(arr1[2] + arr2[2], blue);
        }



        private void CreateRGBCatch1()
        {
            ColorRGB c1 = new ColorRGB();
            c1 = ColorRGB.ColorInRGB(0.423, 0.345, 1);
            ColorRGB c2 = new ColorRGB();
            c2 = ColorRGB.ColorInRGB(0.423, 0.345, 0.534);
            ColorRGB c3 = c1 + c2;
        }



        [Test]
        public void TestOperatorPlusOnCatch()
        {
            Assert.Catch<ArgumentException>(CreateRGBCatch1);
        }






        [TestCase(new double[] { 0.45, 0.65, 0.78 }, new double[] { 0.45, 0.1, 0.1 })]
        [TestCase(new double[] { 0.45, 0.65, 0.76 }, new double[] { 0.0, 0.0, 0.0 })]

        public void TestOperatorMinus(double[] arr1, double[] arr2)
        {
            //Arrage
            ColorRGB color1 = new ColorRGB();
            color1 = ColorRGB.ColorInRGB(arr1[0], arr1[1], arr1[2]);

            ColorRGB color2 = new ColorRGB();
            color2 = ColorRGB.ColorInRGB(arr2[0], arr2[1], arr2[2]);
            //Act

            var red = (color1 - color2).Red;
            var green = (color1 - color2).Green;
            var blue = (color1 - color2).Blue;

            //Assert
            Assert.AreEqual(arr1[0] - arr2[0], red);
            Assert.AreEqual(arr1[1] - arr2[1], green);
            Assert.AreEqual(arr1[2] - arr2[2], blue);
        }

        private void CreateCMYCatch1()
        {
            ColorRGB c1 = new ColorRGB();
            c1 = ColorRGB.ColorInRGB(0.423, 0.345, 0.54);
            ColorRGB c2 = new ColorRGB();
            c2 = ColorRGB.ColorInRGB(0.423, 0.345, 1);
            ColorRGB c3 = c1 - c2;
        }



        [Test]
        public void TestOperatorPlusOnCatchCMY()
        {
            Assert.Catch<ArgumentException>(CreateCMYCatch1);
        }




    }
}