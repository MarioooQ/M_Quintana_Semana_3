using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {

            DatosDeUsuario var_datosDeUsuario = new DatosDeUsuario();

            String user = txtUser.Text;
            String pass = txtPassword.Text;

            if (user == var_datosDeUsuario.usuario && pass == var_datosDeUsuario.contrasena)
            {
                await Navigation.PushAsync(new CalculadoraNotas());
            }
            else
            {
                await DisplayAlert("Error", "Usuario o contraseña incorrecto", "OK");
            }
        }
    }
}
