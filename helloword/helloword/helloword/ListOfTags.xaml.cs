using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDictionary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListOfTags : ContentPage
    {
        public ObservableCollection<Tag> Tags { get; set; }
        public Command ClickCommand { get; set; } = new Command(async () =>
        {
            await new NavigationPage().PushAsync(new ListOfTags());
        });

        public ListOfTags()
        {
            InitializeComponent();

            List<Tag> ListOfItems = new List<Tag>();
            Tags = new ObservableCollection<Tag>();

            Tags.Add(new Tag
            {
                TagName = "other",
                WordCount = "Word count",
                Count = 2
            });

            Tags.Add(new Tag
            {
                TagName = "building",
                WordCount = "Word count",
                Count = 2
            });

            Tags.Add(new Tag
            {
                TagName = "fruit",
                WordCount = "Word count",
                Count = 2
            });

            Tags.Add(new Tag
            {
                TagName = "action",
                WordCount = "Word count",
                Count = 2
            });

            Tags.Add(new Tag
            {
                TagName = "transport",
                WordCount = "Word count",
                Count = 2
            });

            Tags.Add(new Tag
            {
                TagName = "animal",
                WordCount = "Word count",
                Count = 2
            });

            Tags.Add(new Tag
            {
                TagName = "things",
                WordCount = "Word count",
                Count = 2
            });

            Tags.Add(new Tag
            {
                TagName = "furniture",
                WordCount = "Word count",
                Count = 2
            });

            Tags.Add(new Tag
            {
                TagName = "new words",
                WordCount = "Word count",
                Count = 2
            });

            this.BindingContext = this;
        }
    }
}