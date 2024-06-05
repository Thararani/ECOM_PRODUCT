using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group4_Assignment2;
using NUnit.Framework;

namespace TestProducts
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void InputProductID_Input7andSamsungand800and9_ResultProductID()

        {

            //Arrange

            int productID = 7;

            string productName = "Samsung";

            int price = 800;

            int stock = 9;

            int expected = 7;

            //Act

            Group4_Assignment2.Product productObj = new Group4_Assignment2.Product(productID, productName, price, stock);

            int actual = productObj.ProductID;

            //Assert

            Assert.That(expected, Is.EqualTo(actual));

        }

        [Test]
        public void InputProductID_Input70000andOneplusand400and8_ResultProductID()

        {

            //Arrange

            int productID = 70000;

            string productName = "Oneplus";

            int price = 400;

            int stock = 8;

            int expected = 70000;

            //Act

            Group4_Assignment2.Product productObj = new Group4_Assignment2.Product(productID, productName, price, stock);

            int actual = productObj.ProductID;

            //Assert

            Assert.That(expected, Is.EqualTo(actual));

        }

        [Test]
        public void InputProductID_Input45000andAsusand470and80_ResultProductID()

        {

            //Arrange

            int productID = 45000;

            string productName = "Asus";

            int price = 470;

            int stock = 80;

            int expected = 45000;

            //Act

            Group4_Assignment2.Product productObj = new Group4_Assignment2.Product(productID, productName, price, stock);

            int actual = productObj.ProductID;

            //Assert

            Assert.That(expected, Is.EqualTo(actual));

        }

        [Test]
        public void InputProductName_Input500andIphoneand70and6_ResultProductName()

        {

            //Arrange

            int productID = 500;

            string productName = "Iphone";

            int price = 70;

            int stock = 6;

            string expected = "Iphone";

            //Act

            Group4_Assignment2.Product productObj = new Group4_Assignment2.Product(productID, productName, price, stock);

            string actual = productObj.ProductName;

            //Assert

            Assert.That(expected, Is.EqualTo(actual));

        }

        [Test]
        public void InputProductName_Input5000andIphoneand2700and20_ResultProductName()

        {

            //Arrange

            int productID = 55000;

            string productName = "Motorola";

            int price = 270;

            int stock = 600;

            string expected = "Motorola";

            //Act

            Group4_Assignment2.Product productObj = new Group4_Assignment2.Product(productID, productName, price, stock);

            string actual = productObj.ProductName;

            //Assert

            Assert.That(expected, Is.EqualTo(actual));

        }

        [Test]
        public void InputProductName_Input50000andHPand350and500_ResultProductName()

        {

            //Arrange

            int productID = 50000;

            string productName = "HP";

            int price = 350;

            int stock = 500;

            string expected = "HP";

            //Act

            Group4_Assignment2.Product productObj = new Group4_Assignment2.Product(productID, productName, price, stock);

            string actual = productObj.ProductName;

            //Assert

            Assert.That(expected, Is.EqualTo(actual));

        }
        [Test]
        public void InputProductStock_Input34000andIqooand700and7_ResultProductStock()

        {

            //Arrange

            int productID = 34000;

            string productName = "Iqoo";

            int price = 700;

            int stock = 7;

            int expected = 7;

            //Act

            Group4_Assignment2.Product productObj = new Group4_Assignment2.Product(productID, productName, price, stock);

            int actual = productObj.Stock;

            //Assert

            Assert.That(expected, Is.EqualTo(actual));

        }
        [Test]
        public void InputProductStock_Input8andDelland900and700000_ResultProductStock()

        {

            //Arrange

            int productID = 8;

            string productName = "Dell";

            int price = 900;

            int stock = 700000;

            int expected = 700000;

            //Act

            Group4_Assignment2.Product productObj = new Group4_Assignment2.Product(productID, productName, price, stock);

            int actual = productObj.Stock;

            //Assert

            Assert.That(expected, Is.EqualTo(actual));

        }
        [Test]
        public void InputProductStock_Input9andLenovoand200and420000_ResultProductStock()

        {

            //Arrange

            int productID = 9;

            string productName = "Lenovo";

            int price = 200;

            int stock = 420000;

            int expected = 420000;

            //Act

            Group4_Assignment2.Product productObj = new Group4_Assignment2.Product(productID, productName, price, stock);

            int actual = productObj.Stock;

            //Assert

            Assert.That(expected, Is.EqualTo(actual));

        }
        [Test]
        public void InputProductPrice_Input12andMsiand7and220000_ResultProductPrice()

        {

            //Arrange

            int productID = 12;

            string productName = "Msi";

            int price = 7;

            int stock = 220000;

            int expected = 7;

            //Act

            Group4_Assignment2.Product productObj = new Group4_Assignment2.Product(productID, productName, price, stock);

            int actual = productObj.Price;

            //Assert

            Assert.That(expected, Is.EqualTo(actual));

        }
        [Test]
        public void InputProductPrice_Input15andAcerand7000and240000_ResultProductPrice()

        {

            //Arrange

            int productID = 15;

            string productName = "Acer";

            int price = 7000;

            int stock = 240000;

            int expected = 7000;

            //Act

            Group4_Assignment2.Product productObj = new Group4_Assignment2.Product(productID, productName, price, stock);

            int actual = productObj.Price;

            //Assert

            Assert.That(expected, Is.EqualTo(actual));

        }
        [Test]
        public void InputProductPrice_Input18andLgand4500and440000_ResultProductPrice()

        {

            //Arrange

            int productID = 18;

            string productName = "Lg";

            int price = 4500;

            int stock = 440000;

            int expected = 4500;

            //Act

            Group4_Assignment2.Product productObj = new Group4_Assignment2.Product(productID, productName, price, stock);

            int actual = productObj.Price;

            //Assert

            Assert.That(expected, Is.EqualTo(actual));

        }
        [Test]

        public void InputIncreaseStock_Input700andLenovoand2000and400and5_ResultIncreasedstock()

        {

            //Arrange

            int productID = 700;

            string productName = "HP";

            int price = 2000;

            int stock = 400;

            int increaseStock = 5;

            int expected = 405;

            //Act

            Group4_Assignment2.Product productObj = new Group4_Assignment2.Product(productID, productName, price, stock);

            productObj.StockIncrease(increaseStock);

            int actual = productObj.Stock;

            //Assert

            Assert.That(expected, Is.EqualTo(actual));

        }
        [Test]

        public void InputIncreaseStock_Input800andAcerand3000and200and650000_ResultIncreasedstock()

        {

            //Arrange

            int productID = 800;

            string productName = "Acer";

            int price = 3000;

            int stock = 200;

            int increaseStock = 650000;

            int expected = 650200;

            //Act

            Group4_Assignment2.Product productObj = new Group4_Assignment2.Product(productID, productName, price, stock);

            productObj.StockIncrease(increaseStock);

            int actual = productObj.Stock;

            //Assert

            Assert.That(expected, Is.EqualTo(actual));

        }
        [Test]

        public void InputIncreaseStock_Input600andMacand2000and150and205500_ResultIncreasedstock()

        {

            //Arrange

            int productID = 600;

            string productName = "Mac";

            int price = 2000;

            int stock = 150;

            int increaseStock = 205500;

            int expected = 205650;

            //Act

            Group4_Assignment2.Product productObj = new Group4_Assignment2.Product(productID, productName, price, stock);

            productObj.StockIncrease(increaseStock);

            int actual = productObj.Stock;

            //Assert

            Assert.That(expected, Is.EqualTo(actual));

        }
        [Test]
        public void InputDecreaseStock_Input600andHPand2900and300and15_ResultDecreaseStock()
        {
            //Arrange
            int productID = 600;
            string productName = "HP";
            int price = 2900;
            int stock = 300;
            int DecreaseStock = 15;

            int expected = 285;

            //Act
            Group4_Assignment2.Product productObj = new Group4_Assignment2.Product(productID, productName, price, stock);
            productObj.StockDecrease(DecreaseStock);
            int actual = productObj.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void InputDecreaseStock_Input700andAsusand2500and100and200_ResultDecreaseStock()
        {
            //Arrange
            int productID = 700;
            string productName = "Asus";
            int price = 2500;
            int stock = 6000;
            int DecreaseStock = 200;

            int expected = 5800;

            //Act
            Group4_Assignment2.Product productObj = new Group4_Assignment2.Product(productID, productName, price, stock);
            productObj.StockDecrease(DecreaseStock);
            int actual = productObj.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void ValidDecreaseStock_Input700andHPand2300and100and2000_OutputDecreaseStock()
        {
            //Arrange
            int productID = 700;
            string productName = "HP";
            int price = 2300;
            int stock = 6000;
            int DecreaseStock = 2000;

            int expected = 4000;

            //Act
            Group4_Assignment2.Product productObj = new Group4_Assignment2.Product(productID, productName, price, stock);
            productObj.StockDecrease(DecreaseStock);
            int actual = productObj.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

    }
}
