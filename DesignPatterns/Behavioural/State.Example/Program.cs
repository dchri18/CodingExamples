namespace State.Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            MediaPlayer player = new MediaPlayer();

            player.Play();  // Output: Starting play.
            player.Pause(); // Output: Pausing the player.
            player.Play();  // Output: Resuming play.
            player.Stop();  // Output: Stopping the player.
            player.Pause(); // Output: Player is stopped. Can't pause.
        }
    }
}
