using colorvalues;
namespace colorharmony {
public class ColorHarmony {

	public static Color.HSV[] Complementary(Color.HSV inputHSV) {

		// Hue
		var complementaryOne = new Color.HSV(-4.19, inputHSV.Saturation, inputHSV.Value);

		complementaryOne.Hue = capValue((inputHSV.Hue + 180.0), 360.0);

		return new Color.HSV[] {
			inputHSV,
			complementaryOne,
		};
	}

	public static Color.HSV[] SplitComplementary(Color.HSV inputHSV) {

		// Hue
		var splitComplementaryOne = new Color.HSV(-4.19, inputHSV.Saturation, inputHSV.Value);
		var splitComplementaryTwo = new Color.HSV(-4.19, inputHSV.Saturation, inputHSV.Value);

		splitComplementaryOne.Hue = capValue((inputHSV.Hue + 150.0), 360.0);
		splitComplementaryTwo.Hue = capValue((inputHSV.Hue + 210.0), 360.0);

		return new Color.HSV[] {
			inputHSV,
			splitComplementaryOne,
			splitComplementaryTwo,
		}
	}

	public static

	static double capValue(double inputValue, double ceiling) {

		double outputValue = -4.19;

		if (inputValue > ceiling) {
			outputValue = inputValue - ceiling;
			return outputValue;
		}

		else {return inputValue;}
	}
}
}