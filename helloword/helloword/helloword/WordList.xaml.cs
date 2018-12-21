using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDictionary
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WordList : ContentPage
	{
        public ObservableCollection<Item> Items { get; set; }
        public Command ClickCommand { get; set; } = new Command(async () =>
       {
           
           await new NavigationPage().PushAsync(new ListOfTags());
       });
        
        public WordList ()
		{
			InitializeComponent ();
            
            List<Item> ListOfItems = new List<Item>();
            Items = new ObservableCollection<Item>();


            Items.Add(new Item
            {
                Word = "achive",
                Transcription = "[achive]"

            });

            Items.Add(new Item
            {
                Word = "apple",
                Transcription = "[epl]",
                Translates = "Яблуко Ябко",
                Tag = "#Нові слова"
            });

            Items.Add(new Item
            {
                Word = "apple",
                Transcription = "[epl]",
                Translates = "Яблуко Ябко",
                Tag = "#Нові слова"
            });

            Items.Add(new Item
            {
                Word = "apple",
                Transcription = "[epl]",
                Translates = "Яблуко Ябко",
                Tag = "#Нові слова"
            });

            Items.Add(new Item
            {
                Word = "apple",
                Transcription = "[epl]",
                Translates = "Яблуко Ябко",
                Tag = "#Нові слова"
            });

            Items.Add(new Item
            {
                Word = "apple",
                Transcription = "[epl]",
                Translates = "Яблуко Ябко",
                Tag = "#Нові слова"
            });

            Items.Add(new Item
            {
                Word = "apple",
                Transcription = "[epl]",
                Translates = "Яблуко Ябко",
                Tag = "#Нові слова"
            });

            Items.Add(new Item
            {
                Word = "apple",
                Transcription = "[epl]",
                Translates = "Яблуко Ябко",
                Tag = "#Нові слова"
            });

            Items.Add(new Item
            {
                Word = "apple",
                Transcription = "[epl]",
                Translates = "Яблуко Ябко",
                Tag = "#Нові слова"
            });

            Items.Add(new Item
            {
                Word = "apple",
                Transcription = "[epl]",
                Translates = "Яблуко Ябко",
                Tag = "#Нові слова"
            });

            Items.Add(new Item
            {
                Word = "apple",
                Transcription = "[epl]",
                Translates = "Яблуко Ябко",
                Tag = "#Нові слова"
            });

            Items.Add(new Item
            {
                Word = "apple",
                Transcription = "[epl]",
                Translates = "Яблуко Ябко",
                Tag = "#Нові слова"
            });

            Items.Add(new Item
            {
                Word = "apple",
                Transcription = "[epl]",
                Translates = "Яблуко Ябко",
                Tag = "#Нові слова"
            });


            this.BindingContext = this;
        }

        public void InsertPageBefore(Page page, Page before)
        {
            throw new NotImplementedException();
        }

        public Task<Page> PopAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Page> PopAsync(bool animated)
        {
            throw new NotImplementedException();
        }

        public Task<Page> PopModalAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Page> PopModalAsync(bool animated)
        {
            throw new NotImplementedException();
        }

        public Task PopToRootAsync()
        {
            throw new NotImplementedException();
        }

        public Task PopToRootAsync(bool animated)
        {
            throw new NotImplementedException();
        }

        public Task PushAsync(Page page)
        {
            throw new NotImplementedException();
        }

        public Task PushAsync(Page page, bool animated)
        {
            throw new NotImplementedException();
        }

        public Task PushModalAsync(Page page)
        {
            throw new NotImplementedException();
        }

        public Task PushModalAsync(Page page, bool animated)
        {
            throw new NotImplementedException();
        }

        public void RemovePage(Page page)
        {
            throw new NotImplementedException();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListOfTags());
        }
    }
}