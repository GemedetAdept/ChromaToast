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

// MenuBetaDriver.RunMainMenu();
// MenuBetaDriver.RunGenerationDriver();

Option[] testOptions = {
	new Option("A", () => Console.WriteLine("A")),
	new Option("B", () => Console.WriteLine("B")),
	new Option("C", () => Console.WriteLine("C")),
	new Option("D", () => Console.WriteLine("D")),
	new Option("E", () => Console.WriteLine("E")),	
};

MenuGamma gammaTest = new MenuGamma(testOptions);
gammaTest.DisplayMenu();
gammaTest.ExecuteProcedure(0);

// foreach(Option option in testOptions) {
// 	option.Procedure();
// }

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

// DebugBox();