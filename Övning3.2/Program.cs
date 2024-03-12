// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Övning3._2;

public abstract class UserError
{
    public abstract string UEMessage();

    static void Main(string[] args)
    {
        // Skapa en lista med UserErrors och fyll den med instanser av NumericInputError och TextInputError
        List<UserError> errors = new List<UserError>
        {
            new NumericInputError(),
            new TextInputError()
        };

        // Skriv ut UEMessage för varje objekt i listan genom en foreach-loop
        foreach (UserError error in errors)
        {
            Console.WriteLine(error.UEMessage());
        }

        // Skapa tre egna klasser med tre egna definitioner på UEMessage
        // Exempel:
        //class CustomError1 : UserError
        //{
        //    public override string UEMessage()
        //    {
        //        return "This is CustomError1 message.";
        //    }
        //}

        //class CustomError2 : UserError
        //{
        //    public override string UEMessage()
        //    {
        //        return "This is CustomError2 message.";
        //    }
        //}

        //class CustomError3 : UserError
        //{
        //    public override string UEMessage()
        //    {
        //        return "This is CustomError3 message.";
        //    }
        //}
    }
}