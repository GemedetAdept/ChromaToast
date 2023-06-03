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

	

	public static int PrintOutCMYK() {return 1;}
}
}