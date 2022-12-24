# namespace colorvalues
## class Color
```csharp
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
```
### obj Color()
```csharp
	public Color() {
		
	}
```

## class Color.CMYK
```csharp
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
```
### obj CMYK()
```csharp
public CMYK(double cyan, double magenta, double yellow, double key) {
	Cyan = cyan;
	Magenta = magenta;
	Yellow = yellow;
	Key = key;
}
```

<br></br>

### IsValid
Boolean affirming that value is either valid or invalid.
Setters check for out-of-bounds values for: Cyan, Magneta, Yellow, Key. 
#### Private field
```csharp
private bool _isValid;
```

#### Getters and Setters
```csharp
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
```
| Visibility | Type | Variable | Value | Range |
|------------|------|----------|-------|-------|
| public | bool | IsValid | | `true` / `false`|

<br></br>

### floorCMYK
Defines the minimum value for: Cyan, Magenta, Yellow, Key.
*Default = **0***
```csharp
public const int floorCMYK = 0;
```
| Visibility | Type | Variable | Value |
|------------|------|----------|-------|
| public | const, int | floorCMYK | 0.0 |

<br></br>

### CeilingCMYK
Defines the maximum value for: Cyan, Magnenta, Yellow, Key.
*Default = **100***
```csharp
public const int ceilingCMYK = 100;
```
| Visibility | Type | Variable | Value 
|------------|------|----------|-------
| public | const, int | ceilingCMYK | 100.0 |

<br></br>

### Cyan
Value of the Cyan component of a CMYK color code.
*Default range = **(0.0 - 100.0)***
#### Private field
```csharp
private double _cyan;
```
#### Getters and Setters
```csharp
public double Cyan {
	get {return _cyan;}
	set {_cyan = value;}
}
```
| Visibility | Type | Variable | Value | Range |
|------------|------|----------|-------|-------|
| public | double | Cyan | | 0.0 - 100.0 |

<br></br>

### Magnenta
Value of the Magenta component of a CMYK color code.
*Default range = **(0.0 - 100.0)***
#### Private field
```csharp
private double _magenta;
```
#### Getters and Setters
```csharp
public double Magenta {
	get {return _cyan;}
	set {_cyan = value;}
}
```
| Visibility | Type | Variable | Value | Range |
|------------|------|----------|-------|-------|
| public | double | Magenta | | 0.0 - 100.0 |

<br></br>

### Yellow
Value of the Yellow component of a CMYK color code.
*Default range = **(0.0 - 100.0)***
#### Private field
```csharp
private double _yellow;
```
#### Getters and Setters
```csharp
public double Yellow {
	get {return _cyan;}
	set {_cyan = value;}
}
```
| Visibility | Type | Variable | Value | Range |
|------------|------|----------|-------|-------|
| public | double | Yellow | | 0.0 - 100.0 |

<br></br>

### Key
Value of the Key component of a CMYK color code.
*Default range = **(0.0 - 100.0)***
#### Private field
```csharp
private double _key;
```
#### Getters and Setters
```csharp
public double Key {
	get {return _cyan;}
	set {_cyan = value;}
}
```
| Visibility | Type | Variable | Value | Range |
|------------|------|----------|-------|-------|
| public | double | Key | | 0.0 - 100.0 |

<br></br>
***


## class Color.HEX
```csharp
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
```
### obj HEX()
```csharp
public HEX(string? hexValue) {

	Value = hexValue;
}
```
### Value
String value representing a Hexadecimal color code.
*Default range = **("#000000" - "#FFFFFF")***
*Note: Pound symbols (#) are optional for input.*
#### Private field
```csharp
private string _value;
```
#### Getters and Setters
```csharp
public string Value {
	get {return _value;}
	set {
		if (value.Contains("#")) {_value = value.Substring(1);}
		else {_value = value;}
	}
}
```
| Visibility | Type | Variable | Value | Range |
|------------|------|----------|-------|-------|
| public | double | Value | | "#000000" - "#FFFFFF" |

<br></br>

<br></br>
***


## class Color.HSL
### obj HSL()
### IsValid
### floorHue
### ceilingHue
### floorSL
### ceilingSL
### Hue
### Saturation
### Lightness

<br></br>
***


## class Color.HSV
### obj HSV()
### IsValid
### floorHue
### ceilingHue
### floorSV
### ceilingSV
### Hue
### Saturation
### Value

<br></br>
***


## class Color.RGB
### obj RGB()
### IsValid
### floorRGB
### ceilingRGB
### Red
### Green
### Blue

<br></br>
***


## class Color.BaseColor

Color.BaseColor defines 14 default/base colors, each returning a set HEX color value.

```csharp
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
```
| Visibility | Type | Variable | Value |
|------------|------|----------|-------|
| public | const, string | White   | "FFFFFF" |
| public | const, string | Gray    | "B5B5B5" |
| public | const, string | Grey    | "666666" |
| public | const, string | Black   | "000000" |
| public | const, string | Red     | "FF0000" |
| public | const, string | Orange  | "FF9500" |
| public | const, string | Yellow  | "FFEB00" |
| public | const, string | Lime    | "23FF00" |
| public | const, string | Green   | "33AB20" |
| public | const, string | Cyan    | "1F9189" |
| public | const, string | Blue    | "0050FF" |
| public | const, string | Violet  | "AF56E9" |
| public | const, string | Purple  | "49089B" |
| public | const, string | Magneta | "9B0DA9" |