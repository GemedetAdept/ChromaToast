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