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

	public string Title {get;set;}
	public Option[] Options {get;set;}
	public Option ActiveOption {get;set;}
	public int Index {get;set;}
	public int SelectedItem {get;set;}

	public MenuGamma(Option[] options) {
		Index = 0;
		Options = options;
		ActiveOption = Options[Index];
	}

	public int DisplayMenu(string cursor=">") {

		Console.Clear();

		for (int i=0; i < Options.Length; i++) {

			if (Options[i] == ActiveOption) {Console.Write(cursor+" ");}
			else {Console.Write("  ");}

			Console.WriteLine(Options[i].Label);
		}

		return 1;
	}
}
}