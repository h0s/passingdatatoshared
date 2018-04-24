using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myapp;
using Xamarin.Forms;

namespace myapp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		    LabelMainPage.Text = DependencyService.Get<IGetSmth>().smth;
        }
	}
}
