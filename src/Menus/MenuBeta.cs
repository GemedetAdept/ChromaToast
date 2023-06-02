namespace menudriver {

public class MenuBeta {
	private string _title;
	private string[] _options;
	private string _cursor;
	private int _activeItem;
	private int _selectedItem;
	private bool _menuLoop;

	public string Title {get;set;}
	public string[] Options{get;set;}
	public string Cursor {get;set;}
	public int ActiveItem {get;set;}
	public int SelectedItem{get;set;}
	public bool MenuLoop;

	public int LoadCursor() {
		
	}
}
}