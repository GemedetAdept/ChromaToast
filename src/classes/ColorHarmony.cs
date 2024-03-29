using colorvalues;
using menudriver;
namespace colorharmony {
public class ColorHarmony {

	public static Color.HSV[] Complementary(Color.HSV inputHSV) {

		// Hue
		var alphaComplementary = inputHSV;
		var betaComplementary = new Color.HSV(-4.19, inputHSV.Saturation, inputHSV.Value);

		betaComplementary.Hue = capValue((inputHSV.Hue + 180.0), 360.0, 0.0);

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

		betaSplitComplementary.Hue = capValue((inputHSV.Hue + 150.0), 360.0, 0.0);
		gammaSplitComplementary.Hue = capValue((inputHSV.Hue + 210.0), 360.0, 0.0);

		return new Color.HSV[] {
			alphaSplitComplementary,
			betaSplitComplementary,
			gammaSplitComplementary,
		};
	}

	public static Color.HSV[] Triadic(Color.HSV inputHSV) {

		// Hue
		var alphaTriadic = inputHSV;
		var betaTriadic = new Color.HSV(-4.19, inputHSV.Saturation, inputHSV.Value);
		var gammaTriadic = new Color.HSV(-4.19, inputHSV.Saturation, inputHSV.Value);

		betaTriadic.Hue = capValue((inputHSV.Hue + 120.0), 360.0, 0.0);
		gammaTriadic.Hue = capValue((inputHSV.Hue + 240.0), 360.0, 0.0);

		return new Color.HSV[] {
			alphaTriadic,
			betaTriadic,
			gammaTriadic,
		};
	}

	public static Color.HSV[] Tetradic(Color.HSV inputHSV) {

		// Hue
		var alphaTetradic = inputHSV;
		var betaTetradic = new Color.HSV(-4.19, inputHSV.Saturation, inputHSV.Value);
		var gammaTetradic = new Color.HSV(-4.19, inputHSV.Saturation, inputHSV.Value);
		var deltaTetradic = new Color.HSV(-4.19, inputHSV.Saturation, inputHSV.Value);

		betaTetradic.Hue = capValue((inputHSV.Hue + 120.0), 360.0, 0.0);
		gammaTetradic.Hue = capValue((inputHSV.Hue + 180.0), 360.0, 0.0);
		deltaTetradic.Hue = capValue((inputHSV.Hue + 300.0), 360.0, 0.0);

		return new Color.HSV[] {
			alphaTetradic,
			betaTetradic,
			gammaTetradic,
			deltaTetradic,
		};
	}

	public static Color.HSV[] Square(Color.HSV inputHSV) {

		// Hue
		var alphaSquare = inputHSV;
		var betaSquare = new Color.HSV(-4.19, inputHSV.Saturation, inputHSV.Value);
		var gammaSquare = new Color.HSV(-4.19, inputHSV.Saturation, inputHSV.Value);
		var deltaSquare = new Color.HSV(-4.19, inputHSV.Saturation, inputHSV.Value);

		betaSquare.Hue = capValue((inputHSV.Hue + 90.0), 360.0, 0.0);
		gammaSquare.Hue = capValue((inputHSV.Hue + 180.0), 360.0, 0.0);
		deltaSquare.Hue = capValue((inputHSV.Hue + 270.0), 360.0, 0.0);

		return new Color.HSV[] {
			alphaSquare,
			betaSquare,
			gammaSquare,
			deltaSquare,
		};
	}

	public static Color.HSV[] Analogous(Color.HSV inputHSV) {

		// Hue
		var alphaAnalogous = inputHSV;
		var betaAnalogous = new Color.HSV(-4.19, inputHSV.Saturation, inputHSV.Value);
		var gammaAnalogous = new Color.HSV(-4.19, inputHSV.Saturation, inputHSV.Value);

		betaAnalogous.Hue = capValue((inputHSV.Hue + 30.0), 360.0, 0.0);
		gammaAnalogous.Hue = capValue((inputHSV.Hue + 330.0), 360.0, 0.0);

		return new Color.HSV[] {
			alphaAnalogous,
			betaAnalogous,
			gammaAnalogous,
		};
	}

	public static Color.HSV[] Monochromatic(Color.HSV inputHSV) {

		// Value
		var alphaMonochromatic = inputHSV;
		var betaMonochromatic = new Color.HSV(inputHSV.Hue, inputHSV.Saturation, -4.19);
		var gammaMonochromatic = new Color.HSV(inputHSV.Hue, inputHSV.Saturation, -4.19);
		var deltaMonochromatic = new Color.HSV(inputHSV.Hue, inputHSV.Saturation, -4.19);

		betaMonochromatic.Value = capValue((inputHSV.Value - 25.0), 100.0, 0.0);
		gammaMonochromatic.Value = capValue((inputHSV.Value + 15.0), 100.0, 0.0);
		deltaMonochromatic.Value = capValue((inputHSV.Value + 35.0), 100.0, 0.0);

		return new Color.HSV[] {
			alphaMonochromatic,
			betaMonochromatic,
			gammaMonochromatic,
			deltaMonochromatic,
		};

	}

	public static double capValue(double inputValue, double ceiling, double floor) {

		double outputValue = -4.19;

		if (inputValue > ceiling) {
			outputValue = inputValue - ceiling;
			return outputValue;
		}

		else if (inputValue < 0.0) {
			outputValue = inputValue + ceiling;
			return outputValue;
		}

		else {return inputValue;}
	}
}
}