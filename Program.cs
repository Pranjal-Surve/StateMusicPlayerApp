using System;
using StateMusicPlayerApp.Models;

class Program
{
    static void Main()
    {
        MediaPlayer mediaPlayer = new MediaPlayer();

        mediaPlayer.Play();  // Output: Starting playback.
        mediaPlayer.Pause(); // Output: Pausing playback.
        mediaPlayer.Play();  // Output: Resuming playback.
        mediaPlayer.Stop();  // Output: Stopping playback.
        mediaPlayer.Pause(); // Output: Cannot pause. Media is stopped.
    }
}
