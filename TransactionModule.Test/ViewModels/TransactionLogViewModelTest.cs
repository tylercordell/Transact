using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransactCommon;
using TransactionModule.ViewModels;

namespace TransactionModule.Test.ViewModels
{
    /// <summary>
    /// Summary description for TransactionLogViewModelTest
    /// </summary>
    [TestClass]
    public class TransactionLogViewModelTest
    {
        [TestMethod]
        public void ShouldInitializeWithNonEmptyTransactionsCollection()
        {
            var vm = new TransactionLogViewModel();

            Assert.IsNotNull(vm.TransactionsCollection);

            CollectionAssert.AllItemsAreInstancesOfType(vm.TransactionsCollection, typeof(Transaction));
            CollectionAssert.AllItemsAreNotNull(vm.TransactionsCollection);
            CollectionAssert.AllItemsAreUnique(vm.TransactionsCollection);
        }
    }
}
