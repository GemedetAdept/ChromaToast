using colorvalues;
namespace userinput {
public class UserInput {

	private string _inputData;
	public UserInput() {
		InputData = _inputData;
	}

	public string InputData {
		get {return _inputData;}
		set {_inputData = value;}
	}

	public static string Query(string queryMessage) {

		UserInput userInput = new UserInput();
		
		Console.WriteLine(queryMessage);
		Console.WriteLine("");
		Console.Write("> "); userInput.InputData = Console.ReadLine();

		return userInput.InputData;
	}

	public static Color.HEX InputHEX(string inputHEX) {

		var outputHEX = new Color.HEX(inputHEX);
		return outputHEX;
	}

}
}