using colorvalues;
namespace tests {
public class Color_Tests {

	public static int CMYK_HasValue_Cyan(Color.CMYK InputValue) {
		int result;

		double? InputValue_Cyan = InputValue.Cyan;
		Console.WriteLine("CMYK_Has_Cyan_Value");
		result = Assert.IsNotNull(InputValue_Cyan, "InputValue.Cyan");
		return result;
	}

	public static int CMYK_HasValue_Magenta(Color.CMYK InputValue) {
		int result;

		double? InputValue_Magenta = InputValue.Magenta;
		Console.WriteLine("CMYK_Has_Magenta_Value");
		result = Assert.IsNotNull(InputValue_Magenta, "InputValue.Magenta");
		return result;
	}

	public static int CMYK_HasValue_Yellow(Color.CMYK InputValue) {
		int result;

		double? InputValue_Yellow = InputValue.Yellow;
		Console.WriteLine("CMYK_Has_Yellow_Value");
		result = Assert.IsNotNull(InputValue_Yellow, "InputValue.Yellow");
		return result;
	}

	public static int CMYK_HasValue_Key(Color.CMYK InputValue) {
		int result;

		double? InputValue_Key = InputValue.Key;
		Console.WriteLine("CMYK_HasValue_Key");
		result = Assert.IsNotNull(InputValue_Key, "InputValue.Key");
		return result;
	}
}
}