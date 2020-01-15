using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver(@"D:\03.PROYECTOS\01.BNBPUNTOS\PROYECTO REST\DesarrolloBNB");


            /*driver.Navigate().GoToUrl("http://apps.supernet.bo/ic/Autentication.aspx");
            Thread.Sleep(500);
            driver.FindElement(By.Id("IFMainContent_txtLogin")).Click();
            driver.FindElement(By.Id("IFMainContent_txtLogin")).Clear();
            driver.FindElement(By.Id("IFMainContent_txtLogin")).SendKeys("dmanzano@bnb.com.bo");
            driver.FindElement(By.Id("IFMainContent_txtPasswd")).Click();
            driver.FindElement(By.Id("IFMainContent_txtPasswd")).Clear();
            driver.FindElement(By.Id("IFMainContent_txtPasswd")).SendKeys("Daniela123*");
            driver.FindElement(By.Id("IFMainContent_btnEntrar")).Click();
            Thread.Sleep(1000);
            driver.Close();*/

            driver.Navigate().GoToUrl("http://10.16.22.88/BNBNet/IniciarSesion/IniciarIdentificador");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='UFV:'])[1]/following::div[1]")).Click();
            driver.FindElement(By.Id("IdentificadorEncriptado")).Click();
            driver.FindElement(By.Id("IdentificadorEncriptado")).Clear();
            driver.FindElement(By.Id("IdentificadorEncriptado")).SendKeys("clientecard");
            driver.FindElement(By.Id("RespuestaCapchaEncriptado")).Click();
            driver.FindElement(By.Id("RespuestaCapchaEncriptado")).Clear();
            driver.FindElement(By.Id("RespuestaCapchaEncriptado")).SendKeys("abcd");
            driver.FindElement(By.Id("submitEnviar")).Click();
            driver.FindElement(By.Id("Clave")).Clear();
            driver.FindElement(By.Id("Clave")).SendKeys("Abc123");
            driver.FindElement(By.Id("submitEnviar")).Click();
            driver.FindElement(By.LinkText("Operaciones")).Click();
            driver.FindElement(By.LinkText("Transferencias")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Transferencias'])[2]/following::button[1]")).Click();
            driver.FindElement(By.Id("ProductoOrigenSeleccionado")).Click();
            driver.FindElement(By.Id("ProductoOrigenSeleccionado")).Click();
            driver.FindElement(By.Id("ProductoDestinoSeleccionado")).Click();
            driver.FindElement(By.Id("ProductoDestinoSeleccionado")).Click();
            driver.FindElement(By.Id("MonedaSeleccionada")).Click();
            driver.FindElement(By.Id("MonedaSeleccionada")).Click();
            driver.FindElement(By.Id("Monto")).Click();
            driver.FindElement(By.Id("Monto")).Clear();
            driver.FindElement(By.Id("Monto")).SendKeys("10");
            driver.FindElement(By.Id("CodigoPromocion")).Click();
            driver.FindElement(By.Id("CodigoPromocion")).Clear();
            driver.FindElement(By.Id("CodigoPromocion")).SendKeys("abcd");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Los campos marcados con (*) son obligatorios.'])[1]/following::tbody[1]")).Click();
            driver.FindElement(By.Id("CodigoPromocion")).Click();
            driver.FindElement(By.Id("CodigoPromocion")).Clear();
            driver.FindElement(By.Id("CodigoPromocion")).SendKeys("");
            driver.FindElement(By.Id("Referencia")).Click();
            driver.FindElement(By.Id("Referencia")).Clear();
            driver.FindElement(By.Id("Referencia")).SendKeys("pago");
            driver.FindElement(By.Id("submitTransferir")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Transferencias BNB propias > A cuentas propias'])[1]/following::h1[1]")).Click();
            Assert.Pass();
        }
    }
}