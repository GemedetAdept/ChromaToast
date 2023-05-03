using colorvalues;
namespace tests {
public class Color_Tests {

	public static int Created_CMYK_HasValue_Cyan() {
		int result;
		double CyanValue = 1.0;
		double MagentaValue = 1.0;
		double YellowValue = 1.0;
		double KeyValue = 1.0;

		Color.CMYK CreatedCMYK = new Color.CMYK(CyanValue,MagentaValue,YellowValue,KeyValue);
		double? CreatedCMYK_Cyan = CreatedCMYK.Cyan;

		result = Assert.IsNotNull(CreatedCMYK_Cyan, "Created_CMYK_HasValue_Cyan CMYK.Cyan");
		return result;
	}

	public static int Created_CMYK_HasValue_Magenta() {
		int result;
		double CyanValue = 1.0;
		double MagentaValue = 1.0;
		double YellowValue = 1.0;
		double KeyValue = 1.0;

		Color.CMYK CreatedCMYK = new Color.CMYK(CyanValue,MagentaValue,YellowValue,KeyValue);
		double? CreatedCMYK_Magenta = CreatedCMYK.Magenta;

		result = Assert.IsNotNull(CreatedCMYK_Magenta, "Created_CMYK_HasValue_Magenta CMYK.Magenta");
		return result;
	}

	public static int Created_CMYK_HasValue_Yellow() {
		int result;
		double CyanValue = 1.0;
		double MagentaValue = 1.0;
		double YellowValue = 1.0;
		double KeyValue = 1.0;

		Color.CMYK CreatedCMYK = new Color.CMYK(CyanValue,MagentaValue,YellowValue,KeyValue);
		double? CreatedCMYK_Yellow = CreatedCMYK.Yellow;

		result = Assert.IsNotNull(CreatedCMYK_Yellow, "Created_CMYK_HasValue_Yellow CMYK.Yellow");
		return result;
	}

	public static int Created_CMYK_HasValue_Key() {
		int result;
		double CyanValue = 1.0;
		double MagentaValue = 1.0;
		double YellowValue = 1.0;
		double KeyValue = 1.0;

		Color.CMYK CreatedCMYK = new Color.CMYK(CyanValue,MagentaValue,YellowValue,KeyValue);
		double? CreatedCMYK_Key = CreatedCMYK.Key;

		result = Assert.IsNotNull(CreatedCMYK_Key, "Created_CMYK_HasValue_Yellow CMYK.Key");
		return result;
	}
}
}