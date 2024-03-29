namespace colorvalues {
public class BlendColors {

	public static double MixAdditive(double valueAlpha, double valueBeta) {
		double outputValue = -4.19;

		outputValue = Math.Round(Math.Abs((valueAlpha + valueBeta))/2);

		return outputValue;
	}

// Additive
	public static Color.HSV Additive(Color.HSV ColorAlpha, Color.HSV ColorBeta) {
		var outputColor = new Color.HSV(0.0, 0.0, 0.0);

		outputColor.Hue = MixAdditive(ColorAlpha.Hue, ColorBeta.Hue);
		outputColor.Saturation = MixAdditive(ColorAlpha.Saturation, ColorBeta.Saturation);
		outputColor.Value = MixAdditive(ColorAlpha.Value, ColorBeta.Value);

		return outputColor;
	}

	public static Color.CMYK Additive(Color.CMYK ColorAlpha, Color.CMYK ColorBeta) {
		var outputColor = new Color.CMYK(0.0, 0.0, 0.0, 0.0);

		outputColor.Cyan = MixAdditive(ColorAlpha.Cyan, ColorBeta.Cyan);
		outputColor.Magenta = MixAdditive(ColorAlpha.Magenta, ColorBeta.Magenta);
		outputColor.Yellow = MixAdditive(ColorAlpha.Yellow, ColorBeta.Yellow);
		outputColor.Key =MixAdditive(ColorAlpha.Key, ColorBeta.Key);

		return outputColor;
	}

	public static Color.HSL Additive(Color.HSL ColorAlpha, Color.HSL ColorBeta) {
		var outputColor = new Color.HSL(0.0, 0.0, 0.0);

		outputColor.Hue = MixAdditive(ColorAlpha.Hue, ColorBeta.Hue);
		outputColor.Saturation = MixAdditive(ColorAlpha.Saturation, ColorBeta.Saturation);
		outputColor.Lightness = MixAdditive(ColorAlpha.Lightness, ColorBeta.Lightness);

		return outputColor;
	}

	public static Color.HEX Additive(Color.HEX ColorAlpha, Color.HEX ColorBeta) {
		var outputColor = new Color.HEX("000000");
		string outputColorValue = "";

		string ColorAlphaValue = ColorAlpha.Value;
		string ColorBetaValue = ColorBeta.Value;

		string[] strings_ColorAlpha = new string[] {
			ColorAlphaValue.Substring(0, 2),
			ColorAlphaValue.Substring(2, 2),
			ColorAlphaValue.Substring(4, 2),
		};
		string[] strings_ColorBeta = new string[] {
			ColorBetaValue.Substring(0, 2),
			ColorBetaValue.Substring(2, 2),
			ColorBetaValue.Substring(4, 2),
		};

		double[] doubles_ColorAlpha = new double[] {
			Convert.ToDouble(strings_ColorAlpha[0]),
			Convert.ToDouble(strings_ColorAlpha[1]),
			Convert.ToDouble(strings_ColorAlpha[2]),
		};
		double[] doubles_ColorBeta = new double[] {
			Convert.ToDouble(strings_ColorBeta[0]),
			Convert.ToDouble(strings_ColorBeta[1]),
			Convert.ToDouble(strings_ColorBeta[2]),
		};

		return outputColor;
	}
}
}