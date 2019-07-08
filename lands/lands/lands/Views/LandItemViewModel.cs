namespace lands.Views
{
    using Models;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Xamarin.Forms;
    using lands.ViewModels;

    public class LandItemViewModel : RootObject //HErada del modelo para obtener sus atributos para poder asignarle el comendo de GestureRecognizers
    {
        //Cracion del Observable collections
        #region Commands
        public ICommand SelectLandCommand
        {
            get
            {
                return new RelayCommand(SelectLand);
            }
        } 

        private async void SelectLand()
        {
            //Invocar el MainViewModel... el metodo singleton para poder tener acceso a la LadPage
            MainViewModel.GetInstance().Land = new LandViewModel(this); ///Pasar un objeto a la vista LandViewModel this.. objeto de la clase(LandItemViewModel)
            await Application.Current.MainPage.Navigation.PushAsync(new LandPage());
        }
        #endregion
    }
}
