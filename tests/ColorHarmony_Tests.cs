using colorvalues;
using colorharmony;
namespace tests {
public class ColorHarmony_Tests {

	public static int Complementary_Hue_Difference_Is_180() {

		var inputHSV = new Color.HSV(268.0, 62.0, 78.0);
		var outputHSV_Array = new Color.HSV[1];
		double ComplementaryHueOffset = 360.0/2.0;

		outputHSV_Array = ColorHarmony.Complementary(inputHSV);

		var A_HSV = outputHSV_Array[0];
		var B_HSV = outputHSV_Array[1];

		var AB_deltaHue = Math.Abs(A_HSV.Hue - B_HSV.Hue);

		Console.WriteLine("");
		Assert.DoubleAreEqual(AB_deltaHue, ComplementaryHueOffset, "Complementary_Hue_Difference_Is_120");

		return 1;
	}

	public static int SplitComplementary_Hue_Difference_Is_210_150() {

		var inputHSV = new Color.HSV(268.0, 62.0, 78.0);
		var outputHSV_Array = new Color.HSV[2];
		double SplitComplementaryHueOffset210 = 210.0;
		double SplitComplementaryHueOffset150 = 150.0;

		outputHSV_Array = ColorHarmony.SplitComplementary(inputHSV);

		var A_HSV = outputHSV_Array[0];
		var B_HSV = outputHSV_Array[1];
		var C_HSV = outputHSV_Array[2];

		var AB_deltaHue = Math.Abs(A_HSV.Hue - B_HSV.Hue);
		var AC_deltaHue = Math.Abs(A_HSV.Hue - C_HSV.Hue);

		Console.WriteLine("");
		Assert.DoubleAreEqual(AB_deltaHue, SplitComplementaryHueOffset210, "SplitComplementary_Hue_Difference_Is_210");
		Assert.DoubleAreEqual(AC_deltaHue, SplitComplementaryHueOffset150, "SplitComplementary_Hue_Difference_Is_150");

		return 1;
	}

	public static int Triadic_Hue_Difference_Is_120() {

		var inputHSV = new Color.HSV(268.0, 62.0, 78.0);
		var outputHSV_Array = new Color.HSV[2];
		double TriadicHueOffset = 360.0/3.0;

		outputHSV_Array = ColorHarmony.Triadic(inputHSV);

		var A_HSV = outputHSV_Array[0];
		var B_HSV = outputHSV_Array[1];
		var C_HSV = outputHSV_Array[2];

		var AB_deltaHue = Math.Abs((A_HSV.Hue - B_HSV.Hue)/2);
		var AC_deltaHue = Math.Abs(A_HSV.Hue - C_HSV.Hue);
		var BC_deltaHue = Math.Abs(B_HSV.Hue - C_HSV.Hue);

		Console.WriteLine("");
		Assert.DoubleAreEqual(AB_deltaHue, TriadicHueOffset, "Triadic_Hue_Difference_Is_120 AB_deltaHue");
		Assert.DoubleAreEqual(AC_deltaHue, TriadicHueOffset, "Triadic_Hue_Difference_Is_120 AC_deltaHue");
		Assert.DoubleAreEqual(BC_deltaHue, TriadicHueOffset, "Triadic_Hue_Difference_Is_120 BC_deltaHue");

		return 1;
	}

	public static int Tetradic_Hue_Difference_Is_240_180_240() {

		var inputHSV = new Color.HSV(268.0, 62.0, 78.0);
		var outputHSV_Array = new Color.HSV[3];
		double TetradicHueOffset240 = 240.0;
		double TetradicHueOffset180 = 180.0;

		outputHSV_Array = ColorHarmony.Tetradic(inputHSV);

		var A_HSV = outputHSV_Array[0];
		var B_HSV = outputHSV_Array[1];
		var C_HSV = outputHSV_Array[2];
		var D_HSV = outputHSV_Array[3];

		var AB_deltaHue = Math.Abs(A_HSV.Hue - B_HSV.Hue);
		var AC_deltaHue = Math.Abs(A_HSV.Hue - C_HSV.Hue);
		var AD_deltaHue = Math.Abs(A_HSV.Hue - D_HSV.Hue);

		Console.WriteLine("");
		Assert.DoubleAreEqual(AB_deltaHue, TetradicHueOffset240, "Tetradic_Hue_Difference_Is_240 AB_deltaHue");
		Assert.DoubleAreEqual(AC_deltaHue, TetradicHueOffset180, "Triadic_Hue_Difference_Is_180 AC_deltaHue");
		Assert.DoubleAreEqual(AB_deltaHue, TetradicHueOffset240, "Tetradic_Hue_Difference_Is_240 AB_deltaHue");

		return 1;
	}

	public static int Square_Hue_Difference_Is_90() {

		var inputHSV = new Color.HSV(268.0, 62.0, 78.0);
		var outputHSV_Array = new Color.HSV[3];
		double SquareHueOffset = 360.0/4;

		outputHSV_Array = ColorHarmony.Square(inputHSV);

		var A_HSV = outputHSV_Array[0];
		var B_HSV = outputHSV_Array[1];
		var C_HSV = outputHSV_Array[2];
		var D_HSV = outputHSV_Array[3];

		var AB_deltaHue = Math.Abs(A_HSV.Hue - B_HSV.Hue);
		var BC_deltaHue = Math.Abs((B_HSV.Hue - C_HSV.Hue)/3);
		var CD_deltaHue = Math.Abs(C_HSV.Hue - D_HSV.Hue);
		var DA_deltaHue = Math.Abs(D_HSV.Hue - A_HSV.Hue);

		Console.WriteLine("");
		Assert.DoubleAreEqual(AB_deltaHue, SquareHueOffset, "Square_Hue_Difference_Is_90 AB_deltaHue");
		Assert.DoubleAreEqual(BC_deltaHue, SquareHueOffset, "Square_Hue_Difference_Is_90 BC_deltaHue");
		Assert.DoubleAreEqual(CD_deltaHue, SquareHueOffset, "Square_Hue_Difference_Is_90 CD_deltaHue");
		Assert.DoubleAreEqual(DA_deltaHue, SquareHueOffset, "Square_Hue_Difference_Is_90 DA_deltaHue");

		return 1;
	}

	public static int Analogous_Hue_Difference_Is_30() {

		var inputHSV = new Color.HSV(268.0, 62.0, 78.0);
		var outputHSV_Array = new Color.HSV[2];
		double AnalogousHueOffset = 30.0;

		outputHSV_Array = ColorHarmony.Analogous(inputHSV);

		var A_HSV = outputHSV_Array[0];
		var B_HSV = outputHSV_Array[1];
		var C_HSV = outputHSV_Array[2];

		var AB_deltaHue = Math.Abs(A_HSV.Hue - B_HSV.Hue);
		var AC_deltaHue = Math.Abs(A_HSV.Hue - C_HSV.Hue);

		Console.WriteLine("");
		Assert.DoubleAreEqual(AB_deltaHue, AnalogousHueOffset, "Analogous_Hue_Difference_Is_30 AB_deltahue");
		Assert.DoubleAreEqual(AC_deltaHue, AnalogousHueOffset, "Analogous_Hue_Difference_Is_30 AC_deltahue");

		return 1;
	}
}
}