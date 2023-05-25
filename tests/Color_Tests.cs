using colorvalues;
namespace tests {
public class Color_Tests {

	public static int CMYK_Returns_Type_When_Called() {

		var ColorCMYK = new Color.CMYK(0.33, 0.61, 0.0, 0.22);
		string CMYK_Type_String = "CMYK";
		string Returned_Type_String;

		Returned_Type_String = ColorCMYK.Type;

		Console.WriteLine("");
		Assert.StringAreEqual(Returned_Type_String, CMYK_Type_String, "CMYK_Returns_Type_When_Called");
		return 1;
	}

	public static int HEX_Returns_Type_When_Called() {

		var ColorHEX = new Color.HEX("854CC7");
		string HEX_Type_String = "HEX";
		string Returned_Type_String;

		Returned_Type_String = ColorHEX.Type;

		Console.WriteLine("");
		Assert.StringAreEqual(Returned_Type_String, HEX_Type_String, "HEX_Returns_Type_When_Called");
		return 1;
	}

	public static int HSL_Returns_Type_When_Called() {

		var ColorHSL = new Color.HSL(267.8, 61.8, 78.0);
		string HSL_Type_String = "HSL";
		string Returned_Type_String;

		Returned_Type_String = ColorHSL.Type;

		Console.WriteLine("");
		Assert.StringAreEqual(Returned_Type_String, HSL_Type_String, "HSL_Returns_Type_When_Called");
		return 1;
	}

	public static int HSV_Returns_Type_When_Called() {

		var ColorHSV = new Color.HSV(267.8, 61.8, 78.0);
		string HSV_Type_String = "HSV";
		string Returned_Type_String;

		Returned_Type_String = ColorHSV.Type;

		Console.WriteLine("");
		Assert.StringAreEqual(Returned_Type_String, HSV_Type_String, "HSV_Returns_Type_When_Called");
		return 1;
	}

	public static int RGB_Returns_Type_When_Called() {

		var ColorRGB = new Color.RGB(133.0, 76.0, 199.0);
		string RGB_Type_String = "RGB";
		string Returned_Type_String;

		Returned_Type_String = ColorRGB.Type;

		Console.WriteLine("");
		Assert.StringAreEqual(Returned_Type_String, RGB_Type_String, "RGB_Returns_Type_When_Called");
		return 1;
	}
}
}