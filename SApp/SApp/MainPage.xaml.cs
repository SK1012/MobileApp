//Author: Sergiu Caciula
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using StringLibrary;

namespace SApp
{
    public partial class MainPage : ContentPage
    {
        //Initializing strings for user input values.

        string val1;
        string val2;
        string val3;

        public MainPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Check if values are empty.

            if (String.IsNullOrEmpty(val1) || String.IsNullOrEmpty(val2) || String.IsNullOrEmpty(val3))
            {
                DisplayAlert("Empty values", "Please enter values for all fields", "Ok");
            }
            else
            {
                float PercentageMen = float.Parse(val1);
                float PercentageWomen = 100 - PercentageMen;
                float PercentageMenNo = float.Parse(val2);
                float PercentageWomenNo = float.Parse(val3);

                //Check if values are negative or above 100%. 

                if (PercentageMen < 0 || PercentageMenNo < 0 || PercentageWomenNo < 0)
                {
                    DisplayAlert("Negative value", "Please enter only positive values", "Ok");
                }
                else if (PercentageMen > 100 || PercentageMenNo > 100 || PercentageWomenNo > 100)
                {
                    DisplayAlert("Values too big", "Please enter values below 100%", "Ok");
                }
                else
                {
                    Class1 obj = new Class1();
                    float temp = obj.Compute(PercentageMen, PercentageMenNo, PercentageWomen, PercentageWomenNo);
                    string temp2 = temp.ToString("n2");
                    DisplayAlert("Probability that this user is male:", temp2 + "%", "Ok");
                }
            }
        }       

        void OnEntryCompleted(object sender,EventArgs e)
        {
            val1 = ((Entry)sender).Text;
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            val1 = e.NewTextValue;
        }

        void OnEntryCompleted2(object sender, EventArgs e)
        {
            val2 = ((Entry)sender).Text;
        }

        void OnEntryTextChanged2(object sender, TextChangedEventArgs e)
        {
            val2 = e.NewTextValue;
        }

        void OnEntryCompleted3(object sender, EventArgs e)
        {
            val3 = ((Entry)sender).Text;
        }

        void OnEntryTextChanged3(object sender, TextChangedEventArgs e)
        {
            val3 = e.NewTextValue;
        }

    }
}
