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

	public static Color.HSV InputHSV(string inputHSV) {

		string[] partsHSV = new string[3];
		if (inputHSV.Contains("(")) {
			partsHSV = inputHSV.Split("(").Split(")").Split(",");
		}
		else {
			partsHSV = inputHSV.Split(",");
		}

		double Hue = Convert.ToDouble(partsHSL[0]);
		double Saturation = Convert.ToDouble(partsHSL[1]);
		double Value = Convert.ToDouble(partsHSL[2]);

		Color.HSV outputHSV = new Color.HSV(Hue, Saturation, Value);		
	}

	public static Color.RGB InputRGB(string inputRGB) {

		string[] partsRGB = new string[3];
		if (inputRGB.Contains("(")) {
			partsRGB = inputRGB.Split("(").Split(")").Split(",");
		}
		else {
			partsRGB = inputRGB.Split(",");
		}

		double Red = Convert.ToDouble(partsHSL[0]);
		double Green = Convert.ToDouble(partsHSL[1]);
		double Blue = Convert.ToDouble(partsHSL[2]);

		Color.RGB outputRGB = new Color.RGB(Red, Green, Blue);
	}

}
}