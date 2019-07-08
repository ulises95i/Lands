using lands.Models;

namespace lands.ViewModels
{
    public class LandViewModel
    {
        #region Properties
        public RootObject Land
        {
            get;
            set;
        }
        #endregion
        //Le estamos obeteniendo el objeto recibido Land
        public LandViewModel(RootObject land)
        {
            this.Land = land;
        }

    }
}
