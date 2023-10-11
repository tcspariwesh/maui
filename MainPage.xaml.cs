namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string[] skills;
        User user = new User();
        public MainPage()
        {
            InitializeComponent();
            skills = new string[] { "Java", "React", "MAUI" };
            firstname.BindingContext = user.Name;
            // display.BindingContext = slider;
            //   display.SetBinding(Label.TextProperty, "Value");
        }
        private void handleCheckbox()
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            UserService userService = new UserService();    
            user.Name =firstname.Text;
            userService.save(user);
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