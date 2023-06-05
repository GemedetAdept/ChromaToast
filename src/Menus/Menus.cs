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


}
}