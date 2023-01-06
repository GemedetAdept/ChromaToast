namespace menudriver {
public class BetaMenu {

	public List<string> Options = new List<string>();
	public bool AddOptions(string[] inputOptions) {

		foreach(string option in inputOptions) {
			Options.Add(inputOptions[0]);
		}

		return true;
	}

	private int _activeOption = 0;
	public int ActiveOption {
		get {_activeOption;}
		set {_activeOption = value;}
	}

	public void SetMenuCursor() {

		int optionsCount = Options.Length;
		var keyInput = Console.ReadKey(false);

		if (keyInput.Key == ConsoleKey.UpArrow && activeItem > 0) {

			ActiveOption -= 1;
		}

		else if (keyInput.Key == ConsoleKey.DownArrow && activeItem < optionsCount-1) {

			ActiveOption += 1;
		}

		else if (keyInput.Key == ConsoleKey.Enter) {
			
			ActiveOption = ActiveOption;
		}
	}

	public bool PrintMenu() {
		for (int i = 0; i < Options.Length; i ++) {
			if (ActiveOption == Options[i]) {Console.Write(menuCursor.Graphic);}
			Console.WriteLine(option);
		}
	}
}
}