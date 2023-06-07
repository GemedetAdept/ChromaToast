using colorvalues;
using convertcolor;
using userinput;
namespace menudriver {
public class MenuProcedure {

	public static Color.HSV EnterCMYK(Color.HSV outputHSV) {
		string query = "";

		query = UserInput.Query("Enter a value between: (0.0, 0.0, 0.0, 0.0) - (100.0, 100.0, 100.0, 100.0)");
		var inputCMYK = UserInput.InputCMYK(query);

		outputHSV = ConvertColor.CMYKtoHSV(inputCMYK);
		return outputHSV;
	}

	public static Color.HSV EnterHEX(Color.HSV outputHSV) {
		string query = "";

		query = UserInput.Query("#000000 - #FFFFFF");
		var inputHEX = UserInput.InputHEX(query);

		outputHSV = ConvertColor.HEXtoHSV(inputHEX);
		return outputHSV;
	}

	public static Color.HSV EnterHSL(Color.HSV outputHSV) {
		string query = "";

		query = UserInput.Query("(0.0, 0.0, 0.0) - (360.0, 100.0, 100.0)");
		var inputHSL = UserInput.InputHSL(query);

		outputHSV = ConvertColor.HSLtoHSV(inputHSL);
		return outputHSV;
	}

	public static Color.HSV EnterHSV(Color.HSV outputHSV) {
		string query = "";

		query = UserInput.Query("(0.0, 0.0, 0.0) - (360.0, 100.0, 100.0)");
		var inputHSV = UserInput.InputHSV(query);

		outputHSV = inputHSV;
		return outputHSV;
	}

	public static Color.HSV EnterRGB(Color.HSV outputHSV) {
		string query = "";

		query = UserInput.Query("(0, 0, 0) - (255, 255, 255)");
		var inputRGB = UserInput.InputRGB(query);

		outputHSV = ConvertColor.RGBtoHSV(inputRGB);
		return outputHSV;
	}
}
}