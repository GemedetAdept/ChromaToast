namespace datahandling {
public class Request {

	public static int Ping() {
		DateTime request = DateTime.Now;
		Console.WriteLine("Pong!");

		DateTime response = DateTime.Now;

		Console.WriteLine($"Response in: {response.Subtract(request).TotalMilliseconds} ms");

		return 1;
	}

	public static int Menu(int menuCode) {
		return 1;
	}
}
}