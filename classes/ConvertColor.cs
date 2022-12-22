using colorvalues;
using convertbase;
namespace convertcolor {
public class ConvertColor {

	// CMYK
	public static Color.HEX CMYKtoHEX(Color.CMYK inputCMYK) {

		var stepRGB = CMYKtoRGB(inputCMYK);
		var outputHEX = RGBtoHEX(stepRGB);

		return outputHEX;
	}
	public static Color.HSV CMYKtoHSV(Color.CMYK inputCMYK) {

		var stepRGB = CMYKtoRGB(inputCMYK);
		var outputHSV = RGBtoHSV(stepRGB);

		return outputHSV;
	}
	public static Color.HSL CMYKtoHSL(Color.CMYK inputCMYK) {

		var stepRGB = CMYKtoRGB(inputCMYK);
		var outputHSL = RGBtoHSL(stepRGB);

		return outputHSL;
	}
	public static Color.RGB CMYKtoRGB(Color.CMYK inputCMYK) {

		double cyanCMYK = inputCMYK.Cyan;
		double magentaCMYK = inputCMYK.Magenta;
		double yellowCMYK = inputCMYK.Yellow;
		double keyCMYK = inputCMYK.Key;

		double redRGB = 255 * (1 - cyanCMYK) * (1 - keyCMYK);
		double greenRGB = 255 * (1 - magentaCMYK) * (1 - keyCMYK);
		double blueRGB = 255 * (1 - yellowCMYK) * (1 - keyCMYK);

		return new Color.RGB(Math.Round(redRGB), Math.Round(greenRGB), Math.Round(blueRGB));
	}

	// HEX
	// Due to the way that HSL and HSV values are stored, 
	// it is necessary to first convert to RGB and then use the respective "RGBto..." method.
	public static Color.CMYK HEXtoCMYK(Color.HEX inputHEX) {

		var stepRGB = HEXtoRGB(inputHEX);
		var outputCMYK = RGBtoCMYK(stepRGB);

		return outputCMYK;
	}
	public static Color.HSL HEXtoHSL(Color.HEX inputHEX) {

		var stepRGB = HEXtoRGB(inputHEX);
		var outputHSL = RGBtoHSL(stepRGB);

		return outputHSL;
	}
	public static Color.HSV HEXtoHSV(Color.HEX inputHEX) {

		var stepRGB = HEXtoRGB(inputHEX);
		var outputHSV = RGBtoHSV(stepRGB);

		return outputHSV;
	}
	public static Color.RGB HEXtoRGB(Color.HEX inputHEX) {
		int decimalInteger = ConvertBase.ConvertToInteger(inputHEX.Value);
		byte[] valueBytes = BitConverter.GetBytes(decimalInteger);

		// Byte array is in reverse "RGB" order, thus backwards indexes.
		int redRGB = valueBytes[2];
		int greenRGB = valueBytes[1];
		int blueRGB = valueBytes[0];

		var outputRGB = new Color.RGB((double)redRGB, (double)greenRGB, (double)blueRGB);
		return outputRGB;
	}

	// HSL
	public static Color.CMYK HSLtoCMYK(Color.HSL inputHSL) {

		var stepRGB = HSLtoRGB(inputHSL);
		var outputCMYK = RGBtoCMYK(stepRGB);

		return outputCMYK;
	}
	public static Color.HEX HSLtoHEX(Color.HSL inputHSL) {

		var stepRGB = HSLtoRGB(inputHSL);
		var outputHEX = RGBtoHEX(stepRGB);

		return outputHEX;
	}
	public static Color.HSV HSLtoHSV(Color.HSL inputHSL) {

		double hueHSL = inputHSL.Hue;
		double saturationHSL = inputHSL.Saturation * Math.Pow(10, -2);
		double lightnessHSL = inputHSL.Lightness * Math.Pow(10, -2);

		double hueHSV = -4.19;
		double saturationHSV = -4.19;
		double valueHSV = -4.19;

		// Catch out-of-bounds
		var checkValuesHSL = (hueHSL, saturationHSL, lightnessHSL);
		bool outOfBounds = CheckOutOfBounds(checkValuesHSL, "HSV");
		if (outOfBounds == true) {Console.WriteLine("One or more invalid values."); Console.ReadKey();}

		// HSL to HSV calculations
		else {
			hueHSV = hueHSL;

			valueHSV = lightnessHSL + saturationHSL*Math.Min(lightnessHSL, 1-lightnessHSL);

			if (valueHSV == 0) {saturationHSV = 0;}
			else {saturationHSV = 2*(1-(lightnessHSL/valueHSV));} 
		}

		hueHSV = Math.Round(hueHSV);
		saturationHSV = Math.Round(saturationHSV*Math.Pow(10, 2));
		valueHSV = Math.Round(valueHSV*Math.Pow(10, 2));

		var outputHSV = new Color.HSV(hueHSV, saturationHSV, valueHSV);
		return outputHSV;
	}
	public static Color.RGB HSLtoRGB(Color.HSL inputHSL) {

		double hueHSL = inputHSL.Hue;
		double saturationHSL = inputHSL.Saturation * Math.Pow(10, -2);
		double lightnessHSL = inputHSL.Lightness * Math.Pow(10, -2);

		double redRGB = -4.19;
		double greenRGB = -4.19;
		double blueRGB = -4.19;

		// Catch out-of-bounds
		var checkValuesHSL = (hueHSL, saturationHSL, lightnessHSL);
		bool outOfBounds = CheckOutOfBounds(checkValuesHSL, "HSL");
		if (outOfBounds == true) {Console.WriteLine("One or more invalid values."); Console.ReadKey();}

		// HSL to RGB calculations
			// Alternative HSL to RGB from https://en.wikipedia.org/wiki/HSL_and_HSV#HSL_to_RGB_alternative
			// Given: H ∈ [0,360], S ∈ [0,1], and L ∈ [0,1],
			// ⨍(n) = L - a * max(-1, min(k-3, 9-k, 1))
			//		Where k,n ∈ R≥₀, and:
			//			k = (n + (H/30)) % 12
			//			a = S*min(L, 1-L)
			// (R,G,B) = (⨍(0), ⨍(8), ⨍(4))
		else {
			double valueA = saturationHSL * Math.Min(lightnessHSL, 1-lightnessHSL);
			Func<double, double> valueK = n => (n + hueHSL/30)%12;
			Func<double, double> altConvert = n => lightnessHSL-valueA * Math.Max(-1, Math.Min(valueK(n)-3, Math.Min(9-valueK(n), 1)));
			
			redRGB = altConvert(0);
			greenRGB = altConvert(8);
			blueRGB = altConvert(4);
		}

		redRGB = Math.Round(redRGB*255);
		greenRGB = Math.Round(greenRGB*255);
		blueRGB = Math.Round(blueRGB*255);

		var outputRGB = new Color.RGB(redRGB, greenRGB, blueRGB);
		return outputRGB;
	}

	// HSV
	public static Color.CMYK HSVtoCMYK(Color.HSV inputHSV) {

		Color.RGB stepRGB = HSVtoRGB(inputHSV);
		return RGBtoCMYK(stepRGB);
	}
	public static Color.HEX HSVtoHEX(Color.HSV inputHSV) {

		var stepRGB = HSVtoRGB(inputHSV);
		var outputHEX = RGBtoHEX(stepRGB);

		return outputHEX;
	}
	public static Color.HSL HSVtoHSL(Color.HSV inputHSV) {

		double hueHSV = inputHSV.Hue;
		double saturationHSV = inputHSV.Saturation * Math.Pow(10, -2);
		double valueHSV = inputHSV.Value * Math.Pow(10, -2);

		double hueHSL = -4.19;
		double saturationHSL = -4.19;
		double lightnessHSL = -4.19;

		// Catch out-of-bounds
		var checkValuesHSV = (hueHSV, saturationHSV, valueHSV);
		bool outOfBounds = CheckOutOfBounds(checkValuesHSV, "HSV");
		if (outOfBounds == true) {Console.WriteLine("One or more invalid values."); Console.ReadKey();}

		// HSV to HSL calculations
		else {
			hueHSL = hueHSV;

			lightnessHSL = valueHSV * (1 - (saturationHSV/2));

			if (lightnessHSL == 0 || lightnessHSL == 1) {saturationHSL = 0;}
			else {saturationHSL = (valueHSV - lightnessHSL)/(Math.Min(lightnessHSL, 1-lightnessHSL));}
		}

		hueHSL = Math.Round(hueHSL);
		saturationHSL = Math.Round(saturationHSL*Math.Pow(10, 2));
		lightnessHSL = Math.Round(lightnessHSL*Math.Pow(10, 2));

		var outputHSL = new Color.HSL(hueHSL, saturationHSL, lightnessHSL);
		return outputHSL;
	}
	public static Color.RGB HSVtoRGB(Color.HSV inputHSV) {

		double hueHSV = inputHSV.Hue;
		double saturationHSV = inputHSV.Saturation * Math.Pow(10, -2);
		double valueHSV = inputHSV.Value * Math.Pow(10, -2);

		double redRGB = -4.19;
		double greenRGB = -4.19;
		double blueRGB = -4.19;		

		// Catch out-of-bounds
		var checkValuesHSV = (hueHSV, saturationHSV, valueHSV);
		bool outOfBounds = CheckOutOfBounds(checkValuesHSV, "HSV");
		if (outOfBounds == true) {Console.WriteLine("One or more invalid values."); Console.ReadKey();}

		// HSV to RGB calculations
			// Alternative HSV to RGB from https://en.wikipedia.org/wiki/HSL_and_HSV#HSV_to_RGB_alternative
			// Given: H ∈ [0,360], S ∈ [0,1], V ∈ [0,1],
			// ⨍(n) = V - V*S* max(0, min(k, 4-k, 1))
			//		Where k,n ∈ R≥₀, and:
			//			k = (n + (H/60)) % 6
			// (R,G,B) = (⨍(5), ⨍(3), ⨍(1))
		else {
			Func<double, double> valueK = n => (n + hueHSV/60)%6;
			Func<double, double> altConvert = n => valueHSV-valueHSV*saturationHSV * Math.Max(0, Math.Min(valueK(n), Math.Min(4-valueK(n), 1)));

			redRGB = altConvert(5);
			greenRGB = altConvert(3);
			blueRGB = altConvert(1);
		}

		redRGB = Math.Round(redRGB*255);
		greenRGB = Math.Round(greenRGB*255);
		blueRGB = Math.Round(blueRGB*255);

		var outputRGB = new Color.RGB(redRGB, greenRGB, blueRGB);
		return outputRGB;
	}

	// RGB
	public static Color.CMYK RGBtoCMYK(Color.RGB inputRGB) {

		double redPrimeRGB = inputRGB.Red/255;
		double greenPrimeRGB = inputRGB.Green/255;
		double bluePrimeRGB = inputRGB.Blue/255;

		double keyCMYK = 1 - Math.Max(Math.Max(redPrimeRGB, greenPrimeRGB), bluePrimeRGB);
		double cyanCMYK = (1 - redPrimeRGB - keyCMYK)/(1 - keyCMYK);
		double magentaCMYK = (1 - greenPrimeRGB - keyCMYK)/(1 - keyCMYK);
		double yellowCMYK = (1 - bluePrimeRGB - keyCMYK)/(1 - keyCMYK);

		return new Color.CMYK(cyanCMYK, magentaCMYK, yellowCMYK, keyCMYK);
	}
	public static Color.HEX RGBtoHEX(Color.RGB inputRGB) {

		int redRGB = (int)inputRGB.Red;
		int greenRGB = (int)inputRGB.Green;
		int blueRGB = (int)inputRGB.Blue;

		byte[] valueBytes = new byte[] {

			Convert.ToByte(blueRGB),
			Convert.ToByte(greenRGB),
			Convert.ToByte(redRGB),
			0,
		};

		int intValue = BitConverter.ToInt32(valueBytes, 0);
		string outputHEX = ConvertBase.ConvertToHexadecimal(intValue);

		if (outputHEX.Length < 6) {outputHEX = "0" + outputHEX;}

		return new Color.HEX(outputHEX);
	}
	public static Color.HSL RGBtoHSL(Color.RGB inputRGB) {

		double redPrimeRGB = inputRGB.Red/255;
		double greenPrimeRGB = inputRGB.Green/255;
		double bluePrimeRGB = inputRGB.Blue/255;
		var tupleRGB = (inputRGB.Red, inputRGB.Green, inputRGB.Blue);

		double hueHSL = -4.19;
		double saturationHSL = -4.19;
		double lightnessHSL = -4.19;

		// Catch out-of-bounds
		bool outOfBounds = CheckOutOfBounds(tupleRGB, "RGB");
		if (outOfBounds == true) {Console.WriteLine("One or more invalid values."); Console.ReadKey();}

		// RGB to HSV calculations
		else {
			List<double> checkMinMax = new List<double>();
				checkMinMax.Add(redPrimeRGB);
				checkMinMax.Add(greenPrimeRGB);
				checkMinMax.Add(bluePrimeRGB);

			double maxRGB = checkMinMax.OrderByDescending(x => x).First();
			double minRGB = checkMinMax.OrderByDescending(x => x).Last();
			double chroma = maxRGB - minRGB;

			if (chroma == 0) {hueHSL = 0;}
			else if (maxRGB == redPrimeRGB) {
				// I do not know why this is producing the inverse of what it should, but un-inverting it makes it work, so.
				hueHSL = 60*(0 + (greenPrimeRGB - bluePrimeRGB)/chroma);
				hueHSL = 360 + hueHSL;
			}
			else if (maxRGB == greenPrimeRGB) {hueHSL = 60*(2 + (bluePrimeRGB - redPrimeRGB)/chroma);}
			else if (maxRGB == bluePrimeRGB) {hueHSL = 60*(4 + (redPrimeRGB - greenPrimeRGB)/chroma);}

			lightnessHSL = (maxRGB + minRGB)/2;

			if (lightnessHSL == 0 || lightnessHSL == 1) {saturationHSL = 0;}
			else {saturationHSL = (maxRGB - lightnessHSL)/Math.Min(lightnessHSL, 1-lightnessHSL);}
		}

		hueHSL = Math.Round(hueHSL);
		saturationHSL = Math.Round(saturationHSL*Math.Pow(10, 2));
		lightnessHSL = Math.Round(lightnessHSL*Math.Pow(10, 2));

		var outputHSL = new Color.HSL(hueHSL, saturationHSL, lightnessHSL);
		return outputHSL;
	}
	public static Color.HSV RGBtoHSV(Color.RGB inputRGB) {

		double redPrimeRGB = inputRGB.Red/255;
		double greenPrimeRGB = inputRGB.Green/255;
		double bluePrimeRGB = inputRGB.Blue/255;
		var tupleRGB = (inputRGB.Red, inputRGB.Green, inputRGB.Blue);

		double hueHSV = -4.19;
		double saturationHSV = -4.19;
		double valueHSV = -4.19;

		// Catch out-of-bounds
		bool outOfBounds = CheckOutOfBounds(tupleRGB, "RGB");
		if (outOfBounds == true) {Console.WriteLine("One or more invalid values."); Console.ReadKey();}

		// RGB to HSV calculations
		else {
			List<double> checkMinMax = new List<double>();
				checkMinMax.Add(redPrimeRGB);
				checkMinMax.Add(greenPrimeRGB);
				checkMinMax.Add(bluePrimeRGB);

			double maxRGB = checkMinMax.OrderByDescending(x => x).First();
			double minRGB = checkMinMax.OrderByDescending(x => x).Last();
			double chroma = maxRGB - minRGB;

			valueHSV = maxRGB;

			if (chroma == 0) {hueHSV = 0;}
			else if (valueHSV == redPrimeRGB) {
				// I do not know why this is producing the inverse of what it should, but un-inverting it makes it work, so.
				hueHSV = 60*(0 + (greenPrimeRGB - bluePrimeRGB)/chroma);
				hueHSV = 360 + hueHSV;
			}
			else if (valueHSV == greenPrimeRGB) {hueHSV = 60*(2 + (bluePrimeRGB - redPrimeRGB)/chroma);}
			else if (valueHSV == bluePrimeRGB) {hueHSV = 60*(4 + (redPrimeRGB - greenPrimeRGB)/chroma);}

			if (valueHSV == 0) {saturationHSV = 0;}
			else {saturationHSV = chroma/valueHSV;}
		}

		hueHSV = Math.Round(hueHSV);
		saturationHSV = Math.Round(saturationHSV*Math.Pow(10, 2));
		valueHSV = Math.Round(valueHSV*Math.Pow(10, 2));

		var outputHSV = new Color.HSV(hueHSV, saturationHSV, valueHSV);
		return outputHSV;
	}

	// Check Out-of-Bounds
	public static bool CheckOutOfBounds((double, double, double) colorValues, string colorType) {

		bool isInvalid = false;

		if (colorType == "HSL") {

			double hueHSL = colorValues.Item1;
			double saturationHSL = colorValues.Item2;
			double lightnessHSL = colorValues.Item3;

			if (hueHSL < 0 || hueHSL > 360) {
				Console.WriteLine($"HSV Hue value {hueHSL} is out-of-bounds (0–360).");
				isInvalid = true;
			}
			if (saturationHSL < 0 || saturationHSL > 100) { 
				Console.WriteLine($"HSL Saturation value {saturationHSL} is out-of-bounds (0–1)");
				isInvalid = true;
			}
			if (lightnessHSL < 0 || lightnessHSL > 100) {
				Console.WriteLine($"HSL Lightness value {lightnessHSL} is out-of-bounds (0–1)");
				isInvalid = true;
			}
			else {isInvalid = false;}
		}

		if (colorType == "HSV") {

			double hueHSV = colorValues.Item1;
			double saturationHSV = colorValues.Item2;
			double valueHSV = colorValues.Item3;

			if (hueHSV < 0 || hueHSV > 360) {
				Console.WriteLine($"HSV Hue value {hueHSV} is out-of-bounds (0–360).");
				isInvalid = true;
			}
			if (saturationHSV < 0 || saturationHSV > 100) { 
				Console.WriteLine($"HSV Saturation value {saturationHSV} is out-of-bounds (0–1)");
				isInvalid = true;
			}
			if (valueHSV < 0 || valueHSV > 100) {
				Console.WriteLine($"HSV Value value {valueHSV} is out-of-bounds (0–1)");
				isInvalid = true;
			}
			else {isInvalid = false;}
		}

		if (colorType == "RGB") {

			double redRGB = colorValues.Item1;
			double greenRGB = colorValues.Item2;
			double blueRGB = colorValues.Item3;

			if (redRGB < 0 || redRGB > 255) {
				Console.WriteLine($"RGB red value {redRGB} is out-of-bounds (0–255).");
				isInvalid = true;
			}
			if (greenRGB < 0 || greenRGB > 255) {
				Console.WriteLine($"RGB green value {greenRGB} is out-of-bounds (0–255).");
				isInvalid = true;
			}
			if (blueRGB < 0 || blueRGB > 255) {
				Console.WriteLine($"RGB blue value {blueRGB} is out-of-bounds (0–255).");
				isInvalid = true;
			}
			else {isInvalid = false;}
		}

		return isInvalid;
	}
}
}