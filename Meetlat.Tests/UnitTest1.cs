
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPClassBasicsTesterLibrary;

namespace Meetlat.Tests
{
    [TestClass]
    public class UnitTest1
    {
        TimsEpicClassAnalyzer tester = new TimsEpicClassAnalyzer(new Meetlat());

        [TestMethod]
        public void BasisKlasseProps()
        {
            tester.CheckFullProperty("BeginLengte", typeof(double), propType: TimsEpicClassAnalyzer.PropertyTypes.NoGet);
            tester.CheckFullProperty("LengteInM", typeof(double), propType: TimsEpicClassAnalyzer.PropertyTypes.NoSet);
            tester.CheckFullProperty("LengteInCm", typeof(double), propType: TimsEpicClassAnalyzer.PropertyTypes.NoSet);
            tester.CheckFullProperty("LengteInKm", typeof(double), propType: TimsEpicClassAnalyzer.PropertyTypes.NoSet);
            tester.CheckFullProperty("LengteInVoet", typeof(double), propType: TimsEpicClassAnalyzer.PropertyTypes.NoSet);
        }
        [TestMethod]
        public void ReadOnlyPropTest()
        {
            const double TESTVALUE = 121.0;
            tester.SetProp("BeginLengte", TESTVALUE);
            Assert.AreEqual(TESTVALUE, tester.GetProp("LengteInM"));
            Assert.AreEqual(TESTVALUE*100, tester.GetProp("LengteInCm"));
            Assert.AreEqual(TESTVALUE/1000, tester.GetProp("LengteInKm"));
            Assert.AreEqual(TESTVALUE*3.2808, tester.GetProp("LengteInVoet"));
        }
    }
}
