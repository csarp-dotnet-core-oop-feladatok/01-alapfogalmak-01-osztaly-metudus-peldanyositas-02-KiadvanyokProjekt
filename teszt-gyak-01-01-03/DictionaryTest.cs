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
    public class     DictionaryTest
    {
        [TestMethod()]
        public void RentTest()
        {
            Dictionary book = new Dictionary();
            string expected = "Szótár kölcsönzés.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            book.Rent();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Dictionary->Rent függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void OpenTest()
        {
            Dictionary book = new Dictionary();
            string expected = "Szótár kinyitás.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            book.Open();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Dictionary->Open függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void CloseTest()
        {
            Dictionary book = new Dictionary();
            string expected = "Szótár becsukás.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            book.Close();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Dictionary->Close függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void HandBackTest()
        {
            Dictionary book = new Dictionary();
            string expected = "Szótár visszaadás.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            book.HandBack();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Dictionary-HandBack függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void ReadTest()
        {
            Dictionary book = new Dictionary();
            string expected = "Szótár olvasás.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            book.Read();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Dictionary-Read függvény nem a megfelelő szöveget írja a képernyőre!");
        }
    }
}