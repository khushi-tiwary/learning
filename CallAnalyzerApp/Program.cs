using System;
using System.Collections.Generic;
using System.Linq;

    public struct CallRecord
{
    public string PhoneNumber { get; }
    public double DurationMins { get; }

    public CallRecord(string phoneNumber, double durationmins)
    {
        PhoneNumber = phoneNumber;
        DurationMins = durationmins;
    }
}
class Program
{
    static void Main()
    {
        List<CallRecord> callHistory = new List<CallRecord>()
        {
            new CallRecord("555-0101", 5.5), new CallRecord("555-0102", 12.0),
            new CallRecord("555-0101", 3.2), new CallRecord("555-0103", 15.4),
            new CallRecord("555-0104", 1.1), new CallRecord("555-0102", 8.5),
            new CallRecord("555-0105", 22.0), new CallRecord("555-0101", 4.0),
            new CallRecord("555-0103", 2.5), new CallRecord("555-0106", 18.3),
            new CallRecord("555-0104", 9.7), new CallRecord("555-0102", 14.2),
            new CallRecord("555-0107", 6.1), new CallRecord("555-0105", 5.0),
            new CallRecord("555-0101", 11.3), new CallRecord("555-0108", 3.8),
            new CallRecord("555-0103", 7.1), new CallRecord("555-0102", 2.0),
            new CallRecord("555-0109", 13.4), new CallRecord("555-0105", 1.5)
        };

        Dictionary<string, double>minspernum= new Dictionary<string, double>();

        foreach(var record in callHistory){
            if(minspernum.ContainsKey(record.PhoneNumber))
            {
                minspernum[record.PhoneNumber]+=record.DurationMins;
            }
            else{
                minspernum[record.PhoneNumber]= record.DurationMins;
            }
        }
        var top3=minspernum
            .OrderByDescending(kvp=>kvp.Value)
            .Take(3);

        Console.WriteLine("TOP 3 PHONE NUMBERS BY TOTAL MINUTES");
        Console.WriteLine($"{"RANK",-6} | {"PHONE NUMBER",-15} | {"TOTAL MINUTES",-15}");
        int rank=1;
        foreach(var entry in top3)
        {
            Console.WriteLine($"{rank,-6}. Phone: {entry.Key, -15} | Total Duration :{entry.Value:F1} mins");
            rank++;
        }
    }
}




