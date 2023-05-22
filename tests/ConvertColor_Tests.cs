using colorvalues;
using convertbase;
using convertcolor;
namespace tests {
public class ConvertColor_Tests {

// CMYK ->
	public static int CMYKtoHEX_Produces_HEX() {
		int result;

		var inputCMYK = new Color.CMYK(0.33, 0.61, 0.0, 0.22);
		var modelHEX = new Color.HEX("000000");

		var outputHEX = ConvertColor.CMYKtoHEX(inputCMYK);

		Console.WriteLine("");
		Assert.IsType(outputHEX, modelHEX, "CMYKtoHEX_Produces_HEX");
		return 1;
	}

	public static int CMYKtoHSV_Produces_HSV() {
		int result;

		var inputCMYK = new Color.CMYK(0.33, 0.61, 0.0, 0.22);
		var modelHSV = new Color.HSV(360.0, 1.0, 1.0);

		var outputHSV = ConvertColor.CMYKtoHSV(inputCMYK);

		Console.WriteLine("");
		Assert.IsType(outputHSV, modelHSV, "CMYKtoHSV_Produces_HSV");
		return 1;
	}

	public static int CMYKtoHSL_Produces_HSL() {
		int result;

		var inputCMYK = new Color.CMYK(0.33, 0.61, 0.0, 0.22);
		var modelHSL = new Color.HSL(360.0, 1.0, 1.0);

		var outputHSL = ConvertColor.CMYKtoHSL(inputCMYK);

		Console.WriteLine("");
		Assert.IsType(outputHSL, modelHSL, "CMYKtoHSL_Produces_HSL");
		return 1;
	}

	public static int CMYKtoRGB_Produces_RGB() {
		int result;

		var inputCMYK = new Color.CMYK(0.33, 0.61, 0.0, 0.22);
		var modelRGB = new Color.RGB(255.0, 255.0, 255.0);

		var outputRGB = ConvertColor.CMYKtoRGB(inputCMYK);

		Console.WriteLine("");
		Assert.IsType(outputRGB, modelRGB, "CMYKtoRGB_Produces_RGB");
		return 1;
	}

// HEX ->
	public static int HEXtoCMYK_Produces_CMYK() {
		int result;

		var inputHEX = new Color.HEX("854CC7");
		var modelCMYK = new Color.CMYK(0.0, 0.0, 0.0, 0.0);

		var outputCMYK = ConvertColor.HEXtoCMYK(inputHEX);

		Console.WriteLine("");
		Assert.IsType(outputCMYK, modelCMYK, "HEXtoCMYK_Produces_CMYK");
		return 1;
	}

	public static int HEXtoHSL_Produces_HSL() {
		int result;

		var inputHEX = new Color.HEX("854CC7");
		var modelHSL = new Color.HSL(0.0, 0.0, 0.0);

		var outputHSL = ConvertColor.HEXtoHSL(inputHEX);

		Console.WriteLine("");
		Assert.IsType(outputHSL, modelHSL, "HEXtoHSL_Produces_HSL");
		return 1;
	}

	public static int HEXtoHSV_Produces_HSV() {
		int result;

		var inputHEX = new Color.HEX("854CC7");
		var modelHSV = new Color.HSV(0.0, 0.0, 0.0);

		var outputHSV = ConvertColor.HEXtoHSV(inputHEX);

		Console.WriteLine("");
		Assert.IsType(outputHSV, modelHSV, "HEXtoHSV_Produces_HSV");
		return 1;
	}

	public static int HEXtoRGB_Produces_RGB() {
		int result;

		var inputHEX = new Color.HEX("854CC7");
		var modelRGB = new Color.RGB(0.0, 0.0, 0.0);

		var outputRGB = ConvertColor.HEXtoRGB(inputHEX);

		Console.WriteLine("");
		Assert.IsType(outputRGB, modelRGB, "HEXtoRGB_Produces_RGB");
		return 1;
	}

// HSL
	public static int HSLtoCMYK_Produces_CMYK() {
		int result;

		var inputHSL = new Color.HSL(286.0, 62.0, 78.0);
		var modelCMYK = new Color.CMYK(0.0, 0.0, 0.0, 0.0);

		var outputCMYK = ConvertColor.HSLtoCMYK(inputHSL);

		Console.WriteLine("");
		Assert.IsType(outputCMYK, modelCMYK, "HSLtoCMYK_Produces_CMYK");
		return 1;
	}
}
}