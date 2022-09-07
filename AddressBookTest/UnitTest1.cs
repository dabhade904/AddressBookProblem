using AddressBookDb;

namespace AddressBookTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FetchAddressBookDb da = new FetchAddressBookDb();
            string actualString = da.;
            string expectedString = System.Configuration.ConfigurationManager.ConnectionStrings[“AddressBook”].ConnectionString;
            Assert.AreEqual(expectedString, actualString);
        }
    }
}