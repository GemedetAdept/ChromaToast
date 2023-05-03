namespace tests {
public class Assert {

	public static int Int32AreEqual(int ObjectA, int ObjectB, string message="") {
		int result;

		Console.WriteLine("");
		Console.WriteLine(message);
		Console.WriteLine($"Int32AreEqual: {ObjectA}, {ObjectB}");

		if (ObjectA == ObjectB) {result = 1;}
		else if (ObjectA != ObjectB) {result = 0;}
		else {return -1;}

		Console.WriteLine($"Result = {result}");
		return result;
	}

	public static int Int32AreNotEqual(int ObjectA, int ObjectB, string message="") {
		int result;

		Console.WriteLine("");
		Console.WriteLine(message);
		Console.WriteLine($"Int32AreNotEqual: {ObjectA}, {ObjectB}");

		if (ObjectA != ObjectB) {result = 1;}
		else if (ObjectA == ObjectB) {result = 0;}
		else {return -1;}

		Console.WriteLine($"Result = {result}");
		return result;
	}

	public static int BoolTrue(bool Object, string message="") {
		int result;

		Console.WriteLine("");
		Console.WriteLine(message);
		Console.WriteLine($"BoolTrue: {Object}");

		if (Object == true) {result = 1;}
		else if (Object == false) {result = 0;}
		else {return -1;}

		Console.WriteLine($"Result = {result}");
		return result;
	}

	public static int BoolFalse(bool Object, string message="") {
		int result;

		Console.WriteLine("");
		Console.WriteLine(message);
		Console.WriteLine($"BoolFalse: {Object}");

		if (Object == false) {result = 1;}
		else if (Object == true) {result = 0;}
		else {return -1;}

		Console.WriteLine($"Result = {result}");
		return result;
	}
}
}