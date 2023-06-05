namespace savetofile {
public class SaveToFile {

	public class CSVBeta {

		public string FileName {get;set;}
		public string FilePath {get;set;}
		public string Title {get;set;}
		public string HarmonyType {get;set;}
		public DateTime CreationDate {get;set;}
		public string[] Headers {get;set;}
		public string[] RowLabels {get;set;}
		public string[] RowData {get;set;}

		public CSVBeta() {
			CreationDate = DateTime.Now();
		}
	}

	public class Timestamped {

		private DateTime _currentTime;
		private string _fullName;
		public Timestamped(string fileName, string filePath = "") {

			CurrentTime = DateTime.Now;
			FullName = filePath + fileName + CurrentTime.ToString().Replace(':', '_') + ".csv";
		}

		public DateTime CurrentTime {
			get {return _currentTime;}
			set {_currentTime = value;}
		}
		public string FullName {
			get {return _fullName;}
			set {_fullName = value;}
		}
	}

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