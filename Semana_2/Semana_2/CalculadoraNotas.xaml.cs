using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculadoraNotas : ContentPage
    {
        DatosDeUsuario var_datosDeUsuario = new DatosDeUsuario();

        public CalculadoraNotas()
        {
            InitializeComponent();
            
            lblUsuario.Text = "Estudiante: "+var_datosDeUsuario.usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double seguimiento1 = Convert.ToDouble(entSeguimiento1.Text) * 0.3;
                double evaluacion1 = Convert.ToDouble(entEvaluacion1.Text) * 0.2;
                double seguimiento2 = Convert.ToDouble(entSeguimiento2.Text) * 0.3;
                double evaluacion2 = Convert.ToDouble(entEvaluacion2.Text) * 0.2;
                double parcial1 = seguimiento1 + evaluacion1;
                double parcial2 = seguimiento2 + evaluacion2;
                String estado = "";

                if ((parcial1 + parcial2) >= 7)
                {
                    estado = "Aprobado";
                }
                else if ((parcial1 + parcial2) < 5)
                {
                    estado = "Reprobado";
                }
                else
                {
                    estado = "Suplementario";
                }
                DisplayAlert("Nota final: " + (parcial1 + parcial2).ToString(),
                "Estado: " + estado, "Cerrar");
            }
            catch (Exception ex)
            {

            }
        }
    }
}