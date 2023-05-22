using colorvalues;
using colorharmony;
namespace tests {
public class ColorHarmony_Tests {

	public static int Complementary_Hue_Difference_Is_180() {

		var inputHSV = new Color.HSV(174.0, 85.0, 56.0);
		var outputHSV_Array = new Color.HSV[1];

		outputHSV_Array = ColorHarmony.Complementary(inputHSV);

		var A_HSV = outputHSV_Array[0];
		var B_HSV = outputHSV_Array[1];

		var AB_deltaHue = Math.Abs(A_HSV.Hue - B_HSV.Hue);

		double ComplementaryHueOffset = 360.0/2;

		Assert.DoubleAreEqual(AB_deltaHue, ComplementaryHueOffset, "Complementary_Hue_Difference_Is_120");

		return 1;
	}
}
}