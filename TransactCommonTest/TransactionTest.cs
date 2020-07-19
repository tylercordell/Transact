using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TransactCommon.Test
{
    [TestClass]
    public class TransactionTest
    {
        [TestMethod]
        public void ShouldInitializeWithProperValues()
        {
            var transaction = new Transaction();

            Assert.AreEqual(0.00m, transaction.Amount);
            Assert.AreEqual(DateTime.MinValue, transaction.Date);

            var testDate = DateTime.Now;
            transaction = new Transaction(5.64m, testDate);
            Assert.AreEqual(5.64m, transaction.Amount);
            Assert.AreEqual(testDate, transaction.Date);
        }

        [TestMethod]
        public void ShouldReturnProperlyFormattedProperties()
        {
            var transaction = new Transaction();
            Assert.AreEqual("$0.00", transaction.FormattedAmount);
            Assert.AreEqual(DateTime.MinValue.ToShortDateString(), transaction.FormattedDate);

            var testDate = DateTime.Now;
            transaction = new Transaction(9.41m, testDate);
            Assert.AreEqual("$9.41", transaction.FormattedAmount);
            Assert.AreEqual(testDate.ToShortDateString(), transaction.FormattedDate);
        }
    }
}
