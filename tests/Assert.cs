namespace tests {
public class Assert {

	public static int Int32AreEqual(int ObjectA, int ObjectB) {

		if (ObjectA == ObjectB) {return 1;}
		else if (ObjectA != ObjectB) {return 0;}
		else {return -1;}
	}

	public static int BoolTrue(bool Object) {

		if (Object == true) {return 1;}
		else if (Object == false) {return 0;}
		else {return -1;}
	}

	public static int BoolFalse(bool Object) {

		if (Object == false) {return 1;}
		else if (Object == true) {return 0;}
		else {return -1;}
	}
}
}