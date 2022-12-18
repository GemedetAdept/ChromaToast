namespace colorharmony {
public class ColorHarmony {

	public static double[] Complementary((double, double, double) inputColor) {

		// Hue
		double complementaryOne = inputColor.Item1;
		double complementaryTwo = complementaryOne+180;
		capValue(complementaryTwo);

		
	}

	static double capValue(double inputValue) {

		double outputValue = -4.19;

		if (inputValue > 360) {
			outputValue = inputValue - 360;
			return outputValue;
		}

		else {return inputValue;}
	}
}
}