namespace menudriver {

public class MenuBeta {

	public string Title {get;set;}
	public string[] Options{get;set;}
	public string Cursor {get;set;}
	public int ActiveItem {get;set;}
	public int SelectedItem{get;set;}
	public bool MenuLoop;

	public MenuBeta() {
		Title = "-- Lorem Ipsum --";
		Options = new string[] {""};
		Cursor = "> ";
		ActiveItem = 0;
		SelectedItem = -1; // Initalize with non-functional value
		MenuLoop = true;
	}

	public int SetTitle(string title) {
		Title = title;
		return 1;
	}
	public int SetOptions(string[] options) {
		Options = options;
		return 1;
	}
	public int SetCursor(string cursor) {
		Cursor = cursor;
		return 1;
	}
	public int SetCursorSpacer(string cursorSpacer) {
		cursorSpacer = cursorSpacer;
		return 1;
	}
	public int SetActiveItem(int activeItem) {
		ActiveItem = activeItem;
		return 1;
	}
	public int SetSelectedItem(int selectedItem) {
		SelectedItem = selectedItem;
		return 1;
	}
	public int SetMenuLoop(bool menuLoop) {
		MenuLoop = menuLoop;
		return 1;
	}

	public int LoadMenu() {

		string optionString = "";

		Console.Clear();
		Console.WriteLine(Title);
		// When paired with UpdateCursor(), this responds to user input with arrow keys
		for (int i=0; i < Options.Length; i++) {

			if (i == ActiveItem) {
				optionString += Cursor;
			}

			optionString += Options[i];
			Console.WriteLine(optionString);
			
			optionString = "";
		}
		return 1;
	}

	public int UpdateCursor() {

		ConsoleKey UpArrow = ConsoleKey.UpArrow;
		ConsoleKey DownArrow = ConsoleKey.DownArrow;
		ConsoleKey Enter = ConsoleKey.Enter;

		var keyInput = Console.ReadKey(false);
		int optionsLength = Options.Length;

		if (keyInput.Key == UpArrow && ActiveItem > 0) {ActiveItem -= 1;}
		else if (keyInput.Key == DownArrow && ActiveItem < optionsLength-1) {ActiveItem += 1;}
		else if (keyInput.Key == Enter) {SelectedItem = ActiveItem;}

		return 1;
	}

	public int SelectionCheck() {
		if (SelectedItem == ActiveItem) {MenuLoop = false; return 1;}
		else if (SelectedItem != ActiveItem) {return 0;}
		else {return -1;}
	}
}
}