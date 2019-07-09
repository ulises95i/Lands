namespace lands.ViewModels
{
    using lands.Models;
    using Lands.ViewModels;
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;

    public class LandViewModel: BaseViewModel
    {
        #region Attrubutes
        /*Para mostrar una lista en esta Page necesiamos u observable collection*/
        private ObservableCollection<Borders> bordes;
        //Propiedad para Currensies
        private ObservableCollection<Currency> currencies;
        //Lenguaje
        private ObservableCollection<Language> languages;

        #endregion
        #region Properties
        public RootObject Land
        {
            get;
            set;
        }
        public ObservableCollection<Borders>  Bordes
        {
            get { return this.bordes; }
            set { SetValue(ref this.bordes, value); }
        }
        public ObservableCollection<Currency> Currencies
        {
            get { return this.currencies; }
            set { SetValue(ref this.currencies, value); }
        }
        //Properti Languaje
        public ObservableCollection<Language> Languages
        {
            get { return this.languages; }
            set { SetValue(ref this.languages, value); }
        }
        #endregion
        //Le estamos obeteniendo el objeto recibido Land
        #region Constructor
        public LandViewModel(RootObject land)
        {
            this.Land = land; ///Lista completa del Json
            this.LoadBordes();//Obtener la lista de Bordes
            this.Currencies = new ObservableCollection<Currency>(this.Land.Currencies);///conversion de la lista en un observable conexcion
            this.Languages = new ObservableCollection<Language>(this.Land.Languages);
        }
        #endregion
        #region Methods
        private void LoadBordes()
        {
            //Creacion de la lista borders
            //Instancia de una lista vacia 
            this.Bordes = new ObservableCollection<Borders>();
            //Barrer la lista
            foreach (var bordes in this.Land.Borders)
            {
                var listaBordes = MainViewModel.GetInstance().landsList.
                                                Where(l => l.Alpha3Code == bordes).
                                                FirstOrDefault();
                //condicional
                if (listaBordes !=null)
                {
                    this.Bordes.Add(new Borders
                    {
                        Code =listaBordes.Alpha3Code,
                        Name =listaBordes.Name
                    });
                }
            }
            
        }
        #endregion


    }
}
