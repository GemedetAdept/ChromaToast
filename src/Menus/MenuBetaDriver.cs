namespace menudriver {
public class MenuBetaDriver {

	public static int RunTestMenu() {
		MenuBeta testMenu = new MenuBeta();
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
			default: Console.WriteLine("You Broke It!"); break;
		}
	return 1;
	}
}
}