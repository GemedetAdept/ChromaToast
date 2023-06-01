namespace colorvalues {
public class ValueDeviation {

	public class UniformBounded {

		public UniformBounded() {

		}

		public int Next(int lowerBound, int upperBound) {
			Random newRandom = new Random();

			int outputValue = newRandom.Next(lowerBound, upperBound);
				
			return outputValue;
		}

		public double Next(double lowerBound, double upperBound) {
			Random newRandom = new Random();

			double outputValue = (newRandom.NextDouble() * (upperBound-lowerBound)) + lowerBound;

			return outputValue;
		}
	}

}
}