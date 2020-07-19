using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransactCommon;
using TransactCommon.Enums;

namespace TransactCommonTest
{
    [TestClass]
    public class TransactionTest
    {
        [TestMethod]
        public void ShouldConstructProperlyWithoutParameters()
        {
            var transaction = new Transaction();

            Assert.AreEqual(0, transaction.Amount);
            Assert.AreEqual(DateTime.MinValue, transaction.Date);
            Assert.AreEqual(TransactionType.Expense, transaction.TransactionType);
        }

        [TestMethod]
        public void ShouldConstructProperlyWithParameters()
        {
            var transaction = new Transaction(56.45m, DateTime.MinValue);

            Assert.AreEqual(56.45m, transaction.Amount);
            Assert.AreEqual(DateTime.MinValue, transaction.Date);
            Assert.AreEqual(TransactionType.Income, transaction.TransactionType);
        }

        [TestMethod]
        public void ShouldReturnProperlyFormattedZeroAmount()
        {
            var transaction = new Transaction(0, DateTime.Now);

            Assert.AreEqual("$0.00", transaction.FormattedAmount);
        }

        [TestMethod]
        public void ShouldReturnProperlyFormattedNegativeAmount()
        {
            var transaction = new Transaction(-45.69m, DateTime.Now);

            Assert.AreEqual("($45.69)", transaction.FormattedAmount);
        }

        [TestMethod]
        public void ShouldReturnProperlyFormattedPositiveAmount()
        {
            var transaction = new Transaction(56.45m, DateTime.Now);

            Assert.AreEqual("$56.45", transaction.FormattedAmount);
        }

        [TestMethod]
        public void ShouldReturnProperlyFormattedDate()
        {
            var transaction = new Transaction(50m, DateTime.MinValue);

            Assert.AreEqual(DateTime.MinValue.ToShortDateString(), transaction.FormattedDate);
        }

        [TestMethod]
        public void ShouldSetTransactionTypeToIncome()
        {
            var transaction = new Transaction(50.0m, DateTime.Now);

            Assert.AreEqual(TransactionType.Income, transaction.TransactionType);
        }

        [TestMethod]
        public void ShouldSetTransactionTypeToExpense()
        {
            var transaction = new Transaction(-654.54m, DateTime.Now);

            Assert.AreEqual(TransactionType.Expense, transaction.TransactionType);
        }

        [TestMethod]
        public void ShouldNotChangeTransactionTypeIfTransfer()
        {
            var transaction = new Transaction(85.6m, DateTime.Now);
            transaction.TransactionType = TransactionType.Transfer;

            transaction.Amount = -56.547m;

            Assert.AreEqual(TransactionType.Transfer, transaction.TransactionType);
        }

        [TestMethod]
        public void ShouldSetTransactionTypeToExpenseIfAmountIsZero()
        {
            var transaction = new Transaction(0, DateTime.Now);

            Assert.AreEqual(TransactionType.Expense, transaction.TransactionType);
        }
    }
}