namespace colorvalues {
public class BlendColors {

	public static double MixAdditive(double valueAlpha, double valueBeta) {
		double outputValue = -4.19;

		outputValue = Math.Round(Math.Abs((valueAlpha + valueBeta))/2);

		return outputValue;
	}

	public static Color.HSV Additive(Color.HSV ColorAlpha, Color.HSV ColorBeta) {
		var outputColor = new Color.HSV(0.0, 0.0, 0.0);

		outputColor.Hue = MixAdditive(ColorAlpha.Hue, ColorBeta.Hue);
		outputColor.Saturation = MixAdditive(ColorAlpha.Saturation, ColorBeta.Saturation);
		outputColor.Value = MixAdditive(ColorAlpha.Value, ColorBeta.Value);

		return outputColor;
	}
}
}