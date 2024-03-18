using System;
using System.Collections.Generic;



using System;
using System.Collections.Generic;

public abstract class UserError
{
    public abstract string UEMessage();
}


public class CustomError1 : UserError
{
    public override string UEMessage()
    {
        return "Custom Error 1 message.";
    }
}

public class CustomError2 : UserError
{
    public override string UEMessage()
    {
        return "Custom Error 2 message.";
    }
}

public class CustomError3 : UserError
{
    public override string UEMessage()
    {
        return "Custom Error 3 message.";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<UserError> errors = new List<UserError>
        {
            new NumericInputError(),
            new TextInputError(),
            new CustomError1(),
            new CustomError2(),
            new CustomError3()
        };

        foreach (var error in errors)
        {
            Console.WriteLine(error.UEMessage());
        }
    }
}
