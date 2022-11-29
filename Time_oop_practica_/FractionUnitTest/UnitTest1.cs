using Time_oop_practica_;

namespace FractionUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, 0, 0)]
        [TestCase(3, 6, 34)]
        public void Test_ToString(int a, int b, int c)
        {
            Time aaa = new Time(a, b, c);

            var str = aaa.ToString();

            Assert.AreEqual($"{string.Format("{0:d2}", aaa.Hour)}:{string.Format("{0:d2}", aaa.Minute)}" +
                $":{string.Format("{0:d2}", aaa.Second)}",
                str);
        }

        [Test]
        public void Test_Constructor()
        {
            Time aaa = new Time(24, 65, 8);

            var a = aaa.Hour;
            var b = aaa.Minute;
            var c = aaa.Second;

            Assert.AreEqual(a, 1);
            Assert.AreEqual(b, 5);
            Assert.AreEqual(c, 8);
        }

        [Test]
        public void Test_ConstructorZero()
        {
            Time aaa = new Time();

            var a = aaa.Hour;
            var b = aaa.Minute;
            var c = aaa.Second;

            Assert.AreEqual(a, 0);
            Assert.AreEqual(b, 0);
            Assert.AreEqual(c, 0);
        }

        private void MakeConstructorCatch()
        {
            Time time = new Time(-1, -1, -1);
        }

        [Test]
        public void TestConstructorCatch()
        {
            Assert.Catch<ArgumentException>(MakeConstructorCatch);
        }




        [Test]
        public void Test_Constructor1()
        {
            Time aaa = new Time(0, 0, 86400);

            var a = aaa.Hour;
            var b = aaa.Minute; ;
            var c = aaa.Second;

            Assert.AreEqual(a, 0);
            Assert.AreEqual(b, 0);
            Assert.AreEqual(c, 0);
        }

        


        [Test]
        public void Test_operatorPlus()
        {
            Time t1 = new Time(54, 54, 76);
            Time t2 = new Time(4, 6, 8);

            var a = (t1 + t2).Hour;
            var b = (t1 + t2).Minute;
            var c = (t1 + t2).Second;

            Assert.AreEqual(a, 11);
            Assert.AreEqual(b, 1);
            Assert.AreEqual(c, 24);
        }

        [Test]
        public void Test_operatorMinus()
        {
            Time t1 = new Time(54, 54, 76);
            Time t2 = new Time(4, 6, 8);

            var a = (t1 - t2).Hour;
            var b = (t1 - t2).Minute;
            var c = (t1 - t2).Second;

            Assert.AreEqual(a, 2);
            Assert.AreEqual(b, 49);
            Assert.AreEqual(c, 8);
        }

        private void MinusCatch()
        {
            Time time1 = new Time(23,56,34);
            Time time2 = new Time(5, 7, 8);
            Time time3 = time2 - time1;
        }

        [Test]
        public void Test_operatorMinusCatch()
        {
            Assert.Catch<ArgumentException>(MinusCatch);
        }

        [Test]
        public void Test_operatorMulti()
        { 
            Time t2 = new Time(4, 6, 8);
            int k = 5;
            var a = k*t2.Hour;
            var b = k*t2.Minute;
            var c = k*t2.Second;

            Assert.AreEqual(a, 20);
            Assert.AreEqual(b, 30);
            Assert.AreEqual(c, 40);
        }


        private void MultyCatch()
        {
            Time time1 = new Time(1, 1, 1);
            int k = -1;
            Time time = time1*k;
        }

        [Test]
        public void Test_operatorMultyCatch()
        {
            Assert.Catch<ArgumentException>(MultyCatch);
        }

        [Test]
        public void TestOperatorMore()
        {
            Time t1 = new Time(1, 2, 3);
            Time t2 = new Time(1, 2, 4);

            Assert.True(t1 < t2);
        }
        [Test]
        public void TestOperatorNotMore()
        {
            Time t1 = new Time(1, 2, 3);
            Time t2 = new Time(1, 2, 4);

            Assert.IsFalse(t2<t1);
        }

        [Test]
        public void TestOperatorNotEqual()
        {
            Time t1 = new Time(1, 2, 3);
            Time t2 = new Time(1, 2, 3);

            Assert.IsFalse(t1 != t2);
        }
        [Test]
        public void TestOperatorNotEqual1()
        {
            Time t1 = new Time(1, 2, 3);
            Time t2 = new Time(1, 3, 3);

            Assert.True(t1 != t2);
        }
        [Test]
        public void TestOperatorEqual()
        {
            Time t1 = new Time(1, 2, 3);
            Time t2 = new Time(1, 2, 3);

            Assert.IsTrue(t1 == t2);
        }
        [Test]
        public void TestOperatorEqual1()
        {
            Time t1 = new Time(1, 2, 3);
            Time t2 = new Time(1, 3, 3);

            Assert.IsFalse(t1 == t2);
        }

        [Test]
        public void TestOperatorMoreOrEqual()
        {
            Time t1 = new Time(1, 2, 3);
            Time t2 = new Time(1, 3, 3);

            Assert.IsFalse(t1 >= t2);
        }
    }
}