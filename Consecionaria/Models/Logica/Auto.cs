namespace Consecionaria.Models.Logica
{
    public class Auto
    {
        public Auto()
        {
            Puertas = 4;
        }

        public string Marca { get; set; }
        public string Año { get; set; }
        public int KM { get; set; }
        public int Puertas { get; set; }

        public int GetPuertas()
        {
            return Puertas;
        }
    }
}