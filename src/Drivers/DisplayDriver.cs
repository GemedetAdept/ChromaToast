using colorvalues;
namespace display {
public class Display {
	
	public Display() {

	}
}

public class SinglePalette : Display {

	public static string DisplayTitle = "~.,.~ Generated Palette ~.,.~";

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

	public static int PrintTitle() {
		Console.WriteLine($"{DisplayTitle}");
		Console.WriteLine("");
		return 1;
	}

	public static int PrintLine(string valueAlpha) {
		Console.WriteLine($"{valueAlpha}");
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

	public static int PrintAll() {
		Console.Clear();
		PrintTitle();

		PrintCMYK();
		PrintHEX();
		PrintHSL();
		PrintHSV();
		PrintRGB();

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
	public static int PrintHEX() {
		Console.WriteLine("HEX: ");

		for (int i=0; i < HEXArray.Length; i++) {
			var HEXElement = HEXArray[i];

			PrintLine(HEXElement.Value);
		}
		return 1;
	}
	public static int PrintHSL() {
		Console.WriteLine("HSL: ");

		for (int i=0; i < HSLArray.Length; i++) {
			var HSLElement = HSLArray[i];

			PrintLine(HSLElement.Hue, HSLElement.Saturation, HSLElement.Lightness);
		}
		return 1;
	}
	public static int PrintHSV() {
		Console.WriteLine("HSV: ");

		for (int i=0; i < HSVArray.Length; i++) {
			var HSVElement = HSVArray[i];

			PrintLine(HSVElement.Hue, HSVElement.Saturation, HSVElement.Value);
		}
		return 1;
	}
	public static int PrintRGB() {
		Console.WriteLine("RGB: ");

		for (int i=0; i < RGBArray.Length; i++) {
			var RGBElement = RGBArray[i];

			PrintLine(RGBElement.Red, RGBElement.Green, RGBElement.Blue);
		}
		return 1;
	}
}
}