using Examen_Mvvm.ViewModels;

namespace Examen_Mvvm.Views;

public partial class ProductoView : ContentPage
{
	public ProductoView()
	{
		InitializeComponent();
		BindingContext=new ProductoViewModel();
	}
}