using colorvalues;
using colorharmony;
using convertcolor;
namespace generation {
public class GenerationDriver {

	public class HarmonyBase {
		private Color.HSV _baseHSV;
		public Color.HSV BaseHSV {get;set;}

		private Color.CMYK[] _paletteCMYK;
		private Color.HEX[] _paletteHEX;
		private Color.HSL[] _paletteHSL;
		private Color.HSV[] _paletteHSV;
		private Color.RGB[] _paletteRGB;

		public Color.CMYK[] PaletteCMYK {get;set;}
		public Color.HEX[] PaletteHEX {get;set;}
		public Color.HSL[] PaletteHSL {get;set;}
		public Color.HSV[] PaletteHSV {get;set;}
		public Color.RGB[] PaletteRGB {get;set;}

		public HarmonyBase() {
		}

		public int LoadInputHSV(Color.HSV inputHSV) {
			BaseHSV = inputHSV;
			return 1;
		}

		public int LoadPalettes() {

			PaletteCMYK = GenerateCMYK(PaletteHSV);
			PaletteHEX = GenerateHEX(PaletteHSV);
			PaletteHSL = GenerateHSL(PaletteHSV);
			PaletteRGB = GenerateRGB(PaletteHSV);

			return 1;
		}

		public int Complementary() {
			PaletteHSV = ColorHarmony.Complementary(BaseHSV);

			LoadPalettes();
			return 1;
		}
		public int SplitComplementary() {
			PaletteHSV = ColorHarmony.SplitComplementary(BaseHSV);

			LoadPalettes();
			return 1;
		}
		public int Triadic() {
			PaletteHSV = ColorHarmony.Triadic(BaseHSV);

			LoadPalettes();
			return 1;
		}
		public int Tetradic() {
			PaletteHSV = ColorHarmony.Tetradic(BaseHSV);

			LoadPalettes();
			return 1;
		}
		public int Square() {
			PaletteHSV = ColorHarmony.Square(BaseHSV);

			LoadPalettes();
			return 1;
		}
		public int Analogous() {
			PaletteHSV = ColorHarmony.Analogous(BaseHSV);

			LoadPalettes();
			return 1;
		}
		public int Monochromatic() {
			PaletteHSV = ColorHarmony.Monochromatic(BaseHSV);

			LoadPalettes();
			return 1;
		}
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

}
}