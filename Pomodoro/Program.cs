namespace Pomodoro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DigitPlotter p = new DigitPlotter();

            DateTime start = DateTime.UtcNow;
            int lastSecondsValue = 0;
            while (DateTime.UtcNow < start + new TimeSpan(0, 25, 0))
            {
                int[] nums = new int[4];
                var remainingTime = start + new TimeSpan(0, 25, 0) - DateTime.UtcNow;
                var minutes = remainingTime.Minutes;
                var seconds = remainingTime.Seconds;
                if (seconds == lastSecondsValue)
                {
                    Thread.Sleep(100);
                    continue;
                }
                lastSecondsValue = seconds;
                nums[0] = minutes / 10;
                nums[1] = minutes % 10;
                nums[2] = seconds / 10;
                nums[3] = seconds % 10;
                p.PlotTime(nums);
                Thread.Sleep(100);
            }
        }
    }
}