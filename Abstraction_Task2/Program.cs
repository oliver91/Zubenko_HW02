using System;

namespace Abstraction_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Record();
            player.Stop();
            player.Play();
            player.Pause();
            player.Play();
            player.Stop();
            Console.ReadKey();
        }
    }

    internal interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    internal interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }

    internal class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("playing");
        }

        public void Record()
        {
            Console.WriteLine("recording");
        }

        public void Pause()
        {
            Console.WriteLine("on pause");
        }

        public void Stop()
        {
            Console.WriteLine("stoped");
        }
    }
}
