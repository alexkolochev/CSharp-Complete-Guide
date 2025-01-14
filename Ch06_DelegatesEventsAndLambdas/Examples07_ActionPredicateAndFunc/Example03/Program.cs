﻿// Func
int result1 = DoOperation(6, DoubleNumber);
Console.WriteLine(result1);

int result2 = DoOperation(6, SquareNumber);
Console.WriteLine(result2);

int DoOperation(int n, Func<int, int> operation) => operation(n);
int DoubleNumber(int n) => 2 * n;
int SquareNumber(int n) => n * n;
