# Simple Arithmetic Calculator (C#)

## Overview
This program reads a single line of input containing three values separated by spaces:

operator left_integer right_integer

The operator must be one of the following:

- `+` addition  
- `-` subtraction  
- `*` multiplication  
- `/` division  
- `%` modulo  

The program applies the operator to the two integers and prints the result.

---

## Example

Input:
* 2 5

Output:
10

---

## How It Works

1. The program reads one line using `Console.ReadLine()`.
2. The input is split into three parts using `Split()`.
3. The two numbers are converted from strings to integers using `int.TryParse()`.
4. A `switch` statement determines which arithmetic operation to perform.
5. The result is printed to the console.

---

## Error Handling

- If the line cannot be read, the program prints:
  Error reading line.

- If the operator is not valid, the program prints:
  Invalid operator X.

---

## Notes

- All input values must be separated by a single space.
- The program assumes valid division and modulo operations (no division by zero unless specified).
