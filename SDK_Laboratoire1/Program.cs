using LibrairieConversionNote;


bool game = true;

while (true)
{
    Console.WriteLine("Quelle type de conversion voulez-vous faire ?");

    while (game == true)
    {
        Console.WriteLine("Note a convertir:");

        string input = Console.ReadLine().ToUpper();


        string output = new ConversionAlphabetiqueToNote().Transformer(input);


        Console.WriteLine(output);
    }
}