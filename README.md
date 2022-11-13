# Development Test Yujuu

The challenge is to implement a domain model for an algebraic expression in multiple variables, including polynomials, trigonometric functions, exponentials, and sums or products of these, e.g. sin(x12) + x3cos(x2) + 42.
Include a function evaluate that accepts an expression and an array of floating point values that returns the result of evaluating the expression with the array of values.
Include a function partialDerivative that accepts an expression and one of the variables and returns another expression representing the partial derivative of the input expression

## Initial Gaps
- No Base concepts to build a base approach from scratch to work with algebraic expressions
- Less than 48 hours to work on it

## Research 

Checking some alternatives y internet was found a symbolic algebra library for C#
https://am.angouri.org/

This library includes some basic approach that is needed to resolve in this challenge:
1. Convert string in an expression that could be manipulated
2. Applied partial derivative in an algebraic expression
3. Handle variable substitution and evaluation in algebraic expression

With this in mind, this library could be used as base code to build initial two methods 
asked to be added on this test

## What I did

1. Using this library I implemented a MathTest class with two methods EvalExpression and PartialDerivative
which resolve the approach asked for the test.
2. Additionally I implemented a SIMPLE workflow to test it in a Console application.
