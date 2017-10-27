using System;
using System.IO;
public class switchLearning
{
    public static void Main()
    {
        Console.Write("Input day name(sun,mon,tue,wed,thu,fri and sat): ");
        string dayString =  Console.ReadLine();
        string message;
        switch (dayString)
        {
            case "Sun":
                message = "sun is sunday ,color red";
                break;
            case "Mon":
                message = "Mon is Monday ,color yellow";
                break;
            case "Tue":
                message = "Tue is tueday ,color pink";
                break;
            case "Wed":
                message = "wed is wednwsday ,color green";
                break;
            case "thu":
                message = "thu is thursday ,color orange";
                break;
            case "Fri":
                message = "fri is friday ,color blue";
                break;
            case "sat":
                message = "sat is saturday ,color purple";
                break;
            default:
                message = "Incorrect day name";
                break;
        }
        Console.WriteLine(message); 
    }
}
