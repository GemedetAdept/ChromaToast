# class Color.HSL
```csharp
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
```
## obj HSL()
```csharp
public HSV(double hueHSV, double saturationHSV, double valueHSV) {

	Hue = hueHSV;
	Saturation = saturationHSV;
	Value = valueHSV;
}
```

## IsValid
Boolean affirming that value is either valid or invalid.
Setters check for out-of-bounds values for: Hue, Saturation, Lightness. 
### Private field
```csharp
private bool _isValid;
```
### Getters and Setters
```csharp
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
```
| Visibility | Type | Variable | Value | Range |
|------------|------|----------|-------|-------|
| public | bool | IsValid | | `true` / `false` |

<br></br>

## floorHue
Defines the minimum value for: Hue.
*Default = **0***
```csharp
public const int floorhue = 0;
```
| Visibility | Type | Variable | Value |
|------------|------|----------|-------|
| public | const, int | floorHue | 0.0 |

<br></br>

## ceilingHue
Defines the maximum value for: Cyan, Magnenta, Yellow, Key.
*Default = **100***
```csharp
public const int ceilingCMYK = 360;
```
| Visibility | Type | Variable | Value 
|------------|------|----------|-------
| public | const, int | ceilingHue | 360.0 |

<br></br>

## floorSL
Defines the minimum value for: Saturation, Lightness.
*Default = **0***
```csharp
public const int floorSL = 0;
```
| Visibility | Type | Variable | Value |
|------------|------|----------|-------|
| public | const, int | floorSL | 0.0 |

<br></br>

## ceilingSL
Defines the maximum value for: Saturation, Lightness.
*Default = **100***
```csharp
public const int ceilingSL = 100;
```
| Visibility | Type | Variable | Value 
|------------|------|----------|-------
| public | const, int | ceilingSL | 100.0 |

<br></br>

## Hue
Value of the Hue component of a HSL color code.
*Default range = **(0.0 - 100.0)***
### Private field
```csharp
private double _hue;
```
### Getters and Setters
```csharp
public double Hue {
	get {return _hue;}
	set {_hue = value;}
}
```
| Visibility | Type | Variable | Value | Range |
|------------|------|----------|-------|-------|
| public | double | Hue | | 0.0 - 360.0 |

<br></br>

## Saturation
Value of the Saturation component of a HSL color code.
*Default range = **(0.0 - 100.0)***
### Private field
```csharp
private double _saturation;
```
### Getters and Setters
```csharp
public double Saturation {
	get {return _saturation;}
	set {_saturation = value;}
}
```
| Visibility | Type | Variable | Value | Range |
|------------|------|----------|-------|-------|
| public | double | Saturation | | 0.0 - 100.0 |

<br></br>

## Lightness
Value of the Lightness component of a HSL color code.
*Default range = **(0.0 - 100.0)***
### Private field
```csharp
private double _lightness;
```
### Getters and Setters
```csharp
public double Lightness {
	get {return _lightness;}
	set {_lightness = value;}
}
```
| Visibility | Type | Variable | Value | Range |
|------------|------|----------|-------|-------|
| public | double | Lightness | | 0.0 - 100.0 |