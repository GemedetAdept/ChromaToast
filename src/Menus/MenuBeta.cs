using userinput;
namespace menudriver {

public class MenuBeta {

	public string Title {get;set;}
	public string[] Options{get;set;}
	public string QueryHeader {get; set;}
	public string[] QueryMessages {get;set;}
	public string QueryInput {get;set;}
	public string Cursor {get;set;}
	public int ActiveItem {get;set;}
	public int SelectedItem{get;set;}
	public bool MenuLoop;

	public MenuBeta() {
		Title = "-- Lorem Ipsum --";
		Options = new string[] {""};
		QueryHeader = "";
		QueryMessages = new string[] {""};
		Cursor = "> ";
		ActiveItem = 0;
		SelectedItem = -1;
		MenuLoop = true;
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