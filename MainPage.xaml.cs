namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
           // display.BindingContext = slider;
         //   display.SetBinding(Label.TextProperty, "Value");
        }
        private void handleCheckbox()
        {

        }

       /* private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time {e}";
            else
                CounterBtn.Text = $"Clicked {count} times {e}";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }*/
    }
}