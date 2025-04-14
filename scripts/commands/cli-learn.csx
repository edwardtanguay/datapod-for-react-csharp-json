#load "../classes/Learn.csx"
using System;
using System.Reflection;

if (Args.Count == 0)
{
	Console.WriteLine("Please provide an exercise ID as an argument, e.g., 'npm run learn 001'.");
	return;
}

var exercise = $"EX{Args[0]}";

var methodName = exercise;
var learnType = typeof(Learn);
var method = learnType.GetMethod(methodName, BindingFlags.Static | BindingFlags.Public);

if (method != null)
{
	method.Invoke(null, null);
}
else
{
	Console.WriteLine($"Method {methodName} not found in Learn class.");
}
