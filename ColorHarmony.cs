using colorvalues;
namespace colorharmony {
public class ColorHarmony {

	public static Color.HSV[] Complementary(Color.HSV inputHSV) {

		// Hue
		var alphaComplementary = inputHSV;
		var betaComplementary = new Color.HSV(-4.19, inputHSV.Saturation, inputHSV.Value);

		betaComplementary.Hue = capValue((inputHSV.Hue + 180.0), 360.0);

		return new Color.HSV[] {
			alphaComplementary,
			betaComplementary,
		};
	}

	public static Color.HSV[] SplitComplementary(Color.HSV inputHSV) {

		// Hue
		var alphaSplitComplementary = inputHSV;
		var betaSplitComplementary = new Color.HSV(-4.19, inputHSV.Saturation, inputHSV.Value);
		var gammaSplitComplementary = new Color.HSV(-4.19, inputHSV.Saturation, inputHSV.Value);

		betaSplitComplementary.Hue = capValue((inputHSV.Hue + 150.0), 360.0);
		gammaSplitComplementary.Hue = capValue((inputHSV.Hue + 210.0), 360.0);

		return new Color.HSV[] {
			alphaSplitComplementary,
			betaSplitComplementary,
			gammaSplitComplementary,
		}
	}

	public static Color.HSV[] Triadic(Color.HSV inputHSV) {

		// Hue
		var alphaTriadic = inputHSV;
		var betaTriadic = new Color.HSV(-4.19, inputHSV.Saturation, inputHSV.Value);
		var gammaTriadic = new Color.HSV(-4.19, inputHSV.Saturation, inputHSV.Value);

		betaTriadic.Hue = capValue((inputHSV.Hue + 120.0), 360.0);
		gammaTriadic.Hue = capValue((inputHSV.Hue + 240.0), 360.0);

		return new Color.HSV[] {
			alphaTriadic,
			betaTriadic,
			gammaTriadic,
		}
	}

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