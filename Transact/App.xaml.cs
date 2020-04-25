using System.Windows;
using CommonServiceLocator;
using Prism.Ioc;
using Prism.Unity;

namespace Transact
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        protected override Window CreateShell()
        {
            return ServiceLocator.Current.GetInstance<MainWindow>();
        }
    }
}