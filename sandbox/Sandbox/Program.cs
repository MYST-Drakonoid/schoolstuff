using System;

class program
{
    static void Main(string[] args)
    {
        Builder.Services.AddScoped<ICSVService, CSVService>();
    }
}
    