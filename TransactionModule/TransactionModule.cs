using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace TransactionModule
{
    public class TransactionModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            // Register views with regions and such here.
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}