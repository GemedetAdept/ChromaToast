using colorvalues;
namespace tests {
public class BlendColors_Tests {

	public static int BlendHSV_Returns_HSV() {
		var ColorA = new Color.HSV(267.0, 61.0, 78.0);
		var ColorB = new Color.HSV(216.0, 57.0, 90.0);
		var modelHSV = new Color.HSV(0.0, 0.0, 0.0);

		var ColorAB = BlendColors.BlendHSV(ColorA, ColorB);

		Console.WriteLine("");
		Assert.IsType(ColorAB, modelHSV, "BlendHSV_Returns_HSV");
		return 1;
	}
}
}