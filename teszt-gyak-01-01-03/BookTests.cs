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
    public class BookTest
    {
        [TestMethod()]
        public void RentTest()
        {
            Book book = new Book();
            string expected = "Könyv kölcsönzés.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            book.Rent();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Book->Rent függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void OpenTest()
        {
            Book book = new Book();
            string expected = "Könyv kinyitás.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            book.Open();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Book->Open függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void CloseTest()
        {
            Book book = new Book();
            string expected = "Könyv becsukás.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            book.Close();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Book->Close függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void HandBackTest()
        {
            Book book = new Book();
            string expected = "Könyv visszaadás.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            book.HandBack();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Book-HandBack függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void ReadTest()
        {
            Book book = new Book();
            string expected = "Könyv olvasás.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            book.Read();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Book-Read függvény nem a megfelelő szöveget írja a képernyőre!");
        }
    }
}