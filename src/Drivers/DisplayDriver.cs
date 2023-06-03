using colorvalues;
namespace display {
public class Display {
	
	public Display() {

	}
}

public class SinglePalette : Display {
	public static Color.CMYK[] CMYKArray {get;set;}
	public static Color.HEX[] HEXArray {get;set;}
	public static Color.HSL[] HSLArray {get;set;}
	public static Color.HSV[] HSVArray {get;set;}
	public static Color.RGB[] RGBArray {get;set;}

	public static int LoadData(Color.CMYK[] inputCMYK) {
		CMYKArray = inputCMYK;
		return 1;
	}
	public static int LoadData(Color.HEX[] inputHEX) {
		HEXArray = inputHEX;
		return 1;
	}
	public static int LoadData(Color.HSL[] inputHSL) {
		HSLArray = inputHSL;
		return 1;
	}
	public static int LoadData(Color.HSV[] inputHSV) {
		HSVArray = inputHSV;
		return 1;
	}
	public static int LoadData(Color.RGB[] inputRGB) {
		RGBArray = inputRGB;
		return 1;
	}

	public static int PrintLine(double valueAlpha, double valueBeta, double valueGamma) {
		Console.WriteLine($"({valueAlpha}, {valueBeta}, {valueGamma})");
		return 1;
	}
	public static int PrintLine(double valueAlpha, double valueBeta, double valueGamma, double valueDelta) {
		Console.WriteLine($"({valueAlpha}, {valueBeta}, {valueGamma}, {valueDelta})");
		return 1;
	}

	public static int PrintCMYK() {
		Console.WriteLine("CMYK: ");

		for (int i=0; i < CMYKArray.Length; i++) {
			var CMYKElement = CMYKArray[i];

			PrintLine(CMYKElement.Cyan, CMYKElement.Magenta, CMYKElement.Yellow, CMYKElement.Key);
		}
		return 1;
	}
}
}