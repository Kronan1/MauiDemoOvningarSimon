namespace MauiDemoOvningarSimon;

public partial class Calculator : ContentPage
{
	public Calculator()
	{
		InitializeComponent();
	}

    private void OnBtnClicked(object sender, EventArgs e)
    {
		if (int.TryParse(Input1.Text, out int input1) && int.TryParse(Input2.Text, out int input2))
		{
            Button clickedButton = (Button)sender;
            double sum = 0;

            switch (clickedButton.StyleId)
            { 
                case "Addition":
                    sum = input1 + input2;
                    break;
                case "Subtraction":
                    sum = input1 - input2;
                    break;
                case "Multiplication":
                    sum = input1 * input2;
                    break;
                case "Division":
                    sum = input1 / input2;
                    break;
            }

            Output.Text = Input1.Text + " " + clickedButton.Text + " " + Input2.Text + " = " + sum;
        }
        else
        {
            Output.Text = "Error";
        }
		
	}

    private async void OnMainMenuClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}