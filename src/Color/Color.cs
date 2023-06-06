namespace colorvalues {
public class Color {

	public Color() {

	}

	public class CMYK {

		public string Type = "CMYK";
		public const int floorCMYK = 0;
		public const int ceilingCMYK = 100;
		public double Cyan {get;set;}
		public double Magenta {get;set;}
		public double Yellow {get;set;}
		public double Key {get;set;}

		public CMYK(double cyan, double magenta, double yellow, double key) {
			Cyan = cyan;
			Magenta = magenta;
			Yellow = yellow;
			Key = key;
		}
	}
	public class HEX {

		public string Type = "HEX";
		private string _value;
		public HEX(string? hexValue) {

			Value = hexValue;

			string outputHEX = "";
			foreach(char hexChar in Value) {

				int charPos = (int)hexChar;
				if (charPos >= 97 && charPos <=122) {
					char upperCaseChar = (char)charPos;
					outputHEX += (char)(charPos - 32);
				}
				else {outputHEX += hexChar;}
			}

			Value = outputHEX;

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

		public string Type = "HSL";
		public const int floorHue = 0;
		public const int ceilingHue = 360;
		public const int floorSL = 0;
		public const int ceilingSL = 100;
		public double Hue {get;set;}
		public double Saturation {get;set;}
		public double Lightness {get;set;}

		public HSL(double hueHSL, double saturationHSL, double lightnessHSL) {

			Hue = hueHSL;
			Saturation = saturationHSL;
			Lightness = lightnessHSL;
		}

	}
	public class HSV {

		public string Type = "HSV";
		public const int floorHue = 0;
		public const int ceilingHue = 360;
		public const int floorSV = 0;
		public const int ceilingSV = 100;
		public double Hue {get;set;}
		public double Saturation {get;set;}
		public double Value {get;set;}

		public HSV(double hueHSV, double saturationHSV, double valueHSV) {

			Hue = hueHSV;
			Saturation = saturationHSV;
			Value = valueHSV;
		}

	}
	public class RGB {

		public string Type = "RGB";
		public const int floorRGB = 0;
		public const int ceilingRGB = 255;
		public double Red {get;set;}
		public double Green {get;set;}
		public double Blue {get;set;}

		public RGB(double redRGB, double greenRGB, double blueRGB) {

			Red = redRGB;
			Green = greenRGB;
			Blue = blueRGB;
		}
		
	}
	}

	// Base colors in HEX codes
	public class BaseColor {

		public const string White = "FFFFFF";
		public const string Gray = "B5B5B5";
		public const string Grey = "666666";
		public const string Black = "000000";
		public const string Red = "FF0000";
		public const string Orange = "FF9500";
		public const string Yellow = "FFEB00";
		public const string Lime = "23FF00";
		public const string Green = "33AB20";
		public const string Cyan = "1F9189";
		public const string Blue = "0050FF";
		public const string Violet = "AF56E9";
		public const string Purple = "49089B";
		public const string Magneta = "9B0DA9";
	}
}