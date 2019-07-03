using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lands.Views
{
    //Copy+Hide
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        /*
         * una loginPage tiene una relacion Con una LoginViewModel y debe estar bindiada a ub objeto register
         */
		public LoginPage ()
		{
			InitializeComponent ();
		}
	}
}