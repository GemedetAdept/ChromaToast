namespace colorvalue {
public class Color {

	private string _hexValue;
	private double _hue;
	private double _saturation;
	private double _value;
	private double _lightness;
	private double _red;
	private double _green;
	private double _blue;

	public HEX(string? hexValue) {

		HEXValue = hexValue;
	}

	public string HEXValue {
		get {return _hexValue;}
		set {
			if value.Contains("#") {_hexValue = value.Substring(1);}
			else {_hexValue = value;}
		}
	}

	public HSL(double hueHSL, double saturationHSL, double lightnessHSL) {

		Hue = hueHSL;
		Saturation = saturationHSL;
		Lightness = lightnessHSL;
	}

	public HSV(double hueHSV, double saturationHSV, double valueHSV) {

		Hue = hueHSV;
		Saturation = saturationHSV;
		Value = valueHSV;
	}

	public double Hue {
		get {return _hue;}
		set {_hue = value;}
	}
	public double Saturation {
		get {return _saturation;}
		set {_saturation = value;}
	}
	public double Value {
		get {return _value;}
		set {_value = value;}
	}
	public double Lightness {
		get {return _lightness;}
		set {_lightness = value;}
	}

	public RGB(double redRGB, double greenRGB, double blueRGB) {

		Red = redRGB;
		Green = greenRGB;
		Blue = blueRGB;
	}

	public double Red {
		get {return _red;}
		set {_red = value;}
	}
	public double Green {
		get {return _green;}
		set {_green = value;}
	}
	public double Blue {
		get {return _blue;}
		set {_blue = value;}
	}
}
}