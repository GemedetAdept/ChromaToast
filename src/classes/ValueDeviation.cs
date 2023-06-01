namespace colorvalues {
public class ValueDeviation {

	public virtual int Next(int lowerBound, int upperBound) {
		return 1;
	}
}

public class UniformBounded : ValueDeviation {

	public override int Next(int lowerBound, int upperBound) {
		Random newRandom = new Random();
		int outputValue = newRandom.Next(lowerBound, upperBound);

		return outputValue;
	}
}
}