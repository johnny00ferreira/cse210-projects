public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by guiding you through slow, deep breathing."
        )
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int elapsedTime = 0;

        while (elapsedTime < _duration)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountdown(4);
            elapsedTime += 4;

            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountdown(4);
            elapsedTime += 4;
        }

        DisplayEndingMessage();
    }
}
