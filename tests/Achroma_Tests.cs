using colorvalues;
namespace tests {
public class Achroma_Tests {

	public static int Achroma_Loads_Input() {
		string AchromaTypeString = "HEX";
		string AchromaValueString = "000000";
		var modelHEX = new Color.HEX("000000");

		var createdAchroma = new Achroma(AchromaTypeString, AchromaValueString);

		Assert.IsType(createdAchroma.HEX, modelHEX, "Achroma_Loads_Input");
		return 1;
	}
}
}