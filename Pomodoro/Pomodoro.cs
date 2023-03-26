using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro
{
    public class Pomodoro
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public TimeSpan Duration { get; set; } = new TimeSpan(0, 25, 0);

        public void Start()
        {
            StartTime = DateTime.UtcNow;
            EndTime = StartTime + Duration; 
        }

        public TimeSpan GetRemainingTime()
        {
            return EndTime - DateTime.UtcNow;
        }

        public bool IsElapsed()
        {
            return DateTime.UtcNow > EndTime;
        }
    }
}
