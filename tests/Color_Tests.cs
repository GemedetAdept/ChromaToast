using colorvalues;
namespace tests {
public class Color_Tests {

	public static int Created_CMYK_HasValue_Cyan(double CyanValue, double MagentaValue, double YellowValue, double KeyValue) {
		int result;
		double Cyan = CyanValue;
		double Magenta = MagentaValue;
		double Yellow = YellowValue;
		double Key = KeyValue;

		Color.CMYK CreatedCMYK = new Color.CMYK(CyanValue,MagentaValue,YellowValue,KeyValue);
		double? CreatedCMYK_Cyan = CreatedCMYK.Cyan;

		result = Assert.IsNotNull(CreatedCMYK_Cyan, "Created_CMYK_HasValue_Cyan CMYK.Cyan");
		return result;
	}

	public static int Created_CMYK_HasValue_Magenta(double CyanValue, double MagentaValue, double YellowValue, double KeyValue) {
		int result;
		double Cyan = CyanValue;
		double Magenta = MagentaValue;
		double Yellow = YellowValue;
		double Key = KeyValue;

		Color.CMYK CreatedCMYK = new Color.CMYK(CyanValue,MagentaValue,YellowValue,KeyValue);
		double? CreatedCMYK_Magenta = CreatedCMYK.Magenta;

		result = Assert.IsNotNull(CreatedCMYK_Magenta, "Created_CMYK_HasValue_Magenta CMYK.Magenta");
		return result;
	}

	public static int Created_CMYK_HasValue_Yellow(double CyanValue, double MagentaValue, double YellowValue, double KeyValue) {
		int result;
		double Cyan = CyanValue;
		double Magenta = MagentaValue;
		double Yellow = YellowValue;
		double Key = KeyValue;

		Color.CMYK CreatedCMYK = new Color.CMYK(CyanValue,MagentaValue,YellowValue,KeyValue);
		double? CreatedCMYK_Yellow = CreatedCMYK.Yellow;

		result = Assert.IsNotNull(CreatedCMYK_Yellow, "Created_CMYK_HasValue_Yellow CMYK.Yellow");
		return result;
	}

	public static int Created_CMYK_HasValue_Key(double CyanValue, double MagentaValue, double YellowValue, double KeyValue) {
		int result;
		double Cyan = CyanValue;
		double Magenta = MagentaValue;
		double Yellow = YellowValue;
		double Key = KeyValue;

		Color.CMYK CreatedCMYK = new Color.CMYK(CyanValue,MagentaValue,YellowValue,KeyValue);
		double? CreatedCMYK_Key = CreatedCMYK.Key;

		result = Assert.IsNotNull(CreatedCMYK_Key, "Created_CMYK_HasValue_Yellow CMYK.Key");
		return result;
	}
}
}