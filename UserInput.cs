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

		if (inputHSL.Contains("(")) {inputHSL.Replace("(", string.Empty);}
		if (inputHSL.Contains(")")) {inputHSL.Replace(")", string.Empty);}
		if (inputHSL.Contains(" ")) {inputHSL.Replace(" ", string.Empty);}

		var partsHSL = inputHSL.Split(",");

		double Hue = -4.19;
		double Saturation = -4.19;
		double Lightness = -4.19;
		Double.TryParse(partsHSL[0], out Hue);
		Double.TryParse(partsHSL[1], out Saturation);
		Double.TryParse(partsHSL[2], out Lightness);

		Color.HSL outputHSL = new Color.HSL(Hue, Saturation, Lightness);
		return outputHSL;
	}

	public static Color.HSV InputHSV(string inputHSV) {

		if (inputHSV.Contains("(")) {inputHSV.Replace("(", string.Empty);}
		if (inputHSV.Contains(")")) {inputHSV.Replace(")", string.Empty);}
		if (inputHSV.Contains(" ")) {inputHSV.Replace(" ", string.Empty);}

		var partsHSV = inputHSV.Split(",");

		double Hue = -4.19;
		double Saturation = -4.19;
		double Value = -4.19;
		Double.TryParse(partsHSV[0], out Hue);
		Double.TryParse(partsHSV[1], out Saturation);
		Double.TryParse(partsHSV[2], out Value);

		Color.HSV outputHSV = new Color.HSV(Hue, Saturation, Value);
		return outputHSV;		
	}

	public static Color.RGB InputRGB(string inputRGB) {

		if (inputRGB.Contains("(")) {inputRGB.Replace("(", string.Empty);}
		if (inputRGB.Contains(")")) {inputRGB.Replace(")", string.Empty);}
		if (inputRGB.Contains(" ")) {inputRGB.Replace(" ", string.Empty);}

		var partsRGB = inputRGB.Split(",");

		double Red = -4.19;
		double Green = -4.19;
		double Blue = -4.19;
		Double.TryParse(partsRGB[0], out Red);
		Double.TryParse(partsRGB[1], out Green);
		Double.TryParse(partsRGB[2], out Blue);

		Color.RGB outputRGB = new Color.RGB(Red, Green, Blue);
		return outputRGB;
	}

}
}