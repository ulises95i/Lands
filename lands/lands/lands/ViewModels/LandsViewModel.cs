namespace lands.ViewModels
{
    using lands.Services;
    using Lands.ViewModels;
    using Models;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;

    class LandsViewModel :BaseViewModel
    {
        #region Services 
        private ApiServices apiService; //Instanciar el registro para utilizar los servicios.. lo instanciamos en el contructor
        #endregion
        #region attributes
        //ObservableCollectionara pintarlo en una list
        private ObservableCollection<RootObject> lands;
        #endregion

        #region Properties
        public ObservableCollection<RootObject> Lands
        {
            get { return this.lands; }
            set { SetValue(ref this.lands, value); }
        }

        #endregion 

        #region Contructor
        public LandsViewModel()
        {
            this.apiService = new ApiServices();
            this.LoadLands();
        }
        #endregion
        #region
        public async void LoadLands()
        {
            var connection = await this.apiService.CheckConnection();

            if (!connection.IsSuccess)
            {
                //this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    connection.Message,
                    "Accept");
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }
            //Cargamos las tierras ---esperate ahi (aweit)
            var response = await this.apiService.GetList<RootObject>(
                "http://restcountries.eu",
                "/rest",
                "/v2/all");
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Aceptar");
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }
            //castear el object response a la lista de tipo RootObject
            var list = (List < RootObject >) response.Result;
            this.Lands = new ObservableCollection<RootObject>(list);
        }
        #endregion
    }
}
