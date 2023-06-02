namespace tests {
public class Assert {

	private static int PrintResult(int resultCode) {
		Console.ResetColor();
		Console.ForegroundColor = ConsoleColor.Black;

		string resultMessage;
		if (resultCode == 1) {
			Console.BackgroundColor = ConsoleColor.Green;
			resultMessage = "Passed";
		}
		else if (resultCode == 0) {
			Console.BackgroundColor = ConsoleColor.Red;
			resultMessage = "Failed";
		}
		else {
			Console.BackgroundColor = ConsoleColor.Yellow;
			resultMessage = "[ERROR]";
		}

		Console.WriteLine($"Result = ({resultCode}) {resultMessage}.");
		Console.ResetColor();

		return 1;
	}

// IsGreaterThanOrEqual
	public static int IsGreaterThanOrEqual(int ObjectA, int ObjectB, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"(int)IsGreaterThanOrEqual: {ObjectA} is greater than or equal to {ObjectB}");

		if (ObjectA >= ObjectB) {result = 1;}
		else if (ObjectA < ObjectB) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}
	public static int IsGreaterThanOrEqual(double ObjectA, double ObjectB, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"(double)IsGreaterThanOrEqual: {ObjectA} is greater than or equal to {ObjectB}");

		if (ObjectA >= ObjectB) {result = 1;}
		else if (ObjectA < ObjectB) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}

// IsLessThanOrEqual
	public static int IsLessThanOrEqual(int ObjectA, int ObjectB, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"(int)IsLessThanOrEqual: {ObjectA} is less than or equal to {ObjectB}");

		if (ObjectA <= ObjectB) {result = 1;}
		else if (ObjectA > ObjectB) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}
	public static int IsLessThanOrEqual(double ObjectA, double ObjectB, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"(double)IsLessThanOrEqual: {ObjectA} is less than or equal to {ObjectB}");

		if (ObjectA <= ObjectB) {result = 1;}
		else if (ObjectA > ObjectB) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}

// IsEqual
	public static int IsEqual(int ObjectA, int ObjectB, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"(int)IsEqual: {ObjectA} is equal to {ObjectB}");

		if (ObjectA == ObjectB) {result = 1;}
		else if (ObjectA != ObjectB) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}
	public static int IsEqual(double ObjectA, double ObjectB, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"(double)IsEqual: {ObjectA} is equal to {ObjectB}");

		if (ObjectA == ObjectB) {result = 1;}
		else if (ObjectA != ObjectB) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}
	public static int IsEqual(string ObjectA, string ObjectB, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"(string)IsEqual: '{ObjectA}' equals '{ObjectB}'");

		if (ObjectA == ObjectB) {result = 1;}
		else if (ObjectA != ObjectB) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}

// IsNotEqual
	public static int IsNotEqual(int ObjectA, int ObjectB, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"(int)IsNotEqual: {ObjectA} is not equal to {ObjectB}");

		if (ObjectA != ObjectB) {result = 1;}
		else if (ObjectA == ObjectB) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}
	public static int IsNotEqual(double ObjectA, double ObjectB, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"(double)IsNotEqual: {ObjectA} is not equal to {ObjectB}");

		if (ObjectA != ObjectB) {result = 1;}
		else if (ObjectA == ObjectB) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}
	public static int IsNotEqual(string ObjectA, string ObjectB, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"(string)IsNotEqual: {ObjectA} is not equal to {ObjectB}");

		if (ObjectA != ObjectB) {result = 1;}
		else if (ObjectA == ObjectB) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}

// IsGreaterThan
	public static int IsGreaterThan(int ObjectA, int ObjectB, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"IsGreaterThan: {ObjectA} is greater than {ObjectB}");

		if (ObjectA > ObjectB) {result = 1;}
		else if (ObjectA <= ObjectB) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}
	public static int IsGreaterThan(double ObjectA, double ObjectB, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"IsGreaterThan: {ObjectA} is greater than {ObjectB}");

		if (ObjectA > ObjectB) {result = 1;}
		else if (ObjectA <= ObjectB) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}

// IsPositive
	public static int IsPositive(int ObjectA, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"IsPositive: {ObjectA} is postive");

		if (ObjectA >= 0) {result = 1;}
		else if (ObjectA < 0) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}
	public static int IsPositive(double ObjectA, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"IsPositive: {ObjectA} is postive");

		if (ObjectA >= 0) {result = 1;}
		else if (ObjectA < 0) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}

// Bool
	public static int IsTrue(bool Object, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"IsTrue: {Object} is True");

		if (Object == true) {result = 1;}
		else if (Object == false) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}
	public static int IsFalse(bool Object, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"IsFalse: {Object} is False");

		if (Object == false) {result = 1;}
		else if (Object == true) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}

// Type
	public static int IsType(object ObjectA, object ObjectB, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"IsType: {ObjectA} is the typeof {ObjectB}");

		if (ObjectA.GetType() == ObjectB.GetType()) {result = 1;}
		else if (ObjectA.GetType() != ObjectB.GetType()) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}
	public static int IsNotType(object ObjectA, object ObjectB, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"IsNotType: {ObjectA} is not the typeof {ObjectB}");

		if (ObjectA.GetType() != ObjectB.GetType()) {result = 1;}
		else if (ObjectA.GetType() == ObjectB.GetType()) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}

// Null
	public static int IsNull(object Object, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"IsNull: {Object} is null");

		if (Object == null) {result = 1;}
		else if (Object != null) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}
	public static int IsNotNull(object Object, string message="") {
		int result;

		Console.WriteLine(message);
		Console.WriteLine($"IsNotNull: {Object} is not null");

		if (Object != null) {result = 1;}
		else if (Object == null) {result = 0;}
		else {result = -1;}

		PrintResult(result);
		return result;
	}
}
}