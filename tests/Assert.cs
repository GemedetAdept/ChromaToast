namespace tests {
public class Assert {

	public int AreEqual(object ObjectA, object ObjectB) {

		if (ObjectA == ObjectB) {return 1;}
		else if (ObjectA != ObjectB) {return 0;}
		else {return -1;}
	}
}
}