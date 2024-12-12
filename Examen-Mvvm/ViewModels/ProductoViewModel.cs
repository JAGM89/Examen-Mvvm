using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace Examen_Mvvm.ViewModels
{
    public partial class ProductoViewModel : ObservableObject
    {
        [ObservableProperty]
        private double producto1;
        [ObservableProperty]
        private double producto2;
        [ObservableProperty]
        private double producto3;
        [ObservableProperty]
        private double subtotal;
        [ObservableProperty]
        private double descuento;
        [ObservableProperty]
        private double total;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]

        private void Calcular()
        {
            try
            {
                Subtotal = Producto1 + Producto2 + Producto3;
                Descuento = 0;

                if (Subtotal >= 10000)
                {
                    Descuento = Subtotal * 0.30;
                }
                else if (Subtotal >= 5000)
                {
                    Descuento = Subtotal * 0.20;
                }
                else if (Subtotal >= 1000)
                {
                    Descuento = Subtotal * 0.10;
                }
                Total = Subtotal - Descuento;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

            [RelayCommand]
        private void Limpiar()
        {
            Producto1 = 0;
            Producto2 = 0; 
            Producto3 = 0; 
            Subtotal = 0; 
            Descuento = 0; 
            Total = 0;
        }
    }
}
