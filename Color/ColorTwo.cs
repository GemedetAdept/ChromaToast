namespace colorvalues {
public abstract class ColorTwo {
	public string Type = "";
}

public class CMYK : ColorTwo {

	private double _cyan;
	private double _magenta;
	private double _yellow;
	private double _key;

	public CMYK(double[] values) {
		Cyan = values[0];
		Magenta = values[1];
		Yellow = values[2];
		Key = values[3];
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
}