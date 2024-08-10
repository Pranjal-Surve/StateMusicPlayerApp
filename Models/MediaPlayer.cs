using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMusicPlayerApp.GlobalInterfaces;

namespace StateMusicPlayerApp.Models
{
    // MediaPlayer
    public class MediaPlayer
    {
        private IMediaPlayerState _state;

        public MediaPlayer()
        {
            // Initial state
            _state = new StoppedState();
        }

        public void SetState(IMediaPlayerState state)
        {
            _state = state;
        }

        public void Play()
        {
            _state.Play(this);
        }

        public void Pause()
        {
            _state.Pause(this);
        }

        public void Stop()
        {
            _state.Stop(this);
        }
    }

}
