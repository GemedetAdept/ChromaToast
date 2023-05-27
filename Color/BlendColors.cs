namespace colorvalues {
public class BlendColors {



	public static Color.HSV BlendHSV(Color.HSV ColorA, Color.HSV ColorB) {
		var outputColorAB = new Color.HSV(0.0, 0.0, 0.0);

		outputColorAB.Hue = Math.Round(Math.Abs((ColorA.Hue + ColorB.Hue))/2);
		outputColorAB.Saturation = Math.Round(Math.Abs((ColorA.Saturation + ColorB.Saturation))/2);
		outputColorAB.Value = Math.Round(Math.Abs((ColorA.Value + ColorB.Value))/2);

		return outputColorAB;
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