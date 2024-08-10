using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMusicPlayerApp.GlobalInterfaces;

namespace StateMusicPlayerApp.Models
{
    public class PausedState : IMediaPlayerState
    {
        public void Play(MediaPlayer context)
        {
            System.Console.WriteLine("Resuming playback.");
            context.SetState(new PlayingState());
        }

        public void Pause(MediaPlayer context)
        {
            System.Console.WriteLine("Already paused.");
        }

        public void Stop(MediaPlayer context)
        {
            System.Console.WriteLine("Stopping playback.");
            context.SetState(new StoppedState());
        }
    }

}
