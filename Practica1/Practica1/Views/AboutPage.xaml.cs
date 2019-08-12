using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica1.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        void OpenBotton(object obj, EventArgs clicked)
        {
            string nombre = entNombre.Text;

            if (string.IsNullOrEmpty(entNombre.Text) || string.IsNullOrEmpty(entPassword.Text))
            {
                DisplayAlert("Campo vacio!", " El campo de nombre y/o contraseña estan vacios ", "OK");
               
            }
            else
            {
                DisplayAlert("Bienvenido", "Hola, te damos la bienvenida " + nombre + "!", "OK");
            }
        }
    }
}