namespace TiroAlBlancoModel
{
    public interface IPartida
    {

        IUsuario Usuario { get; set; }

        IObjetivo Objetivo { get; set; }

        int NumDisparos { get; set; }

        double DistanciaRelativaImpacto { get; set; }

        bool ObjetivoAlcanzado { get; set; }

        void DispararMisil(IMisil misil);
    }
}