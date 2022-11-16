// See https://aka.ms/new-console-template for more information

string textoEncriptado = File.ReadAllText("encrypted.txt");
Console.WriteLine(textoEncriptado);

string[] palabrasEncriptadas = textoEncriptado.Split(" ");
List<string> palabras = new ();

foreach (string palabraEncriptada in palabrasEncriptadas) {
    int posicion = 0;
    string palabra = "";
    while (posicion < palabraEncriptada.Length) {
        string ascii = "";
        if (palabraEncriptada.Substring(posicion, 1) == "9") {
            ascii = palabraEncriptada.Substring(posicion, 2);
            posicion += 2;
        } else {
            ascii = palabraEncriptada.Substring(posicion, 3);
            posicion += 3;
        }
        palabra += (char)int.Parse(ascii);
    }
    palabras.Add(palabra);
}

Console.WriteLine(string.Join(" ", palabras));