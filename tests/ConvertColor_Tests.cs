using colorvalues;
using convertbase;
using convertcolor;
namespace tests {
public class ConvertColor_Tests {

// CMYK ->
	public static int CMYKtoHEX_Produces_HEX() {

		var inputCMYK = new Color.CMYK(0.33, 0.61, 0.0, 0.22);
		var modelHEX = new Color.HEX("000000");

		var outputHEX = ConvertColor.CMYKtoHEX(inputCMYK);

		Console.WriteLine("");
		Assert.IsType(outputHEX, modelHEX, "CMYKtoHEX_Produces_HEX");
		return 1;
	}

	public static int CMYKtoHSV_Produces_HSV() {

		var inputCMYK = new Color.CMYK(0.33, 0.61, 0.0, 0.22);
		var modelHSV = new Color.HSV(360.0, 1.0, 1.0);

		var outputHSV = ConvertColor.CMYKtoHSV(inputCMYK);

		Console.WriteLine("");
		Assert.IsType(outputHSV, modelHSV, "CMYKtoHSV_Produces_HSV");
		return 1;
	}

	public static int CMYKtoHSL_Produces_HSL() {

		var inputCMYK = new Color.CMYK(0.33, 0.61, 0.0, 0.22);
		var modelHSL = new Color.HSL(360.0, 1.0, 1.0);

		var outputHSL = ConvertColor.CMYKtoHSL(inputCMYK);

		Console.WriteLine("");
		Assert.IsType(outputHSL, modelHSL, "CMYKtoHSL_Produces_HSL");
		return 1;
	}

	public static int CMYKtoRGB_Produces_RGB() {

		var inputCMYK = new Color.CMYK(0.33, 0.61, 0.0, 0.22);
		var modelRGB = new Color.RGB(255.0, 255.0, 255.0);

		var outputRGB = ConvertColor.CMYKtoRGB(inputCMYK);

		Console.WriteLine("");
		Assert.IsType(outputRGB, modelRGB, "CMYKtoRGB_Produces_RGB");
		return 1;
	}

// HEX ->
	public static int HEXtoCMYK_Produces_CMYK() {

		var inputHEX = new Color.HEX("854CC7");
		var modelCMYK = new Color.CMYK(0.0, 0.0, 0.0, 0.0);

		var outputCMYK = ConvertColor.HEXtoCMYK(inputHEX);

		Console.WriteLine("");
		Assert.IsType(outputCMYK, modelCMYK, "HEXtoCMYK_Produces_CMYK");
		return 1;
	}

	public static int HEXtoHSL_Produces_HSL() {

		var inputHEX = new Color.HEX("854CC7");
		var modelHSL = new Color.HSL(0.0, 0.0, 0.0);

		var outputHSL = ConvertColor.HEXtoHSL(inputHEX);

		Console.WriteLine("");
		Assert.IsType(outputHSL, modelHSL, "HEXtoHSL_Produces_HSL");
		return 1;
	}

	public static int HEXtoHSV_Produces_HSV() {

		var inputHEX = new Color.HEX("854CC7");
		var modelHSV = new Color.HSV(0.0, 0.0, 0.0);

		var outputHSV = ConvertColor.HEXtoHSV(inputHEX);

		Console.WriteLine("");
		Assert.IsType(outputHSV, modelHSV, "HEXtoHSV_Produces_HSV");
		return 1;
	}

	public static int HEXtoRGB_Produces_RGB() {

		var inputHEX = new Color.HEX("854CC7");
		var modelRGB = new Color.RGB(0.0, 0.0, 0.0);

		var outputRGB = ConvertColor.HEXtoRGB(inputHEX);

		Console.WriteLine("");
		Assert.IsType(outputRGB, modelRGB, "HEXtoRGB_Produces_RGB");
		return 1;
	}

// HSL ->
	public static int HSLtoCMYK_Produces_CMYK() {

		var inputHSL = new Color.HSL(286.0, 62.0, 78.0);
		var modelCMYK = new Color.CMYK(0.0, 0.0, 0.0, 0.0);

		var outputCMYK = ConvertColor.HSLtoCMYK(inputHSL);

		Console.WriteLine("");
		Assert.IsType(outputCMYK, modelCMYK, "HSLtoCMYK_Produces_CMYK");
		return 1;
	}

	public static int HSLtoHEX_Produces_HEX() {

		var inputHSL = new Color.HSL(286.0, 62.0, 78.0);
		var modelHEX = new Color.HEX("000000");

		var outputHEX = ConvertColor.HSLtoHEX(inputHSL);

		Console.WriteLine("");
		Assert.IsType(outputHEX, modelHEX, "HSLtoHEX_Produces_HEX");
		return 1;
	}

	public static int HSLtoHSV_Produces_HSV() {

		var inputHSL = new Color.HSL(286.0, 62.0, 78.0);
		var modelHSV = new Color.HSV(0.0, 0.0, 0.0);

		var outputHSV = ConvertColor.HSLtoHSV(inputHSL);

		Console.WriteLine("");
		Assert.IsType(outputHSV, modelHSV, "HSLtoHSV_Produces_HSV");
		return 1;
	}

	public static int HSLtoRGB_Produces_RGB() {

		var inputHSL = new Color.HSL(286.0, 62.0, 78.0);
		var modelRGB = new Color.RGB(0.0, 0.0, 0.0);

		var outputRGB = ConvertColor.HSLtoRGB(inputHSL);

		Console.WriteLine("");
		Assert.IsType(outputRGB, modelRGB, "HSLtoRGB_Produces_RGB");
		return 1;
	}

// HSV ->
	public static int HSVtoCMYK_Produces_CMYK() {

		var inputHSV = new Color.HSV(286.0, 62.0, 78.0);
		var modelCMYK = new Color.CMYK(0.0, 0.0, 0.0, 0.0);

		var outputCMYK = ConvertColor.HSVtoCMYK(inputHSV);

		Console.WriteLine("");
		Assert.IsType(outputCMYK, modelCMYK, "HSVtoCMYK_Produces_CMYK");
		return 1;
	}

	public static int HSVtoHEX_Produces_HEX() {

		var inputHSV = new Color.HSV(286.0, 62.0, 78.0);
		var modelHEX = new Color.HEX("000000");

		var outputHEX = ConvertColor.HSVtoHEX(inputHSV);

		Console.WriteLine("");
		Assert.IsType(outputHEX, modelHEX, "HSVtoHEX_Produces_HEX");
		return 1;
	}

	public static int HSVtoHSL_Produces_HSL() {

		var inputHSV = new Color.HSV(286.0, 62.0, 78.0);
		var modelHSL = new Color.HSL(0.0, 0.0, 0.0);

		var outputHSL = ConvertColor.HSVtoHSL(inputHSV);

		Console.WriteLine("");
		Assert.IsType(outputHSL, modelHSL, "HSVtoHSL_Produces_HSL");
		return 1;
	}

	public static int HSVtoRGB_Produces_RGB() {

		var inputHSV = new Color.HSV(286.0, 62.0, 78.0);
		var modelRGB = new Color.RGB(0.0, 0.0, 0.0);

		var outputRGB = ConvertColor.HSVtoRGB(inputHSV);

		Console.WriteLine("");
		Assert.IsType(outputRGB, modelRGB, "HSVtoRGB_Produces_RGB");
		return 1;
	}

// RGB ->
	public static int RGBtoCMYK_Produces_CMYK() {

		var inputRGB = new Color.RGB(133.0, 76.0, 199.0);
		var modelCMYK = new Color.CMYK(0.0, 0.0, 0.0, 0.0);

		var outputCMYK = ConvertColor.RGBtoCMYK(inputRGB);

		Console.WriteLine("");
		Assert.IsType(outputCMYK, modelCMYK, "RGBtoCMYK_Produces_CMYK");
		return 1;
	}
}
}