using Microsoft.VisualStudio.TestTools.UnitTesting;
using EscapeRoomRedi;

namespace EscapeRoomTestit
{
    [TestClass]
    public class OstoskärryTesti
    {
        [TestMethod]
        public void OstoskärryssäOnLista()
        {
            Ostoskärry o = new Ostoskärry();
            Assert.IsNotNull(o.Avaimet);
        }

        [TestMethod]
        public void AvaimenLisäysToimii()
        {
            Ostoskärry o = new Ostoskärry();
            o.LisääAvain('a');
            Assert.AreEqual(1, o.Avaimet.Count, "Avaimia on väärä määrä");
        }
    }
}
