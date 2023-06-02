# ChromaToast | C# Color Palette Generator

_This project began as a college project for CS1400 with Jasmine Carrasco and Chad Miller._

Example of the console application, operated via arrow keys and Enter. The resulting palette is stored in the repository as `example_output.csv`. The colors are included below in a hand-made image, these are currently not generated automatically.

![Simple demonstration of ChromaToast](https://i.imgur.com/NpefxNH.gif)
![Generated tetradic palette](https://i.imgur.com/DyNVvNd.png)

## Custom Unit Testing Framework

### Why Make a Custom Framework?
Two reasons I'm creating this instead of using one of the many unit testing frameworks:
1. I've loaned this machine from the engineering department and do not have the admin permissions to install all the framework dependencies needed.
2. I frankly like making my own things.


### Current Assert Methods
* PrintResult
	- Driver for displaying unit test results based on the Assert outcome.

* (int)IsGreaterThan
* (int)IsGreaterThanOrEqual
* (int)IsLessThan
* (int)IsLessThanOrEqual
* (int)IsEqual
* (int)IsNotEqual
* (int)IsPositive
* (int)IsNegative

* (double)IsGreaterThan
* (double)IsGreaterThanOrEqual
* (double)IsLessThan
* (double)IsLessThanOrEqual
* (double)IsEqual
* (double)IsNotEqual
* (double)IsPositive
* (double)IsNegative

* (string)IsEqual
* (string)IsNotEqual

* (bool)IsTrue
* (bool)IsFalse

* (Type)IsType
* (Type)IsNotType

* (Null)IsNull
* (Null)IsNotNull