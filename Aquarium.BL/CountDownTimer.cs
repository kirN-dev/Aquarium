using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    class CountDownTimer
    {
        private DateTime endTime;
        private TimeSpan timeRest;
        private double duration = Double.NaN;
        /// <summary>Оставшееся время отсчёта</summary>
        public TimeSpan TimeRest { get; }

        private System.Timers.Timer timer;
        /// <summary>
        /// Создание нового экземпляра таймера обратного отсчёта с указанным временем окончания
        /// </summary>
        /// <param name="EndTime">Время окончания отсчёта</param>
        public CountDownTimer(DateTime EndTime)
        {
            endTime = EndTime;
            timer = new System.Timers.Timer(100);
            timer.Elapsed += timer_Elapsed;
        }
        /// <summary>
        /// Создание нового экземпляра таймера обратного отсчёта с заданной длительностью
        /// </summary>
        /// <param name="d">Длительность обратного отсчёта</param>
        public CountDownTimer(double d)
        {
            duration = d;
            timer = new System.Timers.Timer(100);
            timer.Elapsed += timer_Elapsed;
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timeRest = endTime.Subtract(e.SignalTime);
            CountDown(this, new EventArgs());
            if (timeRest <= TimeSpan.Zero)
            {
                timer.Stop();
                CountDownEnd(this, new EventArgs());
            }
        }
        /// <summary>
        /// Запуск таймера обратного отсчёта
        /// </summary>
        public void Start()
        {
            if (duration != Double.NaN)
                endTime = DateTime.Now.AddSeconds(duration);
            timer.Start();
        }
        /// <summary>
        /// Остановка таймера обратного отсчёта
        /// </summary>
        public void Stop()
        {
            timer.Stop();
        }
        /// <summary>
        /// Событие окончания отсчёта
        /// </summary>
        public event EventHandler CountDownEnd;
        /// <summary>
        /// Событие отсчёта
        /// </summary>
        public event EventHandler CountDown;
    }
}
