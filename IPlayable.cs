using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    using System;

    // Define an interface IPlayable
    public interface IPlayable
    {
        void Play();
    }

    // Implementing IPlayable in MusicPlayer class
    public class MusicPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing music...");
        }
    }

    // Implementing IPlayable in VideoPlayer class
    public class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing video...");
        }
    }

    // Main Program
    class Program
    {
        static void Main()
        {
            IPlayable music = new MusicPlayer();
            IPlayable video = new VideoPlayer();

            music.Play();
            video.Play();
        }
    }

}
