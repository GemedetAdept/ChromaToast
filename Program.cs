// Initalize logistic function to fit value(s) to

double curveMaximumValue = 0.0; // K
double curveMinimumValue = 0.0; // A

double curveGrowthRate = 0.0; // r
double curveTweakRate = 0.0; // n

double curveAbscissaMidpoint = 0.0; // x₀

double rawValue = 0.0; // x
double fittedValue = 0.0;


curveMaximumValue = 360.0;
curveMinimumValue = 30.0;
curveGrowthRate = 0.9;
curveTweakRate = 0.05;
curveAbscissaMidpoint = 0.0;

rawValue = 267;

fittedValue =
	(curveMaximumValue - curveMinimumValue) / 
	(1 + Math.Pow(Math.E, -(curveGrowthRate * rawValue * curveTweakRate - curveAbscissaMidpoint)))
	+ curveMinimumValue
;

// Console.WriteLine(fittedValue);

// Convert an inputted number to a different base

double inputValue = 255.0;
double inputBase = 10.0;
double outputBase = 16.0;

double quotient = inputValue / outputBase;
double remainder = inputValue % outputBase;
double remainderSub = remainder / outputBase;
double fractalInput = quotient - remainderSub;

Console.WriteLine($@"
{inputValue}
{inputBase}
{outputBase}

{quotient}
{remainder}
{remainderSub}
{fractalInput}

base16 values = {fractalInput}, {remainder}
");