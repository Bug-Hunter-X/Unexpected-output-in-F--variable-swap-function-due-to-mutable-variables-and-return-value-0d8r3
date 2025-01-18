# F# Mutable Variable Swap Bug

This repository demonstrates a common error in F# when working with mutable variables and functions that don't explicitly return modified values. The code attempts to swap two mutable variables using a function, but due to the way mutable variables are handled and the absence of an explicit return statement, the swap operation doesn't produce the expected result.

## Bug Description
The `swap` function correctly swaps the values of the two mutable variables using a temporary variable. However, because the function doesn't explicitly return the updated values, the original variables remain unchanged in the main code.  This leads to unexpected output.

## How to reproduce
1. Clone this repository.
2. Compile and run `bug.fs`.
3. Observe the output is not as expected, showcasing the bug.
4. Run `bugSolution.fs` to observe the corrected implementation.

## Solution
The solution involves returning the swapped values from the `swap` function as a tuple. This ensures that the updated values are used in the main code, providing the expected output.
