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
        #endregion
        #region Contructor
        public MainViewModel()
        {
            //hacer una instancia ya que se incia primero LoginView
            this.Login = new LoginViewModel();
        }
        #endregion


    }
}
