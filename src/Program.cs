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

public int KillProgram(int stateCode) {
	if (stateCode == 1) {
		Console.Clear();
		Environment.Exit(0);
	}
}

Option[] mainMenuOptions = {
	new Option("Generate New Palette", () => Console.WriteLine("A")),
	new Option("Exit Program", () => )
};

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