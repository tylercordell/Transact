using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using TransactionModule.Views;

namespace TransactionModule
{
    public class TransactionModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ApplicationTransactionLogRegion", typeof(TransactionLogView));
            // Register views with regions and such here.
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}