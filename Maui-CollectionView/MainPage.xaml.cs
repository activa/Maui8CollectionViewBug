namespace Maui_CollectionView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            listview.ItemsSource = Enumerable.Range(0,200000).Select(i => i.ToString()).ToList();
        }
    }

}
