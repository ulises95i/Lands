using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace lands.ViewModels
{
    class LoginViewModel
    {
        //TwoWay :: Obtendra loq ue se escriba
        #region Propertis
        public string Email
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public bool Isrunnung
        {
            get;
            set;
        }
        public bool IsRemmber
        {
            get;
            set;
        }
        #endregion
        #region Command
        public ICommand LoginCommand
        {
            get;
            set;
        }
        #endregion
        #region Constructor
        public LoginViewModel()
        {
            this.IsRemmber = true;
        }
        #endregion
    }
}
