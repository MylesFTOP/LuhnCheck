# Structure

## Solution
ValidationCore

## Projects
LuhnCheck - core application

LuhnLibrary - class library

LuhnValidationUnitTests - test library
		  
## Classes
Main.cs - main file

LuhnCandidate.cs - number string and related methods
			
## Methods

*AddSuffix* -> *CalculateLuhnDigit*

*ValidateSuffix* -> *CalculateLuhnDigit*

*CalculateLuhnDigit*

# Brief

Taking a numerical string as an input, either calculate a checksum suffix or validate an existing suffix using the Luhn algorithm.

# Pathway

1. Run Luhn algorithm on string

	a. Add Luhn suffix
	
	b. Validate existing Luhn suffix

2. Specific Luhn use cases (e.g. validation for SIM ICCID)

3. Change Luhn type? (e.g. generalised to other bases)
