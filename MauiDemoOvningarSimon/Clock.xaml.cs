using System.Diagnostics;

namespace MauiDemoOvningarSimon;

public partial class Clock : ContentPage
{
	Stopwatch MyTime { get; set; }

    public Clock()
	{
		InitializeComponent();
        MyTime = new Stopwatch();
		CurrentDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
	}

    private void OnBtnClicked(object sender, EventArgs e)
    {
		if (!MyTime.IsRunning)
		{
			MyTime.Start();
			MyTimer.Text = "Tryck för att avsluta";
		}
		else
		{
			TimeSpan ts = MyTime.Elapsed;
			MyTimer.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
				ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            MyTime.Reset();
		}
    }

    private async void OnMainMenuClicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}