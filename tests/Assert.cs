namespace tests {
public class Assert {

	public static int Int32AreEqual(int ObjectA, int ObjectB, string message="") {
		int result;

		Console.WriteLine("");
		Console.WriteLine(message);
		Console.WriteLine($"Assert.Int32AreEqual: {ObjectA} is equal to {ObjectB}");

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
		Console.WriteLine($"Assert.Int32AreNotEqual: {ObjectA} is not equal to {ObjectB}");

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
		Console.WriteLine($"Assert.BoolTrue: {Object} is True");

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
		Console.WriteLine($"Assert.BoolFalse: {Object} is False");

		if (Object == false) {result = 1;}
		else if (Object == true) {result = 0;}
		else {return -1;}

		Console.WriteLine($"Result = {result}");
		return result;
	}

	public static int IsType(object ObjectA, object ObjectB, string message="") {
		int result;

		Console.WriteLine("");
		Console.WriteLine(message);
		Console.WriteLine($"Assert.IsType: {ObjectA} is the typeof {ObjectB}");

		if (ObjectA.GetType() == ObjectB.GetType()) {result = 1;}
		else if (ObjectA.GetType() != ObjectB.GetType()) {result = 0;}
		else {return -1;}

		Console.WriteLine($"Result = {result}");
		return result;
	}
}
}