using System;
using System.Collections.Generic;
using System.Text;
using template__.Domain;
using template__.Services.Temp;
using Xamarin.Forms;

namespace template__.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        #region Properties
        public ISomeService _someService => DependencyService.Get<ISomeService>();
        #endregion

        public HomeViewModel()
        {
            Title = "Home Page";
            _someService.SomeMethod();
        }
    }
}
