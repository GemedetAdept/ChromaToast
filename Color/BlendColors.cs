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
		outputColor.Magenta = MixAdditive(ColorAlpha.Magneta, ColorBeta.Magneta);
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
}
}