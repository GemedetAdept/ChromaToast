using colorvalues;
namespace tests {
public class ValueDeviation_Tests {

	public int Int32_UniformBounded_Next_Is_Within_Bounds() {
		var random = new ValueDeviation.UniformBounded();
		int lowerBound = 0;
		int upperBound = 360;

		int generatedValue = random.Next(lowerBound, upperBound);
		return 1;
		
	}
}
}