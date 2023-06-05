namespace menudriver {
public class MenuGamma {

	public string Title {get;set;}
	public Option Options {get;set;}
	public int ActiveOption {get;set;}

	public MenuGamma() {
		ActiveOption = 0;
	}

	public class Option {
		public string Label {get;set;}
		public Action Procedure {get;set;}

		public Option(string label, Action procedure) {
			Label = label;
			Procedure = procedure;
		}
	}

	public int DisplayMenu(Option[] options, Option activeOption, string cursor=">") {

		Console.Clear();

		for (int i=0; i < options.Length; i++) {

			if (options[i] == activeOption) {Console.WriteLine(cursor+" ");}
			else {Console.WriteLine(" ");}

			Console.WriteLine(options[i].Label);
		}

		return 1;
	}

	public int UpdateCursor() {

		ConsoleKey UpArrow = ConsoleKey.UpArrow;
		ConsoleKey DownArrow = ConsoleKey.DownArrow;
		ConsoleKey Enter = ConsoleKey.Enter;

		var keyInput = Console.ReadKey(false);
		int optionsLength = Options.Length;

		if (keyInput.Key == UpArrow && ActiveOption > 0) {ActiveOption -= 1;}
		else if (keyInput.Key == DownArrow && ActiveOption < optionsLength-1) {ActiveOption += 1;}
		else if (keyInput.Key == Enter) {SelectedItem = ActiveOption;}

		return 1;
	}
}
}