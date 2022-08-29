using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP01_Xamarim.Forms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (id.Text == "admin" && password.Text == "senha@dmin")
                {
                    DisplayAlert("Sucesso", "Login Com Sucesso", "OK");
                }
                else
                {
                    DisplayAlert("Tente novamente", "Login não autorizado", "OK");
                }
            }
            catch
            {
                DisplayAlert("Erro!", "Erro não indentificado", "OK");
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            //Limpar Entrys
            id.Text = "";
            password.Text = "";
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            //Creditos
            DisplayAlert("Créditos", "Danilo Gabriel - cb3011798", "OK");
        }
    }
}

