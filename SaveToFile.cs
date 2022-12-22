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

		public bool SetHeaders(string filePath, string[] headers) {

			try {
				var headerLine = String.Join(",", headers);
				File.AppendAllText(filePath, headerLine);
			}
			catch {return false;}

			return true;
		}

		public bool WriteData(string filePath, string[] data) {

			var rowData = string.Join(",", data);
			File.AppendAllText(filePath, rowData);
			return true;
		}
	}
}
}