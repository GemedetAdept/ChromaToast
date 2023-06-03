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

	public static int PrintOutCMYK() {return 1;}
}
}