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

MenuBetaDriver.RunMainMenu();
MenuBetaDriver.RunGenerationDriver();

// MenuDriver baseColorMenu = new MenuDriver();
// 	string[] baseColorMenuOptions = new string[] {
// 		"White",
// 		"Gray",
// 		"Grey",
// 		"Black",
// 		"Red",
// 		"Orange",
// 		"Yellow",
// 		"Lime",
// 		"Green",
// 		"Cyan",
// 		"Blue",
// 		"Violet",
// 		"Purple",
// 		"Magneta",
// 	};
// 	baseColorMenu.AddOptions(baseColorMenuOptions);

// 	Color.HEX BaseColorMenu() {
// 		while (baseColorMenu.menuLoop) {

// 			Console.Clear();
// 			baseColorMenu.DisplayMenu();
// 			baseColorMenu.SetMenuCursor();

// 			switch(baseColorMenu.selectedItem) {

// 				case 0:
// 					return new Color.HEX(BaseColor.White);
// 					break;
// 				case 1:
// 					return new Color.HEX(BaseColor.White);
// 					break;
// 				case 2:
// 					return new Color.HEX(BaseColor.Gray);
// 					break;
// 				case 3:
// 					return new Color.HEX(BaseColor.Grey);
// 					break;
// 				case 4:
// 					return new Color.HEX(BaseColor.Black);
// 					break;
// 				case 5:
// 					return new Color.HEX(BaseColor.Red);
// 					break;
// 				case 6:
// 					return new Color.HEX(BaseColor.Orange);
// 					break;
// 				case 7:
// 					return new Color.HEX(BaseColor.Yellow);
// 					break;
// 				case 8:
// 					return new Color.HEX(BaseColor.Lime);
// 					break;
// 				case 9:
// 					return new Color.HEX(BaseColor.Green);
// 					break;
// 				case 10:
// 					return new Color.HEX(BaseColor.Cyan);
// 					break;
// 				case 11:
// 					return new Color.HEX(BaseColor.Blue);
// 					break;
// 				case 12:
// 					return new Color.HEX(BaseColor.Violet);
// 					break;
// 				case 13:
// 					return new Color.HEX(BaseColor.Purple);
// 					break;
// 				case 14:
// 					return new Color.HEX(BaseColor.Magneta);
// 					break;
// 				default:
// 					break;
// 			}
// 		}
// 		return new Color.HEX("");
// 	}

// void savePalette(string fileName, string path = "") {

// 	string[] headers = new string[]{
// 		"CMYK",
// 		"HEX",
// 		"HSL",
// 		"HSV",
// 		"RGB",
// 		"\n"
// 	};

// 	var outputFile = new SaveToFile.CSV(fileName, path);
// 	if (outputFile.Initalize(outputFile.FileName)) {

// 		outputFile.SetHeaders(outputFile.FileName, headers);

// 		for (int i = 0; i < paletteHSV.Count; i++) {
// 			string[] colors = new string[6];
// 			colors[0] = "\"" + $"({paletteCMYK[i].Cyan}, {paletteCMYK[i].Magenta}, {paletteCMYK[i].Yellow}, {paletteCMYK[i].Key})" + "\"";
// 			colors[1] = paletteHEX[i].Value;
// 			colors[2] = "\"" + $"({paletteHSL[i].Hue}, {paletteHSL[i].Saturation}, {paletteHSL[i].Lightness})" + "\"";
// 			colors[3] = "\"" + $"({paletteHSV[i].Hue}, {paletteHSV[i].Saturation}, {paletteHSV[i].Value})" + "\"";
// 			colors[4] = "\"" + $"({paletteRGB[i].Red}, {paletteRGB[i].Green}, {paletteRGB[i].Blue})" + "\"";
// 			colors[5] = "\n";

// 			outputFile.WriteData(outputFile.FileName, colors);
// 		}
// 	}
// }

void DebugBox() {

	TestsDriver.Initialize();
	TestsDriver.Run_Color_Tests(true);

	TestsDriver.Run_ColorHarmony_Tests(true);

	TestsDriver.Run_ConvertColor_Tests(true);

	TestsDriver.Run_BlendColors_Tests(true);

	TestsDriver.Run_ValueDeviation_Tests(true);
}

void MenuBetaTest() {

	MenuBetaDriver.RunMainMenu();
	MenuBetaDriver.RunGenerationDriver();
}

// MainMenu();
// DebugBox();
// MenuBetaTest();