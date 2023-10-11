namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        UserService userService;
        int count = 0;
        string[] skills;
        User user = new User();
        public MainPage()
        {
            InitializeComponent();
            userService = new UserService();
            skills = new string[] { "Java", "React", "MAUI" };
            firstname.BindingContext = user.Name;
           // gender.BindingContext = user.Gender;
            // display.BindingContext = slider;
            //   display.SetBinding(Label.TextProperty, "Value");
        }
        private void handleCheckbox()
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
             
            user.Name =firstname.Text;
            user.Gender = gender.IsChecked ? "Male" : "Female";
            userService.save(user);
        }

        private void deleteUser(object sender, EventArgs e)
        {
            userService.deleteUser();
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