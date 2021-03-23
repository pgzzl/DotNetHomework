using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ClockTest
{
   
    class Clock
    {
        private static DateTime currentTime = DateTime.Now;
        private  static int hour;
        private static int minute;
        private static int second;
        public static System.Timers.Timer aTimer;

        public static void setAlarm(int hour, int minute, int second)
        {
            Console.WriteLine($"currentHour:{currentTime.Hour}currentMinute:{currentTime.Minute}currentSecond:{currentTime.Second}");
            if (hour < 24 && hour >= 0 && minute >= 0 && minute < 60 && second >= 0 && second < 60)
            {
                Clock.hour = hour;
                Clock.minute = minute;
                Clock.second = second;
            }
            else
            {
                Console.WriteLine("设置alarm错误");
                Clock.hour = Clock.minute = Clock.second = -1;
            }
           

        }
        public static void ClockBegin()
        {

            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += Tick;
            aTimer.Elapsed +=  Alarm;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        public static void Tick(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Tick ");
            
        }

        public static void Alarm(Object source, ElapsedEventArgs e)
        {
            if (currentTime.Second == second&&currentTime.Minute==minute&&currentTime.Hour==hour)
                Console.WriteLine("Alarm!!Alarm!! ");
        }

    }
   
    class Program
    {
        
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            int newHour;
            int newMinute;
            int newSecond;
            Console.WriteLine("输入小时：分钟：秒 来设置闹钟时间");
            newHour = int.Parse(Console.ReadLine());
            newMinute = int.Parse(Console.ReadLine());
            newSecond = int.Parse(Console.ReadLine());
            Clock.setAlarm(newHour, newMinute, newSecond);
            Clock.ClockBegin();
            Console.ReadLine();
            Clock.aTimer.Stop();
            Clock.aTimer.Dispose();
           

            






        }
    }
}
