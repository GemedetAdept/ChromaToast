namespace colorvalues {
public class ValueDeviation {

	public class UniformBounded {

		private int _lowerBound;
		private int _upperBound;

		public UniformBounded(int lowerBound, int upperBound) {
			LowerBound = lowerBound;
			UpperBound = upperBound;
		}

		public int LowerBound {
			get {return _lowerBound;}
			set {_lowerBound = value;}
		}
		public int UpperBound {
			get {return _upperBound;}
			set {_upperBound = value;}
		}

		public int Next() {
			Random newRandom = new Random();
			int outputValue = newRandom.Next(LowerBound, UpperBound);

			return outputValue;
		}
	}

}
}