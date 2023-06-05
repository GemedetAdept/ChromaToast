namespace datahandling {
public class Request {

	public static int Ping() {
		DateTime request = DateTime.Now;
		Console.WriteLine("Pong!");

		DateTime response = DateTime.Now;

		Console.WriteLine($"Response in: {response.Subtract(request)}");

		return 1;
	}
}
}