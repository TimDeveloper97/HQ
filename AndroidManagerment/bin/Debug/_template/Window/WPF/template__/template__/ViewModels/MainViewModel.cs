using Ninject;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using template__.Models;
using template__.Services;

namespace template__.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        #region private properties
        private string helloWord;
        private object current;
        private IDataStore<ClassA> _dataService;
        #endregion

        #region public properties
        public ICommand WindowCommand { get; set; }
        public static ObservableCollection<object> List { get; set; }
        public string HelloWord { get => helloWord; set => SetProperty(ref helloWord, value); }
        public object Current { get => current; set => SetProperty(ref current, value); }
        #endregion

        [Inject]
        public MainViewModel(UserViewModel userVM, SettingViewModel settingVM, IDataStore<ClassA> dataService)
        {
            InitProperties();
            InitCommand();
            Current = settingVM;
            //var x = _dataService;
            //_dataService = dataService;
        }

        /// <summary>
        /// khởi tạo giá trị cho các biến
        /// </summary>
        void InitProperties()
        {
            HelloWord = _helloWorld;
        }

        /// <summary>
        /// khởi tạo giá trị cho các sự kiện button
        /// </summary>
        void InitCommand()
        {
            WindowCommand = new RelayCommand<object>(p => { return true; }, p =>
            {
                
            });
        }
    }
}
