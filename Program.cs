using userinput;
using menudriver;
using colorvalues;
using colorharmony;
using convertcolor;

var paletteHEX = new List<Color.HEX>();
var paletteHSL = new List<Color.HSL>();
var paletteHSV = new List<Color.HSV>();
var paletteRGB = new List<Color.RGB>();

// Main Menu
MenuDriver mainMenu = new MenuDriver();
	string[] mainMenuOptions = new string[] {

		"Generate New Color Palette",
		"Learn About Color Harmonies",
		"Quit Program",
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
					break;
				case 1:
					
					break;
				case 2: 
					Console.Clear();
					Environment.Exit(0);
					break;
				default:
					break;
			}
		}
	}

// Color Input Menu
MenuDriver inputMenu = new MenuDriver();
	string[] inputMenuOptions = new string[] {

		"Hexadecimal",
		"HSL",
		"HSV",
		"RGB",
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
					userColorInput = UserInput.Query("Enter a value between #000000 - #FFFFFF");
					var inputHEX = UserInput.InputHEX(userColorInput);
					normalizedInput = ConvertColor.HEXtoHSV(inputHEX);
					return normalizedInput;
					break;
				case 1:
					userColorInput = UserInput.Query("Enter a value between (0.0, 0.0, 0.0) - (360.0, 100.0, 100.0)");
					var inputHSL = UserInput.InputHSL(userColorInput);
					normalizedInput = ConvertColor.HSLtoHSV(inputHSL);
					return normalizedInput;
					break;
				case 2:
					userColorInput = UserInput.Query("Enter a value between (0.0, 0.0, 0.0) - (360.0, 100.0, 100.0)");
					var inputHSV = UserInput.InputHSV(userColorInput);
					return inputHSV;
					break;
				case 3:
					userColorInput = UserInput.Query("Enter a value between (0, 0, 0) - (255, 255, 255)");
					var inputRGB = UserInput.InputRGB(userColorInput);
					normalizedInput = ConvertColor.RGBtoHSV(inputRGB);
					return normalizedInput;
					break;
				case 4: 
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

// // Menu for Color Harmony selection
// bool harmonyMenuBool = false;
// MenuDriver harmonyMenu = new MenuDriver();
	// string[] harmonyOptions = new string[] {

	// 	"Complementary",
	// 	"Split Complementary",
	// 	"Triadic",
	// 	"Tetradic",
	// 	"Square",
	// 	"Analogous",
	// 	"Monochromatic",
	// 	"Quit Program",
	// };
	// harmonyMenu.AddOptions(harmonyOptions);

	// while (harmonyMenuBool)
	// void HarmonyMenu() {
	// 	while (harmonyMenu.menuLoop){

	// 		Console.Clear();
	// 		harmonyMenu.DisplayMenu();
	// 		harmonyMenu.SetMenuCursor();

	// 		switch(harmonyMenu.selectedItem) {

	// 			case 0:
	// 				ColorHarmony.Complementary();
	// 				harmonyMenu.menuLoop = false;	
	// 				break;
	// 			case 1:
	// 				ColorHarmony.SplitComplementary();
	// 				harmonyMenu.menuLoop = false;
	// 				break;
	// 			case 2:
	// 				ColorHarmony.Triadic();
	// 				harmonyMenu.menuLoop = false;
	// 				break;
	// 			case 3:
	// 				ColorHarmony.Tetradic();
	// 				harmonyMenu.menuLoop = false;
	// 				break;
	// 			case 4:
	// 				ColorHarmony.Square();
	// 				harmonyMenu.menuLoop = false;
	// 				break;
	// 			case 5:
	// 				ColorHarmony.Analogous();
	// 				harmonyMenu.menuLoop = false;
	// 				break;
	// 			case 6:
	// 				ColorHarmony.Monochromatic();
	// 				harmonyMenu.menuLoop = false;
	// 				break;
	// 			case 7: 
	// 				Console.Clear();
	// 				Environment.Exit(0);
	// 				break;
	// 			default:
	// 				break;
	// 		}
	// 	}
	// }

void generationDriver() {

	paletteHEX.Clear();
	paletteHSL.Clear();
	paletteHSV.Clear();
	paletteRGB.Clear();

	Color.HSV normalizedInputHSV = InputMenu();
	Console.WriteLine($"{normalizedInputHSV.Hue}, {normalizedInputHSV.Saturation}, {normalizedInputHSV.Value}");
	
	Console.ReadKey();
}

MainMenu();