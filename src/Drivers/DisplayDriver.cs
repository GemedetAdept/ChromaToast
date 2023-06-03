using colorvalues;
namespace display {
public class Display {
	
	public Display() {

	}
}

public class SinglePalette : Display {
	public Color.CMYK[] CMYKArray {get;set;}
	public Color.HEX[] HEXArray {get;set;}
	public Color.HSL[] HSLArray {get;set;}
	public Color.HSV[] HSVArray {get;set;}
	public Color.RGB[] RGBArray {get;set;}

	public static int LoadCMYK(Color.CMYK[] inputCMYK) {
		CMYKArray = inputCMYK;
		return 1;
	}
	public static int LoadHEX(Color.HEX[] inputHEX) {
		HEXArray = inputHEX;
		return 1;
	}
	public static int LoadHSL(Color.HSL[] inputHSL) {
		HSLArray = inputHSL;
		return 1;
	}
	public static int LoadHSV(Color.HSV[] inputHSV) {
		HSVArray = inputHSV;
		return 1;
	}
	public static int LoadRGB(Color.RGB[] inputRGB) {
		RGBArray = inputRGB;
		return 1;
	}

	public static int PrintOutCMYK() {return 1;}
}
}