namespace Pomodoro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DigitPlotter plot = new DigitPlotter();
            Pomodoro pomo = new Pomodoro();
            pomo.Start();

            int[] nums = new int[4];
            while (!pomo.IsElapsed())
            {
                var remainingTime = pomo.GetRemainingTime();
                var minutes = remainingTime.Minutes;
                var seconds = remainingTime.Seconds;
                nums[0] = minutes / 10;
                nums[1] = minutes % 10;
                nums[2] = seconds / 10;
                nums[3] = seconds % 10;
                plot.PlotTime(nums);
                Thread.Sleep(100);
            }
        }
    }
}