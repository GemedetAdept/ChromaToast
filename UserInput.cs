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

	public static Color.HSL InputHSL(string inputHSL) {

		string[] partsHSL = new string[3];
		if (inputHSL.Contains("(")) {
			partsHSL = inputHSL.Split("(").Split(")").Split(",");
		}
		else {
			partsHSL = inputHSL.Split(",");
		}

		double Hue = Convert.ToDouble(partsHSL[0]);
		double Saturation = Convert.ToDouble(partsHSL[1]);
		double Lightness = Convert.ToDouble(partsHSL[2]);

		Color.HSL outputHSL = new Color.HSL(Hue, Saturation, Lightness);
	}

}
}