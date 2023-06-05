namespace menudriver {
public class MenuGamma {

	public class Option {
		public string Label {get;set;};
		public Action Procedure {get;set;}

		public Option(string label, Action procedure) {
			Label = label;
			Procedure = procedure;
		}
	}

	public int DisplayMenu(Option[] options, Option activeOption) {

		Console.Clear();

		for (int i=0; i < options.Length; i++) {

			if (options[i] == activeOption) {Console.WriteLine("> ");}
			else {Console.WriteLine(" ");}

			Console.WriteLine(options[i].Label);
		}
	}
}
}