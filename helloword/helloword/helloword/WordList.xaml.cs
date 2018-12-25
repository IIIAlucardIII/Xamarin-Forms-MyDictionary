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
                Word = "allow",
                Transcription = "[əˈlaʊ]",
                Translates = "дозволяти",
                Tag = "#other"

            });

            Items.Add(new Item
            {
                Word = "all",
                Transcription = "[ɔːl]",
                Translates = "все, всі",
                Tag = "#other"
            });

            Items.Add(new Item
            {
                Word = "air",
                Transcription = "[ɛː]",
                Translates = "повітря, провітрювати",
                Tag = "#new words"
            });

            Items.Add(new Item
            {
                Word = "bank",
                Transcription = "[baŋk]",
                Translates = "банк",
                Tag = "#building"
            });

            Items.Add(new Item
            {
                Word = "bar",
                Transcription = "[bɑː]",
                Translates = "бар, паб; брусок, стойка",
                Tag = "#building"
            });

            Items.Add(new Item
            {
                Word = "bear",
                Transcription = "[bɛː]",
                Translates = "ведмідь",
                Tag = "#animal"
            });

            Items.Add(new Item
            {
                Word = "beautiful",
                Transcription = "[ˈbjuːtɪfʊl]",
                Translates = "красивий",
                Tag = "#other"
            });

            Items.Add(new Item
            {
                Word = "bed",
                Transcription = "[bɛd]",
                Translates = "ліжко",
                Tag = "#furniture"
            });

            Items.Add(new Item
            {
                Word = "still",
                Transcription = "[ˈstɪl]",
                Translates = "тихий, спокійний",
                Tag = "#other"
            });

            Items.Add(new Item
            {
                Word = "map	",
                Transcription = "[ˈmæp]",
                Translates = "карта",
                Tag = "#things"
            });

            Items.Add(new Item
            {
                Word = "fat",
                Transcription = "[ˈfæt]",
                Translates = "товстий, жирний",
                Tag = "#other"
            });

            Items.Add(new Item
            {
                Word = "hot",
                Transcription = "[ˈhɑt]",
                Translates = "гарячий, жаркий",
                Tag = "#other"
            });

            Items.Add(new Item
            {
                Word = "run",
                Transcription = "[ˈrən]",
                Translates = "бігти",
                Tag = "#action"
            });

            Items.Add(new Item
            {
                Word = "a rat",
                Transcription = "[ə ˈræt]",
                Translates = "пацюк, щур",
                Tag = "#animal"
            });

            Items.Add(new Item
            {
                Word = "tram",
                Transcription = "[træm]",
                Translates = "трамвай",
                Tag = "#transport"
            });

            Items.Add(new Item
            {
                Word = "cup",
                Transcription = "[kəp]",
                Translates = "чашка",
                Tag = "#things"
            });

            Items.Add(new Item
            {
                Word = "bus",
                Transcription = "[bəs]",
                Translates = "автобус",
                Tag = "#transport"
            });

            Items.Add(new Item
            {
                Word = "a plum",
                Transcription = "[ə ˈpləm]",
                Translates = "слива",
                Tag = "#fruit"
            });

            Items.Add(new Item
            {
                Word = "help",
                Transcription = "[ˈhelp]",
                Translates = "допомагати",
                Tag = "#action"
            });



            this.BindingContext = this;
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListOfTags());
        }
        private async void FloatingActionButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewWord());
        }

    }
}