using Microsoft.VisualStudio.TestTools.UnitTesting;
using KonyvtarProjekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KonyvtarProjekt.Tests
{
    [TestClass()]
    public class EncyclopediaTest
    {
        [TestMethod()]
        public void RentTest()
        {
            Encyclopedia book = new Encyclopedia();
            string expected = "Lexikon kölcsönzés.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            book.Rent();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Encyclopedia->Rent függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void OpenTest()
        {
            Encyclopedia book = new Encyclopedia();
            string expected = "Lexikon kinyitás.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            book.Open();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Encyclopedia->Open függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void CloseTest()
        {
            Encyclopedia book = new Encyclopedia();
            string expected = "Lexikon becsukás.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            book.Close();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Encyclopedia->Close függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void HandBackTest()
        {
            Encyclopedia book = new Encyclopedia();
            string expected = "Lexikon visszaadás.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            book.HandBack();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Encyclopedia-HandBack függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void ReadTest()
        {
            Encyclopedia book = new Encyclopedia();
            string expected = "Lexikon olvasás.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            book.Read();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Encyclopedia-Read függvény nem a megfelelő szöveget írja a képernyőre!");
        }
    }
}