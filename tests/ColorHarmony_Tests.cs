using colorvalues;
using colorharmony;
namespace tests {
public class ColorHarmony_Tests {

	public static int Complementary_Hue_Difference_Is_120() {

		var inputHSV = new Color.HSV(174.0, 85.0, 56.0);
		var outputHSV_Array = new Color.HSV[2];

		outputHSV_Array = ColorHarmony.Complementary(inputHSV);

		var A_HSV = inputHSV;
		var B_HSV = outputHSV_Array[0];
		var C_HSV = outputHSV_Array[1];

		var AB_deltaHue = A_HSV.Hue - B_HSV.Hue;
		var AC_deltaHue = A_HSV.Hue - C_HSV.Hue;
		var BC_deltaHue = B_HSV.Hue - C_HSV.Hue;

		double ComplementaryHueOffset = 120.0;

		Assert.DoubleAreEqual(AB_deltaHue, ComplementaryHueOffset);
		Assert.DoubleAreEqual(AC_deltaHue, ComplementaryHueOffset);
		Assert.DoubleAreEqual(BC_deltaHue, ComplementaryHueOffset);

		return 1;
	}
}
}