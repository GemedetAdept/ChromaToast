namespace colorvalues {
public class Color {

	public Color() {

	}

	public class CMYK {

		private bool _isValid;
		public const int floorCMYK = 0;
		public const int ceilingCMYK = 100;
		private double _cyan;
		private double _magenta;
		private double _yellow;
		private double _key;

		public CMYK(double cyan, double magenta, double yellow, double key) {
			Cyan = cyan;
			Magenta = magenta;
			Yellow = yellow;
			Key = key;
		}

		public bool IsValid {
			get {return _isValid;}
			set {
				if (Cyan < floorCMYK || Cyan > ceilingCMYK ||
					Magenta < floorCMYK || Magenta > ceilingCMYK ||
					Yellow < floorCMYK || Yellow > ceilingCMYK ||
					Key < floorCMYK || Key > ceilingCMYK) {

					_isValid = false;
				}
				else {_isValid = true;}
			}
		}
		public double Cyan {
			get {return _cyan;}
			set {_cyan = value;}
		}
		public double Magenta {
			get {return _magenta;}
			set {_magenta = value;}
		}
		public double Yellow {
			get {return _yellow;}
			set {_yellow = value;}
		}
		public double Key {
			get {return _key;}
			set {_key = value;}
		}
	}
	public class HEX {

		private string _value;
		public HEX(string? hexValue) {

			Value = hexValue;
		}

		public string Value {
			get {return _value;}
			set {
				if (value.Contains("#")) {_value = value.Substring(1);}
				else {_value = value;}
			}
		}
	}
	public class HSL {

		private bool _isValid;
		public const int floorHue = 0;
		public const int ceilingHue = 360;
		public const int floorSL = 0;
		public const int ceilingSL = 100;
		private double _hue;
		private double _saturation;
		private double _lightness;

		public HSL(double hueHSL, double saturationHSL, double lightnessHSL) {

			Hue = hueHSL;
			Saturation = saturationHSL;
			Lightness = lightnessHSL;
		}

		public bool IsValid {
			get {return _isValid;}
			set {
				if (Hue < floorHue || Hue > ceilingHue ||
					Saturation < floorSL || Saturation > ceilingSL ||
					Lightness < floorSL || Lightness > ceilingSL) {

					_isValid = false;
				}
				else {_isValid = true;}
			}
		}
		public double Hue {
			get {return _hue;}
			set {_hue = value;}
		}
		public double Saturation {
			get {return _saturation;}
			set {_saturation = value;}
		}
		public double Lightness {
			get {return _lightness;}
			set {_lightness = value;}
		}
	}
	public class HSV {

		private bool _isValid;
		public const int floorHue = 0;
		public const int ceilingHue = 360;
		public const int floorSV = 0;
		public const int ceilingSV = 100;
		private double _hue;
		private double _saturation;
		private double _value;

		public HSV(double hueHSV, double saturationHSV, double valueHSV) {

			Hue = hueHSV;
			Saturation = saturationHSV;
			Value = valueHSV;
		}

		public bool IsValid {
			get {return _isValid;}
			set {
				if (Hue < floorHue || Hue > ceilingHue ||
					Saturation < floorSV || Saturation > ceilingSV ||
					Value < floorSV || Value > ceilingSV) {

					_isValid = false;
				}
				else {_isValid = true;}
			}
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
	}
	public class RGB {

		private bool _isValid;
		public const int floorRGB = 0;
		public const int ceilingRGB = 255;
		private double _red;
		private double _green;
		private double _blue;

		public RGB(double redRGB, double greenRGB, double blueRGB) {

			Red = redRGB;
			Green = greenRGB;
			Blue = blueRGB;
		}

		public bool IsValid {
			get {return _isValid;}
			set {
				if (Red < floorRGB || Red > ceilingRGB ||
					Green < floorRGB || Green > ceilingRGB ||
					Blue < floorRGB || Blue > ceilingRGB) {

					_isValid = false;
				}
				else {_isValid = true;}
			}
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

	// Base colors in HEX codes
	public class BaseColor {

		const string White = "FFFFFF";
		const string Gray = "B5B5B5";
		const string Grey = "666666";
		const string Black = "000000";
		const string Red = "FF0000";
		const string Orange = "FF9500";
		const string Yellow = "FFEB00";
		const string Lime = "23FF00";
		const string Green = "33AB20";
		const string Cyan = "1F9189";
		const string Blue = "0050FF";
		const string Violet = "AF56E9";
		const string Purple = "49089B";
		const string Magneta = "9B0DA9";
	}
}