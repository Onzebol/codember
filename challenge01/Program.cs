// See https://aka.ms/new-console-template for more information

string[] lineas = File.ReadAllLines("users.txt");
string usuarioActual = "";
int contadorUsuarios = 0;
foreach (string linea in lineas) {
    if (string.IsNullOrEmpty(linea)) {
        user user = new();
        string[] propiedades = usuarioActual.Trim().Split(" ");
        foreach (string propiedad in propiedades) {
            string[] claveValor = propiedad.Split(":");
            user.GetType().GetProperty(claveValor[0])?.SetValue(user, claveValor[1]);
        }
        if (user.esValido()) {
            contadorUsuarios++;
            Console.WriteLine($"{contadorUsuarios} - {usuarioActual}");
        }
        usuarioActual="";
    }
    usuarioActual += $"{linea} ";
}


