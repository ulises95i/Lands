
namespace lands.Infrastructure
{
    using ViewModels;
    class InstanceLocator
    {
        #region Propertis
        public MainViewModel Main
        {
            get;
            set;
        }


        #endregion
        #region Constructor
        //Ligar La pagina deLogin con La view model
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
