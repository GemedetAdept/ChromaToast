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

int KillProgram(int stateCode) {
	if (stateCode == 1) {
		Console.Clear();
		Environment.Exit(0);
		return 1;
	}
	else {return 0;}
}

// Main Menu
void MainMenu() {
	Option[] mainMenuOptions = {
		new Option("Generate New Palette", () => Console.WriteLine("A")),
		new Option("Exit Program", () => KillProgram(1))
	};

	MenuGamma mainMenu = new MenuGamma(mainMenuOptions);

	do {
		mainMenu.DisplayMenu();
		mainMenu.UpdateKeyInput();
	} while (mainMenu.MenuLoop);
}


// Color Type Menu
void ColorTypeMenu() {

	var outputHSV = new Color.HSV(0.0, 0.0, 0.0);

	Option[] colorTypeMenuOptions = {
		new Option("CMYK", () => MenuProcedure.EnterCMYK(outputHSV)),
		new Option("HEX", () => MenuProcedure.EnterHEX(outputHSV)),
		new Option("HSL", () => MenuProcedure.EnterHSL(outputHSV)),
		new Option("HSV", () => MenuProcedure.EnterHSV(outputHSV)),
		new Option("RGB", () => MenuProcedure.EnterRGB(outputHSV)),
		new Option("Base Colors", () => Console.WriteLine("Base Colors")),
		new Option("Exit Program", () => KillProgram(1))
	};

	MenuGamma colorTypeMenu = new MenuGamma(colorTypeMenuOptions);

	do {
		colorTypeMenu.DisplayMenu();
		colorTypeMenu.UpdateKeyInput();
	} while (colorTypeMenu.MenuLoop);

}

ColorTypeMenu();

void DebugBox() {

	Option[] testOptions = {
		new Option("A", () => Console.WriteLine("A")),
		new Option("B", () => Console.WriteLine("B")),
		new Option("C", () => Console.WriteLine("C")),
		new Option("D", () => Console.WriteLine("D")),
		new Option("E", () => Console.WriteLine("E")),	
	};

	MenuGamma gammaTest = new MenuGamma(testOptions);

	do {
		gammaTest.DisplayMenu();
		gammaTest.UpdateKeyInput();

	} while (gammaTest.MenuLoop);

	TestsDriver.Initialize();
	TestsDriver.Run_Color_Tests(true);

	TestsDriver.Run_ColorHarmony_Tests(true);

	TestsDriver.Run_ConvertColor_Tests(true);

	TestsDriver.Run_BlendColors_Tests(true);

	TestsDriver.Run_ValueDeviation_Tests(true);
}

// DebugBox();