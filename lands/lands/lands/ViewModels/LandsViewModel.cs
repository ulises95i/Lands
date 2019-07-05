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
        private ApiServices apiservices; //Instanciar el registro para utilizar los servicios.. lo instanciamos en el contructor
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
            this.apiservices = new ApiServices();
            this.LoadLands();
        }
        #endregion
        #region
        public async void LoadLands()
        {
            //Cargamos las tierras ---esperate ahi (aweit)
            var response = await this.apiservices.GetList<RootObject>(
                "http://restcountries.eu",
                "/rest",
                "/v2/all");
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Aceptar");
                return;
            }
            //castear el object response a la lista de tipo RootObject
            var list = (List < RootObject >) response.Result;
            this.Lands = new ObservableCollection<RootObject>(list);
        }
        #endregion
    }
}
