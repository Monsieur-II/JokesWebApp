namespace JokesWebApp;

public class Joke
{
	public int Id { get; set; }
	public string JokeQuesion { get; set; } = "";
	public string JokeAnswer { get; set; } = "";
	public string UserEmail { get; set; } = "";

	public Joke()
	{
		
	}
}
