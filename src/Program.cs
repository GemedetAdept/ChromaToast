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

void DebugBox() {

	TestsDriver.Initialize();
	TestsDriver.Run_Color_Tests(true);

	TestsDriver.Run_ColorHarmony_Tests(true);

	TestsDriver.Run_ConvertColor_Tests(true);

	TestsDriver.Run_BlendColors_Tests(true);

	TestsDriver.Run_ValueDeviation_Tests(true);
}

// DebugBox();