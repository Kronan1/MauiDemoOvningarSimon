namespace MauiDemoOvningarSimon
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnBtnClicked(object sender, EventArgs e)
        {
            if (sender == Btn1)
            {
                await Navigation.PushAsync(new CatDog());
            }
            else if (sender == Btn2)
            {
                await Navigation.PushAsync(new Calculator());
            }
            else if (sender == Btn3)
            {
                await Navigation.PushAsync(new Clock());
            }


        }
    }

}
