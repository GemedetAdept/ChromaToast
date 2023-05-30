using userinput;
namespace tests {
public class SanitizeInput_Tests {

	public static int StripCharacters_Removes_Characters_From_String() {

		string InputString = "ÅLorem iÅpsumÅ";
		string ExpectedString = "Lorem ipsum";
		string TargetCharacters = "Å";
		string OutputString;

		OutputString = SanitizeInput.StripCharacters(InputString, TargetCharacters);

		Console.WriteLine("");
		Assert.StringAreEqual(OutputString, ExpectedString, "StripCharacters_Removes_Characters_From_String");
		return 1;
	}
}
}