namespace userinput {
public class SanitizeInput {

	public static string StripCharacters(string inputString, string targetCharacters) {

		if (inputString.Contains(targetCharacters)) {
			inputString = inputString.Replace(targetCharacters, "");
		}

		return inputString;
	}
}
}