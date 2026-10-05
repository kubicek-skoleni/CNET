string email = "alice.johnson@company.com";

int atIndex = email.IndexOf("john");

Console.WriteLine($"Index of 'john': {atIndex}");

var sub = email.Substring(atIndex, 4);

string filePath = @"C:\Users\Documents\file.txt";

