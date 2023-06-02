using colorvalues;
using colorharmony;
using convertcolor;
namespace generation {
public class GenerationDriver {
	
	public class HarmonyBase {
		private Color.CMYK[] _paletteCMYK;
		private Color.HEX[] _paletteHEX;
		private Color.HSL[] _paletteHSL;
		private Color.HSV[] _paletteHSV;
		private Color.RGB[] _paletteRGB;

	}

	public static Color.CMYK[] GenerateCMYK(Color.HSV[] paletteHSV) {
		int elementCount = paletteHSV.Length;
		Color.CMYK[] paletteCMYK = new Color.CMYK[elementCount];

		for (int i = 0; i < elementCount; i++) {
			paletteCMYK[i] = ConvertColor.HSVtoCMYK(paletteHSV[i]);
		}

		return paletteCMYK;
	}
	public static Color.HEX[] GenerateHEX(Color.HSV[] paletteHSV) {
		int elementCount = paletteHSV.Length;
		Color.HEX[] paletteHEX = new Color.HEX[elementCount];

		for (int i = 0; i < elementCount; i++) {
			paletteHEX[i] = ConvertColor.HSVtoHEX(paletteHSV[i]);
		}

		return paletteHEX;
	}
	public static Color.HSL[] GenerateHSL(Color.HSV[] paletteHSV) {
		int elementCount = paletteHSV.Length;
		Color.HSL[] paletteHSL = new Color.HSL[elementCount];

		for (int i = 0; i < elementCount; i++) {
			paletteHSL[i] = ConvertColor.HSVtoHSL(paletteHSV[i]);
		}

		return paletteHSL;
	}
	public static Color.RGB[] GenerateRGB(Color.HSV[] paletteHSV) {
		int elementCount = paletteHSV.Length;
		Color.RGB[] paletteRGB = new Color.RGB[elementCount];

		for (int i = 0; i < elementCount; i++) {
			paletteRGB[i] = ConvertColor.HSVtoRGB(paletteHSV[i]);
		}

		return paletteRGB;
	}

	// 'Complementary' Generators
	public class Complementary {

		private Color.HSV _baseHSV;
		private Color.HSV[] _paletteHSV;

		public Complementary(Color.HSV inputHSV) {
			BaseHSV = inputHSV;
			PaletteHSV = ColorHarmony.Complementary(BaseHSV);

			PaletteCMYK = GenerateCMYK(PaletteHSV);
		}

		public Color.HSV BaseHSV {get;set;}

		public Color.CMYK[] PaletteCMYK {get;set;}
		public Color.HEX[] PaletteHEX {get;set;}
		public Color.HSL[] PaletteHSL {get;set;}
		public Color.HSV[] PaletteHSV {get;set;}
		public Color.RGB[] PaletteRGB {get;set;}

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