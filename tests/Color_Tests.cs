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
}
}