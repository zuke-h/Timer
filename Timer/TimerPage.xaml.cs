namespace Timer;

public partial class TimerPage : ContentPage
{
    private TimeOnly time = new();
    private TimeOnly time2 = new();
    private bool isRunning;
    private bool isRunning2;

    public TimerPage()
    {
        InitializeComponent();


    }
    private void SetTime()
    {
        label1.Text = $"{time.Hour:0}:{time.Minute:0}:{time.Second}";
        var str1 = "00:00:10";

        if (label1.Text == str1)
        {
            SetTime();
        }
    }

    private async void OnStart(Object sender, System.EventArgs e)
    {
        isRunning = !isRunning;
        if (isRunning)
        {
            StartBtn.Text = "計測中";
        }
        else
            StartBtn.Text = "計測スタート";



        while (isRunning)
        {
            time = time.Add(TimeSpan.FromSeconds(1));
            SetTime();
            await Task.Delay(TimeSpan.FromSeconds(1));
        }


    }

    void btnStop(Object sender, System.EventArgs e)
    {

        isRunning = !isRunning;
        StartBtn.Text = "計測スタート";


    }
    private void btnReset(Object sender, System.EventArgs e)
    {
        isRunning = !isRunning;
        StartBtn.Text = "計測スタート";
        label1.Text = "00:00:00";
        time = new TimeOnly();
        SetTime();
    }

    private void SetTime2()
    {
        label2.Text = $"{time2.Hour:0}:{time2.Minute:0}:{time2.Second:0}";
    }

    private async void OnStart2(Object sender, System.EventArgs e)
    {
        isRunning2 = !isRunning2;
        if (isRunning2)
        {
            Start2Btn.Text = "計測中";
        }
        else
            Start2Btn.Text = "計測スタート";

        while (isRunning2)
        {
            time2 = time2.Add(TimeSpan.FromSeconds(1));
            SetTime2();
            await Task.Delay(TimeSpan.FromSeconds(1));
        }

    }

    void btnStop2(Object sender, System.EventArgs e)
    {

        isRunning2 = !isRunning2;
        Start2Btn.Text = "計測スタート";


    }
    private void btnReset2(Object sender, System.EventArgs e)
    {
        isRunning2 = !isRunning2;
        Start2Btn.Text = "計測スタート";
        label2.Text = "00:00:00";
        time2 = new TimeOnly();
        SetTime2();
    }

}
