using CRUDWPFSqlite.Views;
using Microsoft.Practices.ServiceLocation;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CRUDWPFSqlite
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<MainWindow>(); // base.CreateShell();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            // add modules here.
        }
    }
}
