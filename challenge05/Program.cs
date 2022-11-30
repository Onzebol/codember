// See https://aka.ms/new-console-template for more information

string[] nombres = System.Text.Json.JsonSerializer.Deserialize<string[]>(System.IO.File.ReadAllText("mecenas.json"));

int i = 0;
while (nombres.Count(n => n == "X") < nombres.Length - 1) {
    do {
        i++;
        if (i == nombres.Length) i = 0;
    } while (nombres[i] == "X");
    nombres[i] = "X";
    do {
        i++;
        if (i == nombres.Length) i = 0;
    } while (nombres[i] == "X");
}

string ganador = nombres.First(n => n !="X");
Console.WriteLine($"{ganador} - {Array.IndexOf(nombres, ganador)}");
