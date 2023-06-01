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
		return 1;
	}
	return 1;
	}
}
}