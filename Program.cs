﻿/*
// Console.WriteLine("Hello, World!");


int age = 26;
string name = "Meghann";
bool isHere = true;
double salary = 22000.01;


Console.WriteLine($"Hi, {name}. Your age is {age} and is here? {isHere}");
Console.WriteLine($"And you make ${salary} a year");
*/

try { 
savingsAccount myAccount 
= new savingsAccount(300);


// myAccount.balance = 300;

    Console.Write($"Your balance is");
    Console.Write(myAccount.getBalance());

    Console.WriteLine(" and you are good looking");
} catch (Exception ex) {
    Console.WriteLine($"We got an error: {ex.Message}");
}