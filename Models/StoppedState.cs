using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMusicPlayerApp.GlobalInterfaces;

namespace StateMusicPlayerApp.Models
{
    public class StoppedState : IMediaPlayerState
    {
        public void Play(MediaPlayer context)
        {
            System.Console.WriteLine("Starting playback.");
            context.SetState(new PlayingState());
        }

        public void Pause(MediaPlayer context)
        {
            System.Console.WriteLine("Cannot pause. Media is stopped.");
        }

        public void Stop(MediaPlayer context)
        {
            System.Console.WriteLine("Already stopped.");
        }
    }

}
