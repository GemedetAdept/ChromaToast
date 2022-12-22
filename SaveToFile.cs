namespace savetofile {
public class SaveToFile {

	public class CSV {

		private string _fileName;
		private string _filePath;

		public CSV(string fileName, string filePath = "") {

			FileName = fileName;
			FilePath = filePath;
		}

		public string FileName {
			get {return _fileName;}
			set {_fileName = value;}
		}

		public string FilePath {
			get {return _filePath;}
			set {_filePath = value;}
		}

		public bool Initalize(string filePath) {

			File.WriteAllText(filePath, "");
			if (File.Exists(filePath)) {return true;}
			else {return false;}
		}

		public string Headers(string fileName, string[] headers) {

			string headerLine = Headers.ToString(",");
		}
	}
}
}