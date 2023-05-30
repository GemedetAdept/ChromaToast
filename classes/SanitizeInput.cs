namespace userinput {
public class SanitizeInput {

	public static string StripCharacter(string inputString, char targetCharacter) {

		if (inputString.Contains(targetCharacter) {
			inputString = inputString.Replace(targetCharacter, "");
		}

		return inputString;
	}
}
}