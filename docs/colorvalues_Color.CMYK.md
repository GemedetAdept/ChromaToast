# class Color.CMYK
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
## obj CMYK()
```csharp
public CMYK(double cyan, double magenta, double yellow, double key) {
	Cyan = cyan;
	Magenta = magenta;
	Yellow = yellow;
	Key = key;
}
```

<br></br>

## IsValid
Boolean affirming that value is either valid or invalid.
Setters check for out-of-bounds values for: Cyan, Magneta, Yellow, Key. 
### Private field
```csharp
private bool _isValid;
```

### Getters and Setters
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

## floorCMYK
Defines the minimum value for: Cyan, Magenta, Yellow, Key.
*Default = **0***
```csharp
public const int floorCMYK = 0;
```
| Visibility | Type | Variable | Value |
|------------|------|----------|-------|
| public | const, int | floorCMYK | 0.0 |

<br></br>

## ceilingCMYK
Defines the maximum value for: Cyan, Magnenta, Yellow, Key.
*Default = **100***
```csharp
public const int ceilingCMYK = 100;
```
| Visibility | Type | Variable | Value 
|------------|------|----------|-------
| public | const, int | ceilingCMYK | 100.0 |

<br></br>

## Cyan
Value of the Cyan component of a CMYK color code.
*Default range = **(0.0 - 100.0)***
### Private field
```csharp
private double _cyan;
```
### Getters and Setters
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

## Magnenta
Value of the Magenta component of a CMYK color code.
*Default range = **(0.0 - 100.0)***
### Private field
```csharp
private double _magenta;
```
### Getters and Setters
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

## Yellow
Value of the Yellow component of a CMYK color code.
*Default range = **(0.0 - 100.0)***
### Private field
```csharp
private double _yellow;
```
### Getters and Setters
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

## Key
Value of the Key component of a CMYK color code.
*Default range = **(0.0 - 100.0)***
### Private field
```csharp
private double _key;
```
### Getters and Setters
```csharp
public double Key {
	get {return _cyan;}
	set {_cyan = value;}
}
```
| Visibility | Type | Variable | Value | Range |
|------------|------|----------|-------|-------|
| public | double | Key | | 0.0 - 100.0 |