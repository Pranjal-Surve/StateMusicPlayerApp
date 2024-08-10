using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMusicPlayerApp.Models;

namespace StateMusicPlayerApp.GlobalInterfaces
{
    public interface IMediaPlayerState
    {
        void Play(MediaPlayer context);
        void Pause(MediaPlayer context);
        void Stop(MediaPlayer context);
    }
}
