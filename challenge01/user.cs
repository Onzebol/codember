using System.Reflection;

class user {
    public string? usr {get; set;}
    public string? eme {get; set;}
    public string? psw {get; set;}
    public string? loc {get; set;}
    public string? age {get; set;}
    public string? fll {get; set;}

    public bool esValido() {
        return usr is not null &&
            eme is not null &&
            psw is not null &&
            loc is not null &&
            age is not null &&
            fll is not null;
    }
}