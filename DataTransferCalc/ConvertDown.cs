using System;

public class ConvertDown
{
    public string findType(string input)
    {
        string type = "";

        if (input.Contains("Kb"))
        {
            type = "Kb";
        }
        if (input.Contains("KB") || input.Contains("kb"))
        {
            type = "KB";
        }
        if (input.Contains("Mb"))
        {
            type = "Mb";
        }
        if (input.Contains("MB") || input.Contains("mb"))
        {
            type = "MB";
        }
        if (input.Contains("Gb"))
        {
            type = "Gb";
        }
        if (input.Contains("GB") || input.Contains("gb"))
        {
            type = "GB";
        }
        if (input.Contains("Tb"))
        {
            type = "Tb";
        }
        if (input.Contains("TB") || input.Contains("tb"))
        {
            type = "TB";
        }

        return type;
    }

    public double ConvertToBytes(string numbersAsString, string type)
    {

        double value = 0; //placeholder value

        if (numbersAsString.Length > 0) //checks if it found numbers, otherwise try again
            value = Convert.ToDouble(numbersAsString);
        else
        {
            Console.WriteLine("Try again please, enter a valid value.");
        }


        switch (type)
        {
            case "":
                Console.WriteLine("Switch 'Type' received a null input.");
                Console.ReadLine();
                break;
            case "Kb":
                return (value * 125);
            case "KB":
                return (value * 1000);
            case "Mb":
                return (value * 125000);
            case "MB":
                return (value * 1e+6);
            case "Gb":
                return (value * 1.25e+8);
            case "GB":
                return (value * 1e+9);
            case "Tb":
                return (value * 1.25e+11);
            case "TB":
                return (value * 1e+12);
            default:
                Console.WriteLine("Try again.");
                Console.ReadLine();
                break;
        }

        return 0; //placeholder, should never need this
    }

    public string retrieveNumbers(string input)
    {
        string numbersAsString = "";

        for (int i = 0; i < input.Length; i++) // goes through each char of the input string searching for digits, concatenates into a string
        {
            if (Char.IsDigit(input[i]))
                numbersAsString += input[i];
            if (input[i] == '.')
                numbersAsString += input[i];
        }

        return numbersAsString;
    }
    
}