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

Console.WriteLine(fittedValue);