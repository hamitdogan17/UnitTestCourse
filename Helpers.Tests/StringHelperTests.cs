using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Helpers.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void Girilen_ifadenin_basındaki_ve_sonundaki_bosluklar_silinmelidir()
        {
            //Arrange
            var ifade = "  Hamit Dogan    ";
            var beklenen = "Hamit Dogan";

            //Act
            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);

            //Assert 
            Assert.AreEqual(beklenen, gerceklesen);
        }
        [TestMethod]
        public void Girilen_ifadenin_icindeki_fazla_bosluklar_varsa_silinmelidir()
        {
            //Arrange
            var ifade = "Hamit     Dogan";
            var beklenen = "Hamit Dogan";

            //Act
            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);

            //Assert 
            Assert.AreEqual(beklenen, gerceklesen);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckHasError()
        {
            StringHelper.ThrowExceptions();
        }
    }
}
