namespace colorvalues {
public class BlendColors {

	public static Color.HSV BlendHSV(Color.HSV ColorA, Color.HSV ColorB) {
		var outputColorAB = new Color.HSV(0.0, 0.0, 0.0);

		outputColorAB.Hue = Math.Round((ColorA.Hue + ColorB.Hue)/2);
		outputColorAB.Saturation = Math.Round((ColorA.Saturation + ColorB.Saturation)/2);
		outputColorAB.Value = Math.Round((ColorA.Value + ColorB.Value)/2);

		return outputColorAB;
	}
}
}