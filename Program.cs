// ChromaToast by Vivian (Pluto) Zitek
// https://github.com/GemedetAdept
using userinput;
using menudriver;
using colorvalues;
using colorharmony;
using convertcolor;
using savetofile;

using tests;

using System.Text;

var paletteCMYK = new List<Color.CMYK>();
var paletteHEX = new List<Color.HEX>();
var paletteHSL = new List<Color.HSL>();
var paletteHSV = new List<Color.HSV>();
var paletteRGB = new List<Color.RGB>();

// Main Menu
MenuDriver mainMenu = new MenuDriver();
	string[] mainMenuOptions = new string[] {

		"Generate New Color Palette",
		"Quit Program",
		"", // Feature testing & Debugging
	};
	mainMenu.AddOptions(mainMenuOptions);

	void MainMenu() {
		while (mainMenu.menuLoop){

			Console.Clear();
			mainMenu.DisplayMenu();
			mainMenu.SetMenuCursor();

			switch(mainMenu.selectedItem) {

				case 0:
					generationDriver();
					displayPalette();
					break;
				case 1: 
					Console.Clear();
					Environment.Exit(0);
					break;
				case 2:
					DebugBox();
					break;
				default:
					break;
			}
		}
	}

// Color Input Menu
MenuDriver inputMenu = new MenuDriver();
	string[] inputMenuOptions = new string[] {

		"CMYK",
		"Hexadecimal",
		"HSL",
		"HSV",
		"RGB",
		"Default Colors",
		"Quit Program",
	};
	inputMenu.AddOptions(inputMenuOptions);

	string userColorInput = "Gemedet";
	var normalizedInput = new Color.HSV(1.0, 0.0, 0.0);
	Color.HSV InputMenu() {
		while (inputMenu.menuLoop){

			Console.Clear();
			inputMenu.DisplayMenu();
			inputMenu.SetMenuCursor();

			switch(inputMenu.selectedItem) {

				case 0:
					userColorInput = UserInput.Query("Enter a value between (0.0, 0.0, 0.0, 0.0) - (100.0, 100.0, 100.0, 100.0");
					var inputCMYK = UserInput.InputCMYK(userColorInput);

					normalizedInput = ConvertColor.CMYKtoHSV(inputCMYK); 
					return normalizedInput;
					break;
				case 1:
					userColorInput = UserInput.Query("Enter a value between #000000 - #FFFFFF");
					var inputHEX = UserInput.InputHEX(userColorInput);

					normalizedInput = ConvertColor.HEXtoHSV(inputHEX); 
					return normalizedInput;
					break;
				case 2:
					userColorInput = UserInput.Query("Enter a value between (0.0, 0.0, 0.0) - (360.0, 100.0, 100.0)");
					var inputHSL = UserInput.InputHSL(userColorInput);

					normalizedInput = ConvertColor.HSLtoHSV(inputHSL); 
					return normalizedInput;
					break;
				case 3:
					userColorInput = UserInput.Query("Enter a value between (0.0, 0.0, 0.0) - (360.0, 100.0, 100.0)");
					var inputHSV = UserInput.InputHSV(userColorInput);
					return inputHSV;
					break;
				case 4:
					userColorInput = UserInput.Query("Enter a value between (0, 0, 0) - (255, 255, 255)");
					var inputRGB = UserInput.InputRGB(userColorInput);

					normalizedInput = ConvertColor.RGBtoHSV(inputRGB); 
					return normalizedInput;
					break;
				case 5:
					var baseColorHEX = BaseColorMenu();
					normalizedInput = ConvertColor.HEXtoHSV(baseColorHEX);
					return normalizedInput;
					break;
				case 6: 
					Console.Clear();
					Environment.Exit(0);
					return null;
					break;
				default:
					break;
					return null;
			}
		}
		return null;
	}

MenuDriver baseColorMenu = new MenuDriver();
	string[] baseColorMenuOptions = new string[] {
		"White",
		"Gray",
		"Grey",
		"Black",
		"Red",
		"Orange",
		"Yellow",
		"Lime",
		"Green",
		"Cyan",
		"Blue",
		"Violet",
		"Purple",
		"Magneta",
	};
	baseColorMenu.AddOptions(baseColorMenuOptions);

	Color.HEX BaseColorMenu() {
		while (baseColorMenu.menuLoop) {

			Console.Clear();
			baseColorMenu.DisplayMenu();
			baseColorMenu.SetMenuCursor();

			switch(baseColorMenu.selectedItem) {

				case 0:
					return new Color.HEX(BaseColor.White);
					break;
				case 1:
					return new Color.HEX(BaseColor.White);
					break;
				case 2:
					return new Color.HEX(BaseColor.Gray);
					break;
				case 3:
					return new Color.HEX(BaseColor.Grey);
					break;
				case 4:
					return new Color.HEX(BaseColor.Black);
					break;
				case 5:
					return new Color.HEX(BaseColor.Red);
					break;
				case 6:
					return new Color.HEX(BaseColor.Orange);
					break;
				case 7:
					return new Color.HEX(BaseColor.Yellow);
					break;
				case 8:
					return new Color.HEX(BaseColor.Lime);
					break;
				case 9:
					return new Color.HEX(BaseColor.Green);
					break;
				case 10:
					return new Color.HEX(BaseColor.Cyan);
					break;
				case 11:
					return new Color.HEX(BaseColor.Blue);
					break;
				case 12:
					return new Color.HEX(BaseColor.Violet);
					break;
				case 13:
					return new Color.HEX(BaseColor.Purple);
					break;
				case 14:
					return new Color.HEX(BaseColor.Magneta);
					break;
				default:
					break;
			}
		}
		return new Color.HEX("");
	}

// Color Harmony Menu
MenuDriver harmonyMenu = new MenuDriver();
	string[] harmonyMenuOptions = new string[] {
		"Complementary",
		"Split Complementary",
		"Triadic",
		"Tetradic",
		"Square",
		"Analogous",
		"Monochromatic",
	};
	harmonyMenu.AddOptions(harmonyMenuOptions);

	List<Color.HSV> outputPaletteHSV = new List<Color.HSV>();
	List<Color.HSV> HarmonyMenu(Color.HSV inputHSV) {
		while (harmonyMenu.menuLoop) {

			Console.Clear();
			harmonyMenu.DisplayMenu();
			harmonyMenu.SetMenuCursor();

			switch(harmonyMenu.selectedItem) {

				case 0:
					outputPaletteHSV = ColorHarmony.Complementary(inputHSV).ToList();
					return outputPaletteHSV;
					break;
				case 1: 
					outputPaletteHSV = ColorHarmony.SplitComplementary(inputHSV).ToList();
					return outputPaletteHSV;
					break;
				case 2: 
					outputPaletteHSV = ColorHarmony.Triadic(inputHSV).ToList();
					return outputPaletteHSV;
					break;
				case 3: 
					outputPaletteHSV = ColorHarmony.Tetradic(inputHSV).ToList();
					return outputPaletteHSV;
					break;
				case 4: 
					outputPaletteHSV = ColorHarmony.Square(inputHSV).ToList();
					return outputPaletteHSV;
					break;
				case 5: 
					outputPaletteHSV = ColorHarmony.Analogous(inputHSV).ToList();
					return outputPaletteHSV;
					break;
				case 6: 
					outputPaletteHSV = ColorHarmony.Monochromatic(inputHSV).ToList();
					return outputPaletteHSV;
					break;
				default:
					break;
					return null;
			}
		}
		return null;
	}

void generationDriver() {

	paletteCMYK.Clear();
	paletteHEX.Clear();
	paletteHSL.Clear();
	paletteHSV.Clear();
	paletteRGB.Clear();

	Color.HSV normalizedInputHSV = InputMenu();
	Console.WriteLine($"{normalizedInputHSV.Hue}, {normalizedInputHSV.Saturation}, {normalizedInputHSV.Value}");
	
	paletteHSV = HarmonyMenu(normalizedInputHSV);

	for (int i = 0; i <paletteHSV.Count; i++) {
		paletteCMYK.Add(ConvertColor.HSVtoCMYK(paletteHSV[i]));
	}
	for (int i = 0; i < paletteHSV.Count; i++) {
		paletteHEX.Add(ConvertColor.HSVtoHEX(paletteHSV[i]));
	}
	for (int i = 0; i < paletteHSV.Count; i++) {
		paletteHSL.Add(ConvertColor.HSVtoHSL(paletteHSV[i]));
	}
	for (int i = 0; i < paletteHSV.Count; i++) {
		paletteRGB.Add(ConvertColor.HSVtoRGB(paletteHSV[i]));
	}
}

void displayPalette() {

MenuDriver saveMenu = new MenuDriver();
	string[] saveMenuOptions = new string[] {
		"Yes",
		"No",
	};
	saveMenu.AddOptions(saveMenuOptions);

	void SaveMenu() {
		while (saveMenu.menuLoop) {

		Console.Clear();

		Console.WriteLine("+");
		Console.WriteLine("CMYK: ");
		foreach (Color.CMYK color in paletteCMYK) {Console.WriteLine($"({color.Cyan}, {color.Magenta}, {color.Yellow}, {color.Key})");}
		Console.WriteLine("");

		Console.WriteLine("HEX: ");
		foreach (Color.HEX color in paletteHEX) {Console.WriteLine($"#{color.Value}");}
		Console.WriteLine("");

		Console.WriteLine("HSL: ");
		foreach (Color.HSL color in paletteHSL) {Console.WriteLine($"({color.Hue}, {color.Saturation}, {color.Lightness})");}
		Console.WriteLine("");

		Console.WriteLine("HSV: ");
		foreach (Color.HSV color in paletteHSV) {Console.WriteLine($"({color.Hue}, {color.Saturation}, {color.Value})");}
		Console.WriteLine("");

		Console.WriteLine("RGB: ");
		foreach (Color.RGB color in paletteRGB) {Console.WriteLine($"({color.Red}, {color.Green}, {color.Blue})");}
		Console.WriteLine("");

		Console.WriteLine("Save generated color palette?");
		saveMenu.DisplayMenu();
		saveMenu.SetMenuCursor();

		switch(saveMenu.selectedItem) {

			case 0:
				string fullFileName = new SaveToFile.Timestamped("palette_").FullName;
				savePalette(fullFileName);
				saveMenu.menuLoop = false;
				break;
			case 1:
				saveMenu.menuLoop = false;
				break;
			default:
				break;
			}
		}
	}

	SaveMenu();
}

void savePalette(string fileName, string path = "") {

	string[] headers = new string[]{
		"CMYK",
		"HEX",
		"HSL",
		"HSV",
		"RGB",
		"\n"
	};

	var outputFile = new SaveToFile.CSV(fileName, path);
	if (outputFile.Initalize(outputFile.FileName)) {

		outputFile.SetHeaders(outputFile.FileName, headers);

		for (int i = 0; i < paletteHSV.Count; i++) {
			string[] colors = new string[6];
			colors[0] = "\"" + $"({paletteCMYK[i].Cyan}, {paletteCMYK[i].Magenta}, {paletteCMYK[i].Yellow}, {paletteCMYK[i].Key})" + "\"";
			colors[1] = paletteHEX[i].Value;
			colors[2] = "\"" + $"({paletteHSL[i].Hue}, {paletteHSL[i].Saturation}, {paletteHSL[i].Lightness})" + "\"";
			colors[3] = "\"" + $"({paletteHSV[i].Hue}, {paletteHSV[i].Saturation}, {paletteHSV[i].Value})" + "\"";
			colors[4] = "\"" + $"({paletteRGB[i].Red}, {paletteRGB[i].Green}, {paletteRGB[i].Blue})" + "\"";
			colors[5] = "\n";

			outputFile.WriteData(outputFile.FileName, colors);
		}
	}
}

void DebugBox() {

	Console.Clear();
	Color_Tests.Created_CMYK_HasValue_Cyan();
	Color_Tests.Created_CMYK_HasValue_Magenta();
	Color_Tests.Created_CMYK_HasValue_Yellow();
	Color_Tests.Created_CMYK_HasValue_Key();

}

// MainMenu();
DebugBox();