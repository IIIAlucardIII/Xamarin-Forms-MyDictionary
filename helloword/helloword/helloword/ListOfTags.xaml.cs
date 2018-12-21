using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                TagName = "Other",
                WordCount = "Word count",
                Count = 2
            });

            Tags.Add(new Tag
            {
                TagName = "Other",
                WordCount = "Word count",
                Count = 2
            });

            Tags.Add(new Tag
            {
                TagName = "Other",
                WordCount = "Word count",
                Count = 2
            });

            this.BindingContext = this;
        }
    }
}