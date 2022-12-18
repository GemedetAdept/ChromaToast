// using userinput;
// using menudriver;

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

// Menu for Color Harmony selection
bool harmonyMenuBool = false;
MenuDriver harmonyMenu = new MenuDriver();
string[] harmonyOptions = new string[] {

	"Complementary",
	"Split Complementary",
	"Triadic",
	"Tetradic",
	"Square",
	"Analogous",
	"Monochromatic",
	"Quit Program",
};
harmonyMenu.AddOptions(harmonyOptions);

while (harmonyMenuBool)
void HarmonyMenu() {
	while (harmonyMenu.menuLoop){

		Console.Clear();
		harmonyMenu.DisplayMenu();
		harmonyMenu.SetMenuCursor();

		switch(harmonyMenu.selectedItem) {

			case 0:
				ColorHarmony.Complementary();
				harmonyMenu.menuLoop = false;	
				break;
			case 1:
				ColorHarmony.SplitComplementary();
				harmonyMenu.menuLoop = false;
				break;
			case 2:
				ColorHarmony.Triadic();
				harmonyMenu.menuLoop = false;
				break;
			case 3:
				ColorHarmony.Tetradic();
				harmonyMenu.menuLoop = false;
				break;
			case 4:
				ColorHarmony.Square();
				harmonyMenu.menuLoop = false;
				break;
			case 5:
				ColorHarmony.Analogous();
				harmonyMenu.menuLoop = false;
				break;
			case 6:
				ColorHarmony.Monochromatic();
				harmonyMenu.menuLoop = false;
				break;
			case 7: 
				Console.Clear();
				Environment.Exit(0);
				break;
			default:
				break;
		}
	}
}

void generationDriver() {

	paletteHEX.Clear();
	paletteHSL.Clear();
	paletteHSV.Clear();
	paletteRGB.Clear();

	harmonyMenu();
}

// string alignItem((double, double, double) columnItem, int maxLength) {

// 	string inputItem = columnItem.ToString();
// 	int inputItemLength = inputItem.Length;
// 	string alignedItem = inputItem;

// 	if (inputItemLength < maxLength) {

// 		int padding = maxLength - inputItemLength;
// 		alignedItem += new string(' ', padding);
// 	}

// 	return alignedItem;
// }

// string centerHeader(string tableHeader, int maxWidth) {

// 	int headerLength = tableHeader.Length;
// 	string centeredHeader = tableHeader;

// 	int paddingLeft = -4;
// 	int paddingRight = -4;
// 	int widthRemainder = maxWidth - headerLength;

// 	if (widthRemainder % 2 == 1) {
// 		paddingRight = (widthRemainder+1)/2;
// 		paddingLeft = paddingRight-1;
// 	}

// 	else if (widthRemainder % 2 == 0) {
// 		paddingRight = widthRemainder/2;
// 		paddingLeft = widthRemainder/2;
// 	}

// 	string headerLeft = new string(' ', paddingLeft);
// 	string headerRight = new string(' ', paddingRight);
// 	centeredHeader = headerLeft + tableHeader + headerRight;

// 	return centeredHeader;
// }

// void displayPalette() {

// 	int colorCount = paletteHSV.Count;

// 	string columTitles = "    HEX         HSL            HSV            RGB";
// 	string columnBars = "   o---o       o---o          o---o          o---o";

// 	int paletteTableWidth = 55;
// 	string harmonyType = ColorHarmony.userHarmonyChoice;
// 	string tableHeader = centerHeader($"{harmonyType} Palette", paletteTableWidth);

// 	Console.WriteLine(tableHeader);
// 	Console.WriteLine(columTitles);
// 	Console.WriteLine(columnBars);

// 	for (int i=0; i < colorCount; i++) {

// 		string itemHEX = $"#{paletteHEX[i]}";
// 		string itemHSL = alignItem(paletteHSL[i], 13);
// 		string itemHSV = alignItem(paletteHSV[i], 13);
// 		string itemRGB = alignItem(paletteRGB[i], 13);

// 		Console.WriteLine($"  {itemHEX}  {itemHSL}  {itemHSV}  {itemRGB}");
// 	}

// 	Console.ReadKey();
// }
using colorvalues;
using colorharmony;

Color.HSV alphaHSV = new Color.HSV(0.0, 59.3, 69.4);
var harmony = ColorHarmony.Monochromatic(alphaHSV);

foreach (Color.HSV color in harmony) {
	Console.WriteLine($"({color.Hue}, {color.Saturation}, {color.Value})");
}