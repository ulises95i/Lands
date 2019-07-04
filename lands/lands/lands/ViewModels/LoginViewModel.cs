using GalaSoft.MvvmLight.Command;
using lands.Views;
using Lands.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace lands.ViewModels
{
    class LoginViewModel: BaseViewModel
    {
        //Refrecar los controles del BaseViewModel asignamos una propiedad privada

        #region Attributes
        private string email;
        private string password;
        private bool isRunning;
        private bool isRemmber;
        private bool isEnabled;


        #endregion
        //TwoWay :: Obtendra loq ue se escriba
        #region Propertis
        public string Email
        {
            get { return this.email; }
            set { SetValue(ref this.email,value); }
        }
        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }
        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }
        public bool IsRemmber
        {
            get { return this.isRemmber; }
            set { SetValue(ref this.isRemmber,value); }
        }
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled,value); }
        }
        #endregion

        #region Command
        public ICommand LoginCommand
        {
            get
            {
                //Se Controlan las acciones del usuario un tab, click 
                return new RelayCommand(Login);
            }
            
        }


        public async void Login()
        {
            //Valaidar al hacer click en Login que el usuario haya registrado algo en los campos 
            if(string.IsNullOrEmpty(this.Email))
            {//Metodos asycronos , para comvertir a asycrono ... se sigue y lo ataga has ta el await
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Ingresa tu Email",
                    "Aceptar"
                    );
                return;

            }
            
            if(string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Ingresar tu password",
                    "Aceptar"
                    );
                return;
            }
            this.IsRunning = false;
            this.isEnabled = true;
            if (this.Email!="irvin@hotmail.com" || this.Password!="12345")
            {
                this.IsRunning = true;
                this.isEnabled = false;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email o contraseña incorrecta",
                    "Accept"
                    );
                this.Password = string.Empty;
                return;
            }
            this.IsRunning = false;
            this.isEnabled = true;
            this.Email = string.Empty;
            this.Password = string.Empty;
            //Creacion del patron singleton:: asegurrarnos que solo se hara una instanicia de una clase
            // instanciar la viewmodel 
            MainViewModel.GetInstance().Lands = new LandsViewModel();
            //Implemetacion de navegacion
            await Application.Current.MainPage.Navigation.PushAsync(new LandsPage());

        }
        #endregion

        #region Constructor
        public LoginViewModel()
        {
            this.IsRemmber = true;
            this.IsEnabled = true;

            this.Email = "irvin@hotmail.com";
            this.Password = "12345";
        }
        #endregion
    }
}
