using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Operacionesde2Numeros
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(Object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Dato1.Text) && !String.IsNullOrEmpty(Dato2.Text))
            {
                Button button = (Button)sender; 
                var dato1 = double.Parse(Dato1.Text);
                var dato2 = double.Parse(Dato2.Text);

                var resultado = 0.0d;
                switch (button.Text)
                {
                    case "Suma":
                        resultado = dato1 + dato2;
                        break;
                    case "Resta":
                        resultado = dato1 - dato2;
                        break;
                    case "Multiplicacion":
                        resultado = dato1 * dato2;
                        break;
                    case "Division":
                        resultado = dato1 / dato2;
                        break;
                }

                Resultado.Text = resultado.ToString();
                string mensaje = "";

                if (resultado > 0)
                    mensaje = "Numero Positivo";
                else
                    mensaje = "Numero Negativo";
                DisplayAlert("El resultado es un", mensaje, "OK");
            }
            else
                DisplayAlert("Error", "No se han introducido los datos", "OK");
        }
    }
}
