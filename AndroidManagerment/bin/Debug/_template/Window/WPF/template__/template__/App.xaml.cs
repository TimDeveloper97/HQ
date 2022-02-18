using Ninject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using template__.Models;
using template__.Services;
using template__.ViewModels;

namespace template__
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void App_Startup(object sender, StartupEventArgs e)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IDataStore<ClassA>>().To<DataStore<ClassA>>();

            var appVM = kernel.Get<MainViewModel>();

            MainWindow = new MainWindow
            {
                DataContext = appVM
            };
            MainWindow.Show();
        }

        public static void SelectCulture(string culture)
        {
            if (culture == null)
                return;

            //Copy all MergedDictionarys into a auxiliar list.
            var dictionaryList = Application.Current.Resources.MergedDictionaries.ToList();

            //Search for the specified culture.     
            string requestedCulture = string.Format("StringResource.{0}.xaml", culture);
            var resourceDictionary = dictionaryList.
                FirstOrDefault(d => Path.GetFileName(d.Source.OriginalString) == requestedCulture);

            if (resourceDictionary == null)
            {
                //If not found, select our default language.             
                requestedCulture = "StringResource.xaml";
                resourceDictionary = dictionaryList.
                    FirstOrDefault(d => Path.GetFileName(d.Source.OriginalString) == requestedCulture);
            }

            //If we have the requested resource, remove it from the list and place at the end.     
            //Then this language will be our string table to use.      
            if (resourceDictionary != null)
            {
                Application.Current.Resources.MergedDictionaries.Remove(resourceDictionary);
                Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
            }

            //Inform the threads of the new culture.     
            Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
        }
    }
}
