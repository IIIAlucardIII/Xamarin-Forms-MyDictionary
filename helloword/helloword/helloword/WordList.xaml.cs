using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDictionary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WordList : ContentPage
    {
        private readonly IList<Item> _items = new List<Item>();        
        
        public WordList ()
		{
			InitializeComponent ();            
            Init();
            this.BindingContext = this;
        }

        public ObservableCollection<Item> Items { get; set; }
        public Command ClickCommand { get; set; } = new Command(async () =>
        {

            await new NavigationPage().PushAsync(new ListOfTags());
        });

        private void Init()
        {
            _items.Add(new Item
            {
                Word = "allow",
                Transcription = "[əˈlaʊ]",
                Translates = "дозволяти",
                Tag = "#other"

            });

            _items.Add(new Item
            {
                Word = "all",
                Transcription = "[ɔːl]",
                Translates = "все, всі",
                Tag = "#other"
            });

            _items.Add(new Item
            {
                Word = "air",
                Transcription = "[ɛː]",
                Translates = "повітря, провітрювати",
                Tag = "#new words"
            });

            _items.Add(new Item
            {
                Word = "bank",
                Transcription = "[baŋk]",
                Translates = "банк",
                Tag = "#building"
            });

            _items.Add(new Item
            {
                Word = "bar",
                Transcription = "[bɑː]",
                Translates = "бар, паб; брусок, стойка",
                Tag = "#building"
            });

            _items.Add(new Item
            {
                Word = "bear",
                Transcription = "[bɛː]",
                Translates = "ведмідь",
                Tag = "#animal"
            });

            _items.Add(new Item
            {
                Word = "beautiful",
                Transcription = "[ˈbjuːtɪfʊl]",
                Translates = "красивий",
                Tag = "#other"
            });

            _items.Add(new Item
            {
                Word = "bed",
                Transcription = "[bɛd]",
                Translates = "ліжко",
                Tag = "#furniture"
            });

            _items.Add(new Item
            {
                Word = "still",
                Transcription = "[ˈstɪl]",
                Translates = "тихий, спокійний",
                Tag = "#other"
            });

            _items.Add(new Item
            {
                Word = "map	",
                Transcription = "[ˈmæp]",
                Translates = "карта",
                Tag = "#things"
            });

            _items.Add(new Item
            {
                Word = "fat",
                Transcription = "[ˈfæt]",
                Translates = "товстий, жирний",
                Tag = "#other"
            });

            _items.Add(new Item
            {
                Word = "hot",
                Transcription = "[ˈhɑt]",
                Translates = "гарячий, жаркий",
                Tag = "#other"
            });

            _items.Add(new Item
            {
                Word = "run",
                Transcription = "[ˈrən]",
                Translates = "бігти",
                Tag = "#action"
            });

            _items.Add(new Item
            {
                Word = "a rat",
                Transcription = "[ə ˈræt]",
                Translates = "пацюк, щур",
                Tag = "#animal"
            });

            _items.Add(new Item
            {
                Word = "tram",
                Transcription = "[træm]",
                Translates = "трамвай",
                Tag = "#transport"
            });

            _items.Add(new Item
            {
                Word = "cup",
                Transcription = "[kəp]",
                Translates = "чашка",
                Tag = "#things"
            });

            _items.Add(new Item
            {
                Word = "bus",
                Transcription = "[bəs]",
                Translates = "автобус",
                Tag = "#transport"
            });

            _items.Add(new Item
            {
                Word = "a plum",
                Transcription = "[ə ˈpləm]",
                Translates = "слива",
                Tag = "#fruit"
            });

            _items.Add(new Item
            {
                Word = "help",
                Transcription = "[ˈhelp]",
                Translates = "допомагати",
                Tag = "#action"
            });

            Items = new ObservableCollection<Item>(_items);
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListOfTags());
        }
        private async void FloatingActionButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewWord());
        }

        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListViewIs.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                ListViewIs.ItemsSource = _items;
            else
                ListViewIs.ItemsSource = _items.Where(i => i.Word.StartsWith(e.NewTextValue, StringComparison.OrdinalIgnoreCase));

            ListViewIs.EndRefresh();
        }
    }
}