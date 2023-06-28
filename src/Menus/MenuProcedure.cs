using colorvalues;
using convertcolor;
using colorharmony;
using userinput;
namespace menudriver {
public class MenuProcedure {

	public static Color.HSV EnterCMYK() {
		string query = "";

		query = UserInput.Query("Enter a value between: (0.0, 0.0, 0.0, 0.0) - (100.0, 100.0, 100.0, 100.0)");
		var inputCMYK = UserInput.InputCMYK(query);

		var outputHSV = ConvertColor.CMYKtoHSV(inputCMYK);
		return outputHSV;
	}

	public static Color.HSV EnterHEX() {
		string query = "";

		query = UserInput.Query("Enter a value between: #000000 - #FFFFFF");
		var inputHEX = UserInput.InputHEX(query);

		var outputHSV = ConvertColor.HEXtoHSV(inputHEX);
		return outputHSV;
	}

	public static Color.HSV EnterHSL() {
		string query = "";

		query = UserInput.Query("Enter a value between: (0.0, 0.0, 0.0) - (360.0, 100.0, 100.0)");
		var inputHSL = UserInput.InputHSL(query);

		var outputHSV = ConvertColor.HSLtoHSV(inputHSL);
		return outputHSV;
	}

	public static Color.HSV EnterHSV() {
		string query = "";

		query = UserInput.Query("Enter a value between: (0.0, 0.0, 0.0) - (360.0, 100.0, 100.0)");
		var inputHSV = UserInput.InputHSV(query);

		var outputHSV = inputHSV;
		return outputHSV;
	}

	public static Color.HSV EnterRGB() {
		string query = "";

		query = UserInput.Query("Enter a value between: (0, 0, 0) - (255, 255, 255)");
		var inputRGB = UserInput.InputRGB(query);

		var outputHSV = ConvertColor.RGBtoHSV(inputRGB);
		return outputHSV;
	}

	public static Color.HSV[] OutputComplementary(Color.HSV inputHSV) {

		var outputPalette = new Color.HSV[];
		outputPalette = ColorHarmony.Complementary(inputHSV);
		return outputPalette;
	}

	public static Color.HSV[] OutputSplitComplementary(Color.HSV inputHSV) {

		var outputPalette = new Color.HSV[];
		outputPalette = ColorHarmony.SplitComplementary(inputHSV);
		return outputPalette;
	}

	public static Color.HSV[] OutputTriadic(Color.HSV inputHSV) {

		var outputPalette = new Color.HSV[];
		outputPalette = ColorHarmony.Triadic(inputHSV);
		return outputPalette;
	}

	public static Color.HSV[] OutputTetradic(Color.HSV inputHSV) {

		var outputPalette = new Color.HSV[];
		outputPalette = ColorHarmony.Tetradic(inputHSV);
		return outputPalette;
	}

	public static Color.HSV[] OutputSquare(Color.HSV inputHSV) {

		var outputPalette = new Color.HSV[];
		outputPalette = ColorHarmony.Square(inputHSV);
		return outputPalette;
	}

	public static Color.HSV[] OutputAnalogous(Color.HSV inputHSV) {

		var outputPalette = new Color.HSV[];
		outputPalette = ColorHarmony.Analogous(inputHSV);
		return outputPalette;
	}

	public static Color.HSV[] OutputMonochromatic(Color.HSV inputHSV) {

		var outputPalette = new Color.HSV[];
		outputPalette = ColorHarmony.Monochromatic(inputHSV);
		return outputPalette;
	}
}
}