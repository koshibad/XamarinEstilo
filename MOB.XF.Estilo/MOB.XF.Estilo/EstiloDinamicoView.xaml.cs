using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB.XF.Estilo
{
    public partial class EstiloDinamicoView : ContentPage
    {
        bool temaPadrao;

        public EstiloDinamicoView()
        {
            InitializeComponent();

            temaPadrao = true;
            Resources["TextoEstiloDinamico"] = Resources["TextoAzul"];
        }

        public void OnClick_AlterarEstilo(object sender, EventArgs args)
        {
            if (temaPadrao)
            {
                Resources["TextoEstiloDinamico"] = Resources["TextoBranco"];
                temaPadrao = false;
            }
            else
            {
                Resources["TextoEstiloDinamico"] = Resources["TextoAzul"];
                temaPadrao = false;
            }
        }

        #region Relogio

        private bool desligarRelogio = false;

        protected override void OnAppearing()
        {
            desligarRelogio = false;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                Resources["Hora"] = DateTime.Now.ToString();
                return !desligarRelogio;
            });

            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            desligarRelogio = true;
            base.OnDisappearing();
        }

        #endregion
    }
}
