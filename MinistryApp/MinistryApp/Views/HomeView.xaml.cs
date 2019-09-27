using MinistryApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinistryApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeView : ContentPage
	{
		public HomeView()
		{
			InitializeComponent();

            this.BindingContext = Bootstrapping.AppContainer.Resolve(typeof(ViewModels.HomeViewModel));

        }
	}
}