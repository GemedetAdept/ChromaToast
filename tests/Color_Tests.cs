using colorvalues;
namespace tests {
public class Color_Tests {

	public static int CMYK_Returns_Type_When_Called() {

		var ColorCMYK = new Color.CMYK(0.33, 0.61, 0.0, 0.22);
		string CMYK_Type_String = "CMYK";
		string Returned_Type_String;

		Returned_Type_String = ColorCMYK.Type;

		Assert.StringAreEqual(Returned_Type_String, CMYK_Type_String, "CMYK_Returns_Type_When_Called");
		return 1;
	}

	public static int HEX_Returns_Type_When_Called() {

		var ColorHEX = new Color.HEX("854CC7");
		string HEX_Type_String = "HEX";
		string Returned_Type_String;

		Returned_Type_String = ColorHEX.Type;

		Assert.StringAreEqual(Returned_Type_String, HEX_Type_String, "HEX_Returns_Type_When_Called");
		return 1;
	}
}
}