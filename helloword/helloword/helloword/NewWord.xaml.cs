﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDictionary
{                    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewWord : ContentPage
    {
        public NewWord()
        {
            InitializeComponent();
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewWord());
        }
       
    }

}