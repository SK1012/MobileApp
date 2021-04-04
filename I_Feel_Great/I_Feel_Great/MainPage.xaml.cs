using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace I_Feel_Great
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ((Button)sender).Text = $"You are woman with 100% probability";
        }


        double NoMale = 65;
        double NoFemale = 0.5 * 35;
        private void Button_Clicked2(object sender, EventArgs e)
        {

            double sum = (NoMale + NoFemale);
            double probNoMale = Convert.ToInt32((NoMale/sum)*100);
            double probNoFemale = (NoFemale / sum)*100;
            ((Button)sender).Text = $"You are a man with {probNoMale}% probability";
        }
    }
}
