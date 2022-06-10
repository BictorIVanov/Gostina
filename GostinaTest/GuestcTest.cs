using GostinaString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GostinaTest
{
    [TestClass]
    public class GuestcTest
    {
        [TestMethod]
        public void Gostina_Guestc_ReturnNull()
        {
            //  Arrange
            string text = "";
            string resultText = "";

            //  Act.
            GostinClass objClass = new GostinClass();

            string result = objClass.Gostin(text);

            //Assert
            Assert.AreEqual(result, resultText);

        }
        [TestMethod]
        public void Gostina_Guestc_ReturnGrangSurname()
        {
            //  Arrange
            string text = "Yoda";
            string resultText = "adoY";

            //  Act.
            GostinClass objClass = new GostinClass();

            string result = objClass.Gostin(text);

            //Assert
            Assert.AreEqual(result, resultText);
        }

        [TestMethod]
        public void Gostina_Guestc_Returnname()
        {
            //  Arrange
            string text = "Obivan";
            string resultText = "navibO";

            //  Act.
            GostinClass objClass = new GostinClass();

            string result = objClass.Gostin(text);

            //Assert
            Assert.AreEqual(result, resultText);

        }

        [TestMethod]
        public void Gostina_Guestc_ReturnName()
        {
            //  Arrange
            string text = "Mixail";
            string resultText = "liaxiM";

            //  Act.
            GostinClass objClass = new GostinClass();

            string result = objClass.Gostin(text);

            //Assert
            Assert.AreEqual(result, resultText);
        }

        [TestMethod]
        public void Gostina_Guestc_ReturnNameGuestc()
        {
            //  Arrange
            string text = "Ansoka";
            string resultText = "akosnA";

            //  Act.
            GostinClass objClass = new GostinClass();

            string result = objClass.Gostin(text);

            //Assert
            Assert.AreEqual(result, resultText);

        }
        [TestMethod]
        public void Gostina_Guestc_ReturnGuestcName()
        {
            //  Arrange
            string text = "Kalifa";
            string resultText = "afilaK";

            //  Act.
            GostinClass objClass = new GostinClass();

            string result = objClass.Gostin(text);

            //Assert
            Assert.AreEqual(result, resultText);


        }
        [TestMethod]
        public void Gostina_Guestc_ReturnNAme()
        {
            //  Arrange
            string text = "Netro";
            string resultText = "orteN";

            //  Act.
            GostinClass objClass = new GostinClass();

            string result = objClass.Gostin(text);

            //Assert
            Assert.AreEqual(result, resultText);
        }
        [TestMethod]
        public void Gostina_Guestc_NameReturn()
        {
            //  Arrange
            string text = "Katuni";
            string resultText = "inutaK";

            //  Act.
            GostinClass objClass = new GostinClass();

            string result = objClass.Gostin(text);

            //Assert
            Assert.AreEqual(result, resultText);
        }


        [TestMethod]
        public void Gostina_Guestc_GuestcnameReturn()
        {
            //  Arrange
            string text = "Asnla";
            string resultText = "alnsA";

            //  Act.
            GostinClass objClass = new GostinClass();

            string result = objClass.Gostin(text);

            //Assert
            Assert.AreEqual(result, resultText);
        }
        [TestMethod]
        public void Gostina_Guestc_Returname()
        {
            //  Arrange
            string text = "Barric";
            string resultText = "cirraB";

            //  Act.
            GostinClass objClass = new GostinClass();

            string result = objClass.Gostin(text);

            //Assert
            Assert.AreEqual(result, resultText);
        }
        [TestMethod]
        public void Gostina_Guestc_ReturnnameGuestc()
        {
            //  Arrange
            string text = "Kel";
            string resultText = "leK";

            //  Act.
            GostinClass objClass = new GostinClass();

            string result = objClass.Gostin(text);

            //Assert
            Assert.AreEqual(result, resultText);
        }
    }
}
