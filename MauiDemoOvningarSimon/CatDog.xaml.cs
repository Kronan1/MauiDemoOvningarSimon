namespace MauiDemoOvningarSimon;

public partial class CatDog : ContentPage
{
    int DogClicked = 0;
    int CatClicked = 0;
    public CatDog()
	{
		InitializeComponent();
	}

    private void OnBtnClicked(object sender, EventArgs e)
    {
        if (sender == Dog)
        {
            DogClicked++;
            if (!MyImage.Source.ToString().EndsWith("dog.png"))
            {
                MyImage.Source = "dog.png";
            }
            
        }
        else if (sender == Cat)
        {
            CatClicked++;
            if (!MyImage.Source.ToString().EndsWith("cat.png"))
            {
                MyImage.Source = "cat.png";
            }
            
        }

        ClickedText.Text = "Du har tryck p� katt " + CatClicked + " g�nger, och p� hund " + DogClicked + " g�nger";
    }

    private async void OnMainMenuClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}