using colorvalues;
namespace tests {
public class Color_Tests {

	public static int CMYK_Returns_Type_When_Called() {

		var ColorCMYK = new Color.CMYK(0.33, 0.61, 0.0, 0.22);
		string CMYK_Type_String = "CMYK";
		string Returned_Type_String;

		Returned_Type_String = ColorCMYK.Type;

		Assert.
	}
}
}