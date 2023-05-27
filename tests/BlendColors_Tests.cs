using colorvalues;
namespace tests {
public class BlendColors_Tests {

	public static int PrintOutColorTypeof() {
		var Color = new Color.HEX("000000");
		Console.WriteLine(Color.GetType());
		return 1;
	}
}
}