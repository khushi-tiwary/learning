using System;

int BaseLimit=100;
decimal BaseRate= 0.12m;
decimal ExcessRate= 0.08m;

Console.WriteLine("CUSTOMER BILL GENERATOR");

Console.Write("Enter Customer Name:");
string customerName= Console.ReadLine();
if(string.IsNullOrWhiteSpace(customerName))
{
    customerName= "Unknown Customer";
}
Console.Write("Enter Call Minutes:");
String mins= Console.ReadLine();

if(!decimal.TryParse(mins, out decimal total_mins) || total_mins <0)
{
    Console.WriteLine("Invalid entry for minutes.");
    return;
}

decimal totalCost =0m;
if(total_mins <=BaseLimit)
{
    totalCost= total_mins*BaseRate;
}
else{
    decimal baseCost= BaseLimit * BaseRate;
    decimal excessMins = total_mins-BaseLimit;
    decimal excessCost= excessMins* ExcessRate;
    totalCost= baseCost + excessCost;
}
Console.WriteLine($"{"CUSTOMER",-20} | {"MINUTES",-8} | {"TOTAL BILL",10}");
Console.WriteLine($"{customerName,-20} | {total_mins,-8:N1} | {totalCost,10:C}");

