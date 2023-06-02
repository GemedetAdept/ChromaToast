using colorvalues;
using colorharmony;
using convertcolor;
namespace generation {
public class GenerationDriver {
	
	public Color.CMYK[] GenerateCMYK(Color.HSV[] paletteHSV) {
		int elementCount = paletteHSV.Length;
		Color.CMYK[] paletteCMYK = new Color.CMYK[elementCount];

		for (int i = 0; i < elementCount; i++) {
			paletteCMYK[i] = ConvertColor.HSVtoCMYK(paletteHSV[i]);
		}

		return paletteCMYK;
	}

	// 'Complementary' Generators
	public class Complementary {

		private Color.HSV _baseHSV;
		private Color.HSV[] _paletteHSV;

		public Complementary(Color.HSV inputHSV) {
			BaseHSV = inputHSV;
			PaletteHSV = ColorHarmony.Complementary(BaseHSV);
		}

		public Color.HSV BaseHSV {
			get {return _baseHSV;}
			set {_baseHSV = value;}
		}
		public Color.HSV[] PaletteHSV {
			get {return _paletteHSV;}
			set {_paletteHSV = value;}
		}

	}
	// 'Split Complementary' Generators
	public class SplitComplementary {
		public SplitComplementary() {}
	}
	// 'Triadic' Generators
	public class Triadic {
		public Triadic() {}
	}
	// 'Tetradic' Generators
	public class Tetradic {
		public Tetradic() {}
	}
	// 'Square' Generators
	public class Square {
		public Square() {}
	}
	// 'Analogous' Generators
	public class Analogous {
		public Analogous() {}
	}
	// 'Monochromatic' Generators
	public class Monochromatic {
		public Monochromatic() {}
	}
}
}