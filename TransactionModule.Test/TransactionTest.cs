using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TransactionModule.Test
{
    [TestClass]
    public class TransactionTest
    {
        [TestMethod]
        public void ShouldInitializeWithProperValues()
        {
            var transaction = new Transaction();
            Assert.AreEqual(0.00m, transaction.Amount);

            transaction = new Transaction(5.64m);
            Assert.AreEqual(5.64m, transaction.Amount);
        }

        [TestMethod]
        public void ShouldReturnProperlyFormattedAmount()
        {
            var transaction = new Transaction();
            Assert.AreEqual("$0.00", transaction.FormattedAmount);

            transaction = new Transaction(9.41m);
            Assert.AreEqual("$9.41", transaction.FormattedAmount);
        }
    }
}
