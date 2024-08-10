using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMusicPlayerApp.GlobalInterfaces;

namespace StateMusicPlayerApp.Models
{
    public class PlayingState : IMediaPlayerState
    {
        public void Play(MediaPlayer context)
        {
            System.Console.WriteLine("Already playing.");
        }

        public void Pause(MediaPlayer context)
        {
            System.Console.WriteLine("Pausing playback.");
            context.SetState(new PausedState());
        }

        public void Stop(MediaPlayer context)
        {
            System.Console.WriteLine("Stopping playback.");
            context.SetState(new StoppedState());
        }
    }

}
