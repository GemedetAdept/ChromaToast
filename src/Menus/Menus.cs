namespace menudriver {
public class Menus {

	public void ExitProgram() {
		Console.Clear();
		Environment.Exit(0);
	}

	public int LoopMenu(MenuBeta inputMenu) {
		while (inputMenu.MenuLoop == true) {
			inputMenu.LoadMenu();
			inputMenu.UpdateCursor();
			inputMenu.SelectionCheck();
		}
		return 1;
	}

	public MenuBeta MainMenu() {
		var mainMenu = new MenuBeta();

		mainMenu.Title = "Main Menu";
		mainMenu.Options = new Option[] {
			new Option("Generate New Palette", () => MenuBetaDriver.RunGenerationDriver()),
			new Option("Exit Program", () => ExitProgram())
		};

		return mainMenu;
	}
}
}