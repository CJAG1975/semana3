using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace tarea_dos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                //acciones del programa
                double num1 = Convert.ToDouble(txtDato1.Text);
                double num2 = Convert.ToDouble(txtDato2.Text);
                double num3 = Convert.ToDouble(txtDato3.Text);
                double num4 = Convert.ToDouble(txtDato4.Text);
                if (num1 > 0 && num1 < 11 && num2 > 0 && num2 < 11 && num3 > 0 && num3 < 11 && num4 > 0 && num4 < 11)
                {
                    double parcialUno = (num1 * 0.3) + num2 * 0.2;
                    txtResultado1.Text = parcialUno.ToString();
                    double parcialDos = (num3 * 0.3) + num4 * 0.2;
                    txtResultado2.Text = parcialDos.ToString();
                    double final = parcialUno + parcialDos;
                    if (final >= 7) 
                    { 
                        txtEstado.Text = "APROBADO";
                    }
                    else if (final < 7)
                    {
                        txtEstado.Text = "REPROBADO";
                    }
                    else if (final >=5 && final <= 6.9)
                    {
                        txtEstado.Text = "COMPLEMENTARIO";
                    }
                }
                else
                {
                    DisplayAlert("ALERTA", "las notas tienen que estar entre [0, 10]", "ACEPTAR"); 
                }

                    

            }
            catch (Exception ex)
            {
                //excepciones
                DisplayAlert("ALERTA", ex.Message, "ACEPTAR");
            }
        }
    }
}
