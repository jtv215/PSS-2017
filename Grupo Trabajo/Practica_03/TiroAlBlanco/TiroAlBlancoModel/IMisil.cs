namespace TiroAlBlancoModel
{
    public interface IMisil
    {
        double AnguloSalida { get; }
        double VelocidadInicial { get;  }
        double Alcance { get; }
        double Radio { get; set; }
    }
}