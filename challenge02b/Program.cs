// See https://aka.ms/new-console-template for more information

Console.WriteLine("Introduce el texto encriptado: ");
string textoEncriptado = Console.ReadLine();

string[] palabrasEncriptadas = textoEncriptado.Trim().Split(" ");
List<string> palabras = new ();

foreach (string palabraEncriptada in palabrasEncriptadas) {
    int posicion = 0;
    string palabra = "";
    while (posicion < palabraEncriptada.Length) {
        string ascii = "";
        if (palabraEncriptada.Substring(posicion, 1) != "1") {
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