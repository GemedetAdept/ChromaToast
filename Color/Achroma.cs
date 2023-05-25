using userinput;
using convertcolor;
namespace colorvalues {
public class Achroma {

	// Achroma, it's just a *representation* of a color.
	public Achroma(string inputType, string inputValue) {

		InputType = inputType;
		InputValue = inputValue;

		bool loadStatus = LoadInput(inputType, inputValue);
		if (loadStatus == false) {throw new System.Exception("ChromaToast| Achroma > Failed to load inputs.");}

		bool convertStatus = AutoConvertFill();
		if (convertStatus == false) {throw new System.Exception("ChromaToast| Achroma > Failed to load inputs.");}

	}

	public string InputType {get;}
	public string InputValue {get;}

	private Color.CMYK _cmyk;
	private Color.HEX _hex;
	private Color.HSL _hsl;
	private Color.HSV _hsv;
	private Color.RGB _rgb;

	public Color.CMYK CMYK {
		get {return _cmyk;}
		set {_cmyk = value;}
	}
	public Color.HEX HEX {
		get {return _hex;}
		set {_hex = value;}
	}
	public Color.HSL HSL {
		get {return _hsl;}
		set {_hsl = value;}
	}
	public Color.HSV HSV {
		get {return _hsv;}
		set {_hsv = value;}
	}
	public Color.RGB RGB {
		get {return _rgb;}
		set {_rgb = value;}
	}

	public bool LoadInput(string inputType, string inputValue) {

		if (inputValue.Contains("0x")) {inputValue = inputValue.Replace("0x", "");}
		if (inputValue.Contains("#")) {inputValue = inputValue.Replace("#", "");}
		if (inputValue.Contains("%")) {inputValue = inputValue.Replace("%", "");}
		if (inputValue.Contains("(")) {inputValue = inputValue.Replace("(", "");}
		if (inputValue.Contains(")")) {inputValue = inputValue.Replace(")", "");}
		if (inputValue.Contains(" ")) {inputValue = inputValue.Replace(" ", "");}

		var inputParts = inputValue.Split(",");

		var valueParts = inputParts.Select(x => Convert.ToDouble(x)).ToArray();

		switch(inputType) {
			case "CMYK":
				CMYK.Cyan = Validate("CMYK.Cyan", valueParts[0], 0.0, 100.0);
				CMYK.Magenta = Validate("CMYK.Magenta", valueParts[1], 0.0, 100.0);
				CMYK.Yellow = Validate("CMYK.Yellow", valueParts[2], 0.0, 100.0);
				CMYK.Key = Validate("CMYK.Key", valueParts[3], 0.0, 100.0);
				break;
			case "HEX":
				HEX.Value = inputParts;
				break;
			// case "HSL":
			// case "HSV":
			// case "RGB":
		}

		return true;

	}

	internal bool AutoConvertFill() {
		switch(InputType) {
			case "CMYK":
				HEX = ConvertColor.CMYKtoHEX(CMYK);
				HSL = ConvertColor.CMYKtoHSL(CMYK);
				HSV = ConvertColor.CMYKtoHSV(CMYK);
				RGB = ConvertColor.CMYKtoRGB(CMYK);
				return true;
				break;
			case "HEX":
				CMYK = ConvertColor.HEXtoCMYK(HEX);
				HSL = ConvertColor.HEXtoHSL(HEX);
				HSV = ConvertColor.HEXtoHSV(HEX);
				RGB = ConvertColor.HEXtoRGB(HEX);
				return true;
				break;
			case "HSL":
				CMYK = ConvertColor.HSLtoCMYK(HSL);
				HEX = ConvertColor.HSLtoHEX(HSL);
				HSV = ConvertColor.HSLtoHSV(HSL);
				RGB = ConvertColor.HSLtoRGB(HSL);
				return true;
				break;
			case "HSV":
				CMYK = ConvertColor.HSVtoCMYK(HSV);
				HEX = ConvertColor.HSVtoHEX(HSV);
				HSL = ConvertColor.HSVtoHSL(HSV);
				RGB = ConvertColor.HSVtoRGB(HSV);
				return true;
				break;
			case "RGB":
				CMYK = ConvertColor.RGBtoCMYK(RGB);
				HEX = ConvertColor.RGBtoHEX(RGB);
				HSL = ConvertColor.RGBtoHSL(RGB);
				HSV = ConvertColor.RGBtoHSV(RGB);
				return true;
				break;
			default:
				return false;
				break;
		}		
	}

	public double Validate(string code, double input, double floor, double ceiling) {

		if (input >= floor && input <= ceiling) {return input;}
		else if (input < floor) {
			Console.Write("ChromaToast > Achroma : ");
			Console.WriteLine($"{code}: [{input}] is below floor value {floor}. Setting value to {floor}.");
			return floor;
		}
		else if (input > ceiling) {
			Console.Write("ChromaToast > Achroma : ");
			Console.WriteLine($"{code}: [{input}] is above ceiling value {ceiling}. Setting value to {ceiling}.");
			return ceiling;
		}

		else {return -419;}
	}

	public string ValidateHex(string code, string input, string floor, string ceiling) {

		int floorInt = Convert.ToInt32(floor);
		int ceilingInt = Convert.ToInt32(ceiling);

		string outputString = "";
		foreach(char hex in input) {

			int hexInt = Convert.ToInt32(hex);
			if (hexInt >= floorInt && hexInt <= ceilingInt) {
				outputString += hex;
			}
			else if (hexInt < floorInt) {
				outputString += floor;
				Console.Write("ChromaToast > Achroma : ");
				Console.WriteLine($"{code}: [{hex}] is below floor value {floor}. Setting value to {floor}.");
			}
			else if (hexInt > ceilingInt) {
				outputString += ceiling;
				Console.Write("ChromaToast > Achroma : ");
				Console.WriteLine($"{code}: [{hex}] is above ceiling value {ceiling}. Setting value to {ceiling}.");
			}
		}

		return outputString;
	}

}
}
