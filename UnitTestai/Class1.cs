using NUnit.Framework;
using System;
namespace UnitTestai
{
    public class Class1
    {
        [Test]
        public void Dalyba_1_3()
        {
            double expectedResult = 0.33333333333333331;
            double actualResult = Skaiciuotuvas.Skaiciuotuvas.Dalyba(1, 3);
            Assert.AreEqual(expectedResult, actualResult);
            //passina nes copy paste expected result is testo rezultato
        }
        [Test]
        public void Daugyba_01_01()
        {
            double expectedResult = 0.01;
            double actualResult = Skaiciuotuvas.Skaiciuotuvas.SandaugaDu(0.1, 0.1);
            Assert.AreEqual(expectedResult, actualResult);
            //failina nes double, reiksme tokia bet jis raso po kablelio daug skaiciu, galima naudoti decimal(x.xm) ir viskas ok
        }
        [Test]
        public void SudetisDu_01_01()
        {
            double expectedResult = 0.2;
            double actualResult = Skaiciuotuvas.Skaiciuotuvas.SudetisDu(0.1, 0.1);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void SudetisDecimal_01_01()
        {
            decimal expectedResult = 0.2m;
            decimal actualResult = Skaiciuotuvas.Skaiciuotuvas.SudetisDecimal(0.1m, 0.1m);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void SandaugaDecimal_01_01()
        {
            decimal expectedResult = 0.01m;
            decimal actualResult = Skaiciuotuvas.Skaiciuotuvas.SandaugaDecimal(0.1m, 0.1m);
            Assert.AreEqual(expectedResult, actualResult);
        }
        //Uzduotis13
        //Testas “žalias” jeigu 995 dalijasi iš 3 (be liekanos)
        [Test]
        public void Dalyba_995_3()
        {
            int num = 995;
            Assert.IsFalse(num % 3 == 0);
        }
        //Testas “žalias” jeigu šiandien trečiadienis
        [Test]
        public void ArSiandienTreciadienis()
        {
            DateTime today = DateTime.Now;
            Assert.AreEqual(DayOfWeek.Wednesday, today.DayOfWeek);
        }
        //Testas “žalias” jeigu dabar yra 13h
        [Test]
        public void ArDabar13h()
        {
            var dateTimeNow = DateTime.Now;
            var expectedHour = 13;
            var currentHour = dateTimeNow.Hour;
            Assert.That(currentHour, Is.EqualTo(expectedHour));
        }
        //Bonus: Testas “žalias” jei nuo 1 iki 10 (imtinai) yra 4 lyginiai skaičiai
        //Su reference
        [Test]
        public void LyginiaiSkaiciai_1_10_Reference()
        {
            int[] intervalas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int actualResult = Uzduotis13.LyginiaiSkaiciai.Intervalas_1_10(intervalas,0);
            Assert.AreEqual(4, actualResult);
        }
        //Be reference
        [Test]
        public void LyginiaiSkaiciai_1_10()
        {
            int[] intervalas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int lyginiai = 0;
            foreach (int i in intervalas)
            {
                if (i % 2 == 0)
                {
                    lyginiai++;
                }
            }
            Assert.AreEqual(4, lyginiai);
        }
    }
}
