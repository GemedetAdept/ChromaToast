namespace tests {
public class TestsDriver {

	public static int Initialize() {
		Console.Clear();
		Console.WriteLine("--*[TestsDriver]*--");
		Console.WriteLine("");

		return 1;
	}

	public static int Run_Color_Tests(bool toggle) {
	if (toggle == true) {
		Console.WriteLine("-- Color_Tests --");

		Color_Tests.CMYK_Returns_Type_When_Called();
		Color_Tests.HEX_Returns_Type_When_Called();
		Color_Tests.HSL_Returns_Type_When_Called();
		Color_Tests.HSV_Returns_Type_When_Called();
		Color_Tests.RGB_Returns_Type_When_Called();

		Console.WriteLine("");
		return 1;
	} return 0;
	}

	public static int Run_ColorHarmony_Tests(bool toggle) {
	if (toggle == true) {
		Console.WriteLine("-- ColorHarmony_Tests --");

		ColorHarmony_Tests.Complementary_Hue_Difference_Is_180();
		ColorHarmony_Tests.SplitComplementary_Hue_Difference_Is_210_150();
		ColorHarmony_Tests.Triadic_Hue_Difference_Is_120();
		ColorHarmony_Tests.Tetradic_Hue_Difference_Is_240_180_240();
		ColorHarmony_Tests.Square_Hue_Difference_Is_90();
		ColorHarmony_Tests.Analogous_Hue_Difference_Is_30();
		ColorHarmony_Tests.capValue_Above_Ceiling_Subtracts_Ceiling();
		ColorHarmony_Tests.capValue_Below_Floor_Adds_Ceiling();
		ColorHarmony_Tests.capValue_Handles_Input_Below_Negative_Ceiling();

		Console.WriteLine("");
		return 1;
	} return 0;
	}
}
}