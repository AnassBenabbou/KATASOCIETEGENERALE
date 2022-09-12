using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTestProject1
{
    public class KataTest
    {
        [Test]
        public void DigitEgalZero()
        {
            List<char> Tab1 = new List<char>() { ' ', '_', ' ' };
            List<char> Tab2 = new List<char>() { '|', ' ', '|' };
            List<char> Tab3 = new List<char>() { '|', '_', '|' };
            Assert.AreEqual(0, new Kata().CalculDigitZero(Tab1, Tab2, Tab3));

        }

        [Test]
        public void DigitEgalUn()
        {
            List<char> Tab1 = new List<char>() { ' ', ' ', ' ' };
            List<char> Tab2 = new List<char>() { ' ', ' ', '|' };
            List<char> Tab3 = new List<char>() { ' ', ' ', '|' };
            Assert.AreEqual(1, new Kata().CalculDigitUn(Tab1, Tab2, Tab3));

        }

        [Test]
        public void DigitEgalDeux()
        {
            List<char> Tab1 = new List<char>() { ' ', '_', ' ' };
            List<char> Tab2 = new List<char>() { ' ', '_', '|' };
            List<char> Tab3 = new List<char>() { '|', '_', ' ' };
            Assert.AreEqual(2, new Kata().CalculDigitDeux(Tab1, Tab2, Tab3));

        }

        [Test]
        public void DigitEgalTrois()
        {
            List<char> Tab1 = new List<char>() { ' ', '_', ' ' };
            List<char> Tab2 = new List<char>() { ' ', '_', '|' };
            List<char> Tab3 = new List<char>() { ' ', '_', '|' };
            Assert.AreEqual(3, new Kata().CalculDigitTrois(Tab1, Tab2, Tab3));

        }

        [Test]
        public void DigitEgalQuatre()
        {
            List<char> Tab1 = new List<char>() { ' ', ' ', ' ' };
            List<char> Tab2 = new List<char>() { '|', '_', '|' };
            List<char> Tab3 = new List<char>() { ' ', ' ', '|' };
            Assert.AreEqual(4, new Kata().CalculDigitQuatre(Tab1, Tab2, Tab3));

        }

        [Test]
        public void DigitEgalCinq()
        {
            List<char> Tab1 = new List<char>() { ' ', '_', ' ' };
            List<char> Tab2 = new List<char>() { '|', '_', ' ' };
            List<char> Tab3 = new List<char>() { ' ', '_', '|' };
            Assert.AreEqual(5, new Kata().CalculDigitCinq(Tab1, Tab2, Tab3));

        }

        [Test]
        public void DigitEgalSix()
        {
            List<char> Tab1 = new List<char>() { ' ', '_', ' ' };
            List<char> Tab2 = new List<char>() { '|', '_', ' ' };
            List<char> Tab3 = new List<char>() { '|', '_', '|' };
            Assert.AreEqual(6, new Kata().CalculDigitSix(Tab1, Tab2, Tab3));

        }

        [Test]
        public void DigitEgalSept()
        {
            List<char> Tab1 = new List<char>() { ' ', '_', ' ' };
            List<char> Tab2 = new List<char>() { ' ', ' ', '|' };
            List<char> Tab3 = new List<char>() { ' ', ' ', '|' };
            Assert.AreEqual(7, new Kata().CalculDigitSept(Tab1, Tab2, Tab3));

        }

        [Test]
        public void DigitEgalHuit()
        {
            List<char> Tab1 = new List<char>() { ' ', '_', ' ' };
            List<char> Tab2 = new List<char>() { '|', '_', '|' };
            List<char> Tab3 = new List<char>() { '|', '_', '|' };
            Assert.AreEqual(8, new Kata().CalculDigitHuit(Tab1, Tab2, Tab3));

        }

        [Test]
        public void DigitEgalNeuf()
        {
            List<char> Tab1 = new List<char>() { ' ', '_', ' ' };
            List<char> Tab2 = new List<char>() { '|', '_', '|' };
            List<char> Tab3 = new List<char>() { ' ', '_', '|' };
            Assert.AreEqual(9, new Kata().CalculDigitNeuf(Tab1, Tab2, Tab3));

        }

        [Test]
        public void NumCompteEgalZeros()
        {
            string Ligne1 = " _   _   _   _   _   _   _   _   _  ";
            string Ligne2 = "| | | | | | | | | | | | | | | | | | ";
            string Ligne3 = "|_| |_| |_| |_| |_| |_| |_| |_| |_| ";

            Assert.AreEqual("000000000", new Kata().GenerateNumCompte(Ligne1, Ligne2, Ligne3));
        }

        [Test]
        public void NumCompteEgalUns()
        {
            string Ligne1 = "                                    ";
            string Ligne2 = "  |   |   |   |   |   |   |   |   | ";
            string Ligne3 = "  |   |   |   |   |   |   |   |   | ";
   
            Assert.AreEqual("111111111", new Kata().GenerateNumCompte(Ligne1, Ligne2, Ligne3));
        }

        [Test]
        public void NumCompteEgalDeux()
        {
            string Ligne1 = " _   _   _   _   _   _   _   _   _  ";
            string Ligne2 = " _|  _|  _|  _|  _|  _|  _|  _|  _| ";
            string Ligne3 = "|_  |_  |_  |_  |_  |_  |_  |_  |_  ";

            Assert.AreEqual("222222222", new Kata().GenerateNumCompte(Ligne1, Ligne2, Ligne3));
        }

        [Test]
        public void NumCompteEgalTrois()
        {
            string Ligne1 = " _   _   _   _   _   _   _   _   _  ";
            string Ligne2 = " _|  _|  _|  _|  _|  _|  _|  _|  _| ";
            string Ligne3 = " _|  _|  _|  _|  _|  _|  _|  _|  _| ";

            Assert.AreEqual("333333333", new Kata().GenerateNumCompte(Ligne1, Ligne2, Ligne3));
        }

        [Test]
        public void NumCompteEgalQuatres()
        {
            string Ligne1 = "                                    ";
            string Ligne2 = "|_| |_| |_| |_| |_| |_| |_| |_| |_| ";
            string Ligne3 = "  |   |   |   |   |   |   |   |   | ";

            Assert.AreEqual("444444444", new Kata().GenerateNumCompte(Ligne1, Ligne2, Ligne3));
        }

        [Test]
        public void NumCompteEgalCinqs()
        {
            string Ligne1 = " _   _   _   _   _   _   _   _   _  ";
            string Ligne2 = "|_  |_  |_  |_  |_  |_  |_  |_  |_  ";
            string Ligne3 = " _|  _|  _|  _|  _|  _|  _|  _|  _| ";

            Assert.AreEqual("555555555", new Kata().GenerateNumCompte(Ligne1, Ligne2, Ligne3));
        }

        [Test]
        public void NumCompteEgalSix()
        {
            string Ligne1 = " _   _   _   _   _   _   _   _   _  ";
            string Ligne2 = "|_  |_  |_  |_  |_  |_  |_  |_  |_  ";
            string Ligne3 = "|_| |_| |_| |_| |_| |_| |_| |_| |_| ";

            Assert.AreEqual("666666666", new Kata().GenerateNumCompte(Ligne1, Ligne2, Ligne3));
        }
        [Test]
        public void NumCompteEgalSepts()
        {
            string Ligne1 = " _   _   _   _   _   _   _   _   _  ";
            string Ligne2 = "  |   |   |   |   |   |   |   |   | ";
            string Ligne3 = "  |   |   |   |   |   |   |   |   | ";

            Assert.AreEqual("777777777", new Kata().GenerateNumCompte(Ligne1, Ligne2, Ligne3));
        }
        [Test]
        public void NumCompteEgalHuites()
        {
            string Ligne1 = " _   _   _   _   _   _   _   _   _  ";
            string Ligne2 = "|_| |_| |_| |_| |_| |_| |_| |_| |_| ";
            string Ligne3 = "|_| |_| |_| |_| |_| |_| |_| |_| |_| ";

            Assert.AreEqual("888888888", new Kata().GenerateNumCompte(Ligne1, Ligne2, Ligne3));
        }

        [Test]
        public void NumCompteEgalNeufs()
        {
            string Ligne1 = " _   _   _   _   _   _   _   _   _  ";
            string Ligne2 = "|_| |_| |_| |_| |_| |_| |_| |_| |_| ";
            string Ligne3 = " _|  _|  _|  _|  _|  _|  _|  _|  _| ";

            Assert.AreEqual("999999999", new Kata().GenerateNumCompte(Ligne1, Ligne2, Ligne3));
        }

        [Test]
        public void NumCompteEgalMixte()
        {
            string Ligne1 = "     _   _       _   _   _   _   _  ";
            string Ligne2 = "  |  _|  _| |_| |_  |_    | |_| |_| ";
            string Ligne3 = "  | |_   _|   |  _| |_|   | |_|  _| ";

            Assert.AreEqual("123456789", new Kata().GenerateNumCompte(Ligne1, Ligne2, Ligne3));
        }
    }
}
