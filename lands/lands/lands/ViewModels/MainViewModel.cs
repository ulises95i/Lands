using System;
using System.Collections.Generic;
using System.Text;

namespace lands.ViewModels
{
    class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login
        {
            get;set;
        }
        public LandsViewModel Lands
        {
            get; set;
        }
        #endregion

        #region Contructor

        public MainViewModel()
        {
            //hacer una instancia ya que se incia primero LoginView
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Patron Songleton
        private static MainViewModel isntance;
        public static MainViewModel GetInstance()
        {//Permite hacer un llamado de la view model desde cualquier clase
            if (isntance == null)
            {
                return new MainViewModel();
            }
            return isntance;
        }
        #endregion

    }
}
