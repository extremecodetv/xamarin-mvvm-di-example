using CrossPlatformApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CrossPlatformApp.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {

        private IClickModel clickModel;

        public ICommand ClickCommand { get; private set; }
        
        public string ClicksCount
        {
            get
            {
                return clickModel.Clicks.ToString();
            }
        }

        public MainPageViewModel(IClickModel clickModel)
        {
            ClickCommand = new Command(OnButtonClick);
            this.clickModel = clickModel;
        }

        private void OnButtonClick()
        {
            clickModel.OnClick();
            NotyfyPropertyChanged(nameof(ClicksCount));
        }


    }
}
