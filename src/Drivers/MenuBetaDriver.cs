using userinput;
using convertcolor;
using colorvalues;
using generation;
using display;
namespace menudriver {
public class MenuBetaDriver {

	public static GenerationDriver.HarmonyBase harmonyObject = new GenerationDriver.HarmonyBase();

	public static int RunTestMenu() {
		MenuBeta testMenu = new MenuBeta();
		testMenu.Title = "~.,.~ Test Menu ~.,.~\n";
		testMenu.Options = new string[]{"Option 0", "Option 1", "Option 2", "Exit Program"};
		while (testMenu.MenuLoop == true) {
			testMenu.LoadMenu();
			testMenu.UpdateCursor();
			testMenu.SelectionCheck();
		}

		switch(testMenu.SelectedItem) {
			case 0: Console.WriteLine("Printout 0"); break;
			case 1: Console.WriteLine("Printout 1"); break;
			case 2: Console.WriteLine("Printout 2"); break;
			case 3: Console.Clear(); Environment.Exit(0); break;
			default: break;
		}
	return 1;
	}

	public static int RunMainMenu() {
		MenuBeta mainMenu = new MenuBeta();
		mainMenu.Title = "~.,.~ Main Menu ~.,.~\n";
		mainMenu.Options = new string[] {
			"Generate New Color Palette",
			"Exit Program"
		};

		while (mainMenu.MenuLoop == true) {
			mainMenu.LoadMenu();
			mainMenu.UpdateCursor();
			mainMenu.SelectionCheck();
		}

		switch(mainMenu.SelectedItem) {
			case 0: RunGenerationDriver(); break;
			case 1: Console.Clear(); Environment.Exit(0); break;
			default: break;
		}

	return 1;
	}

	public static int RunHarmonyMenu(Color.HSV inputHSV) {
		MenuBeta harmonyMenu = new MenuBeta();
		harmonyMenu.Title = "~.,.~ Harmony Menu ~.,.~\n";
		harmonyMenu.Options = new string[] {
			"Complementary",
			"Split Complementary",
			"Triadic",
			"Tetradic",
			"Square",
			"Analogous",
			"Monochromatic",
			"Exit Program"
		};

		while (harmonyMenu.MenuLoop == true) {
			harmonyMenu.LoadMenu();
			harmonyMenu.UpdateCursor();
			harmonyMenu.SelectionCheck();			
		}

		harmonyObject.LoadInputHSV(inputHSV);
		switch(harmonyMenu.SelectedItem) {
			case 0: harmonyObject.Complementary();
					break;
			case 1: harmonyObject.SplitComplementary();
					break;
			case 2: harmonyObject.Triadic();
					break;
			case 3: harmonyObject.Tetradic();
					break;
			case 4: harmonyObject.Square();
					break;
			case 5: harmonyObject.Analogous();
					break;
			case 6: harmonyObject.Monochromatic();
					break;
			case 7: Console.Clear(); Environment.Exit(0); break;
			default:
					break;
		}

	return 1;
	}

	public static Color.HSV RunInputTypeMenu() {
		MenuBeta inputTypeMenu = new MenuBeta();
		inputTypeMenu.Title = "~.,.~ Input Type Menu ~.,.~\n";
		inputTypeMenu.Options = new string[] {
			"CMYK",
			"HEX",
			"HSL",
			"HSV",
			"RGB",
			"Exit Program"
		};

		inputTypeMenu.QueryHeader = "Enter a value between: ";
		inputTypeMenu.QueryMessages = new string[] {
			"(0.0, 0.0, 0.0, 0.0) - (100.0, 100.0, 100.0, 100.0",
			"#000000 - #FFFFFF",
			"(0.0, 0.0, 0.0) - (360.0, 100.0, 100.0)",
			"(0.0, 0.0, 0.0) - (360.0, 100.0, 100.0)",
			"(0, 0, 0) - (255, 255, 255)",
		};

		while (inputTypeMenu.MenuLoop == true) {
			inputTypeMenu.LoadMenu();
			inputTypeMenu.UpdateCursor();
			inputTypeMenu.SelectionCheck();		
		}

		Color.HSV normHSV = new Color.HSV(0.0, 0.0, 0.0);
		switch(inputTypeMenu.SelectedItem) {
			case 0: inputTypeMenu.QueryInput = UserInput.Query(inputTypeMenu.QueryHeader+inputTypeMenu.QueryMessages[0]);
					var inputCMYK = UserInput.InputCMYK(inputTypeMenu.QueryInput);
					normHSV = ConvertColor.CMYKtoHSV(inputCMYK);
					return normHSV;
					break;

			case 1: inputTypeMenu.QueryInput = UserInput.Query(inputTypeMenu.QueryHeader+inputTypeMenu.QueryMessages[1]);
					var inputHEX = UserInput.InputHEX(inputTypeMenu.QueryInput);
					normHSV = ConvertColor.HEXtoHSV(inputHEX);
					return normHSV;
					break;

			case 2: inputTypeMenu.QueryInput = UserInput.Query(inputTypeMenu.QueryHeader+inputTypeMenu.QueryMessages[2]);
					var inputHSL = UserInput.InputHSL(inputTypeMenu.QueryInput);
					normHSV = ConvertColor.HSLtoHSV(inputHSL);
					return normHSV;
					break;

			case 3: inputTypeMenu.QueryInput = UserInput.Query(inputTypeMenu.QueryHeader+inputTypeMenu.QueryMessages[3]);
					var inputHSV = UserInput.InputHSV(inputTypeMenu.QueryInput);
					normHSV = inputHSV;
					return normHSV;
					break;

			case 4: inputTypeMenu.QueryInput = UserInput.Query(inputTypeMenu.QueryHeader+inputTypeMenu.QueryMessages[4]);
					var inputRGB = UserInput.InputRGB(inputTypeMenu.QueryInput);
					normHSV = ConvertColor.RGBtoHSV(inputRGB);
					return normHSV;
					break;
			case 5: Console.Clear(); Environment.Exit(0); break;
			default:
				return normHSV;
				break;
		}
		return normHSV;
	}

	public static int RunGenerationDriver() {

		var inputHSV = RunInputTypeMenu();
		RunHarmonyMenu(inputHSV);

		SinglePalette.LoadData(harmonyObject.PaletteCMYK);
		SinglePalette.LoadData(harmonyObject.PaletteHEX);
		SinglePalette.LoadData(harmonyObject.PaletteHSL);
		SinglePalette.LoadData(harmonyObject.PaletteHSV);
		SinglePalette.LoadData(harmonyObject.PaletteRGB);

		SinglePalette.PrintAll();
		Console.ReadKey();

		RunMainMenu();

		return 1;
	}
}
}