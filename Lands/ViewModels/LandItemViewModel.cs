using System;
namespace Lands.ViewModels
{
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Models;
    using Views;
    using Xamarin.Forms;

    public class LandItemViewModel : Land
    {
        #region
        public ICommand SelectLandCommand 
        {
            get
            {
                return new RelayCommand(SelectLand);
            }
        }

        private async void SelectLand()
        {
            MainViewModel.GetInstance().Land = new LandViewModel(this); //invocar MainViewModel pasandole el pais seleccionado desde el form anterior  
            await Application.Current.MainPage.Navigation.PushAsync(new LandTabbedPage());
        }
        #endregion

    }
}
