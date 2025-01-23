
namespace App
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count <= 9)
                CounterBtn.Text = $"has hecho  {count} golpes";
            else
            {
                MonsterImage.Source = "tumba.jpg";
                CounterBtn.Text = $"amenazada eliminada";
            }

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}