using userinput;
using menudriver;
using colorvalues;
using colorharmony;

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

// Menu for color input
MenuDriver colorInput = new MenuDriver();
	string[] colorInputOptions = new string[] {

		"Hexadecimal",
		"HSL",
		"HSV",
		"RGB",
		"Main Menu",
	};
	colorInput.AddOptions(colorInputOptions);

	void ColorInput() {
		while (colorInput.menuLoop){

			Console.Clear();
			colorInput.DisplayMenu();
			colorInput.SetMenuCursor();

			switch(colorInput.selectedItem) {

				case 0:
					generationDriver();
					break;
				case 1:
					
					break;
				case 2: 
					MainMenu();
					break;
				default:
					break;
			}
		}
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

	harmonyMenu();
}

Console.WriteLine(UserInput.Query("Hexadecimal, HSL, HSV, or RGB?"));