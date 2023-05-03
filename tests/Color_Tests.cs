using colorvalues;
namespace tests {
public class Color_Tests {

	public static int CMYK_Has_Cyan_Value(Color.CMYK InputValue) {
		int result;

		double? InputValue_Cyan = InputValue.Cyan;
		Console.WriteLine("CMYK_Has_Cyan_Value");
		result = Assert.IsNotNull(InputValue_Cyan, "InputValue.Cyan");
		return result;
	}
}
}