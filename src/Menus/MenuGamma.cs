namespace menudriver {

public class Option {
	public string Label {get;set;}
	public Action Procedure {get;set;}

	public Option(string label, Action procedure) {
		Label = label;
		Procedure = procedure;
	}
}

public class MenuGamma {

	public bool MenuLoop {get;set;}
	public string Title {get;set;}
	public Option[] Options {get;set;}
	public Option SelectedOption {get;set;}
	public int Index {get;set;}

	public MenuGamma(Option[] options) {
		MenuLoop = true;
		Index = 0;
		Options = options;
	}

	// Check the array item against the index to write the cursor to the active item
	public int DisplayMenu(string cursor=">") {

		Console.Clear();

		for (int i=0; i < Options.Length; i++) {

			if (i == Index) {Console.Write(cursor+" ");}
			else {Console.Write("  ");}

			Console.WriteLine(Options[i].Label);
		}

		return 1;
	}

	// The normal delegate call could work, but I like having a dedicated function
	public int ExecuteProcedure(int index) {
		SelectedOption = Options[index];
		SelectedOption.Procedure();
		return 1;
	}

	public int KillLoop(int keyInputCode) {
		if (keyInputCode == 2) {
			MenuLoop = false;
			return 1;
		}
		else {return 0;}
	}

	public int UpdateKeyInput() {
		var keyInput = Console.ReadKey(false);

		if (keyInput.Key == ConsoleKey.UpArrow) {
		if (Index > 0) {Index--; return 1;}
		}

		else if (keyInput.Key == ConsoleKey.DownArrow) {
		if (Index < Options.Length-1) {Index++; return 1;}
		}

		else if (keyInput.Key == ConsoleKey.Enter) {
			KillLoop(2);
			ExecuteProcedure(Index); return 2;
		}

		return 0;
	}
}
}