using colorvalues;
namespace tests {
public class ValueDeviation_Tests {

	public static int Int32_UniformBounded_Next_Is_Within_Bounds() {
		var random = new ValueDeviation.UniformBounded();
		int lowerBound = 0;
		int upperBound = 360;

		int generatedValue = random.Next(lowerBound, upperBound);

		Console.WriteLine("");
		Assert.IsGreaterThanOrEqual(generatedValue, lowerBound, "Int32_UniformBounded_Next_Is_Within_Bounds");
		Assert.IsLessThanOrEqual(generatedValue, upperBound, "Int32_UniformBounded_Next_Is_Within_Bounds");
		return 1;
	}
	public static int Double_UniformBounded_Next_Is_Within_Bounds() {
		var random = new ValueDeviation.UniformBounded();
		int lowerBound = 0.0;
		int upperBound = 360.0;

		int generatedValue = random.Next(lowerBound, upperBound);

		Console.WriteLine("");
		Assert.IsGreaterThanOrEqual(generatedValue, lowerBound, "Int32_UniformBounded_Next_Is_Within_Bounds");
		Assert.IsLessThanOrEqual(generatedValue, upperBound, "Int32_UniformBounded_Next_Is_Within_Bounds");
		return 1;
	}
}
}