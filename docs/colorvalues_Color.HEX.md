# class Color.HEX
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
## obj HEX()
```csharp
public HEX(string? hexValue) {

	Value = hexValue;
}
```
## Value
String value representing a Hexadecimal color code.
*Default range = **("#000000" - "#FFFFFF")***
*Note: Pound symbols (#) are optional for input.*
### Private field
```csharp
private string _value;
```
### Getters and Setters
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