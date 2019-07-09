namespace lands.ViewModels
{
    using lands.Models;
    using Lands.ViewModels;
    using System;
    using System.Collections.ObjectModel;
    public class LandViewModel: BaseViewModel
    {
        #region Attrubutes
        private ObservableCollection<Borders> bordes;
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
        #endregion
        //Le estamos obeteniendo el objeto recibido Land
        #region Constructor
        public LandViewModel(RootObject land)
        {
            this.Land = land; ///Lista completa del Json
            this.LoadBordes();//Obtener la lista de Bordes
        }
        #endregion
        #region Methods
        private void LoadBordes()
        {
            
        }
        #endregion


    }
}
