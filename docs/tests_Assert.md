# tests > Assert

namespace | tests
visibility | public
type | class
name | Assert

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