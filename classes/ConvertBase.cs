namespace convertbase {
public class ConvertBase {
	public static int ConvertToInteger(string hexadecimal) {
	List<int> values = new List<int>();
	double intValue = 0;
	char[] nubmers = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };


	foreach (char letter in hexadecimal)
	{
		if (nubmers.Contains(letter)) {values.Add(Convert.ToInt32(letter) - 48);}
		else if (letter == 'A') {values.Add(10);}
		else if (letter == 'B') {values.Add(11);}
		else if (letter == 'C') {values.Add(12);}
		else if (letter == 'D') {values.Add(13);}
		else if (letter == 'E') {values.Add(14);}
		else if (letter == 'F') {values.Add(15);}
	}
	int y = 0;
	for (int i = 5; i >= 0; i--) {

		intValue = intValue + values[y] * Math.Pow(16d, i);
		y++;
	}
	return Convert.ToInt32(intValue);
}

public static string ConvertToHexadecimal(int integer) {
	string hexadecimal = integer.ToString("X");
	return hexadecimal;
}
}
}