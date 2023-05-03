# tests > Assert

namespace | tests
visibility | public
type | class
name | Assert

## Test Code
```csharp
	Assert.Int32AreEqual(1, 1);
	Assert.Int32AreEqual(1, 0);
	Assert.Int32AreNotEqual(1, 0);
	Assert.Int32AreNotEqual(1, 1);

	Assert.BoolTrue(true);
	Assert.BoolTrue(false);
	Assert.BoolFalse(false);
	Assert.BoolFalse(true);

	Assert.IsType(true, true);
	Assert.IsType(true, -4.19);
	Assert.IsNotType(true, -4.19);
	Assert.IsNotType(true, true);
```

## Methods
	Assert.Int32AreEqual
	Assert.Int32AreNotEqual
	Assert.BoolTrue
	Assert.BoolFalse
	Assert.IsType
	Assert.IsNotType

### Assert.Int32AreEqual
```csharp
public static int Int32AreEqual(int ObjectA, int ObjectB, string message="") {}
```

```csharp
int ObjectA = 1;
int ObjectB = 1;
string message = "Lorem ipsum"
Assert.Int32AreEqual(ObjectA, ObjectB, message);
```
> Lorem ipsum
> Assert.Int32AreEqual: 1 is equal to 1
> Result = 1