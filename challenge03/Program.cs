// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

string texto = System.IO.File.ReadAllText("colors.txt");
Regex pattern = new Regex("[ [\\]\n\"]");
string textoSeparadoPorComas = pattern.Replace(texto, "");
string[] colores = textoSeparadoPorComas.Split(',');

List<Zebra> zebras = new();
int cont = 0;
string UltimoColor = "";
string PrimerColor = "";

foreach (string color in colores) {
    if (UltimoColor == "") {
        UltimoColor = color;
    } else if (UltimoColor == color || (PrimerColor != "" && PrimerColor != color)) {
        zebras.Add(new() {
            UltimoColor = UltimoColor,
            Longitud = cont
        });
        PrimerColor = UltimoColor;
        UltimoColor = color;
        cont = 1;
    } else {
        PrimerColor = UltimoColor;
        UltimoColor = color;
    }
    cont++;
}

if (cont > 0 ) {
    zebras.Add(new() {
        UltimoColor = UltimoColor,
        Longitud = cont
    });
}


Console.WriteLine($"{zebras.Count} zebras");
Zebra zebra = zebras.OrderByDescending(z => z.Longitud).First();
Console.WriteLine($"Longitud: {zebra.Longitud} - Ulrimo color: {zebra.UltimoColor}");
