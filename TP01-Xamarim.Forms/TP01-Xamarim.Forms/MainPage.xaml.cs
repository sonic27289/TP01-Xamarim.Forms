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
                if (login.Text == "sonic" && password.Text == "sonic27289")
                {
                    DisplayAlert("Login efetuado", "Concedido acesso ao sistema", "OK");
                }
                else
                {
                    DisplayAlert("Login mal efetuado", "Tente novamente", "OK");
                }
            }
            catch
            {
                DisplayAlert("Erro !", "Tente novamente", "OK");
            }
        }

        private void Button_Clicked_Limpar(object sender, EventArgs e)
        {
            login.Text = "";
            password.Text = "";
        }

        private void Button_Clicked_Creditos(object sender, EventArgs e)
        {
            DisplayAlert("Créditos", "Gustavo Barbosa - CB3010627", "OK");
        }
    }
}

