// See https://aka.ms/new-console-template for more information


int Inicio = 11098;
int Fin = 98123;

List<int> NumerosValidos = new();

for (int i = Inicio; i <= Fin; i++){
    string numeroString = i.ToString();
    int numeroAnterior = 0;
    bool cumpleSecuencia = true;
    int numeroDeCincos = 0;
    foreach (char c in numeroString) {
        int numero = int.Parse(c.ToString());
        if (numero == 5) numeroDeCincos++;
        if (numero < numeroAnterior) {
            cumpleSecuencia = false;
            break;
        }
        numeroAnterior = numero;
    }
    if (cumpleSecuencia && numeroDeCincos >= 2){
        NumerosValidos.Add(i);
    }
}

Console.WriteLine(NumerosValidos.Count);
Console.WriteLine(NumerosValidos[55]);