using Consecionaria.Models.Logica;
using System.Collections.Generic;

namespace Consecionaria.Models
{
    public class HomeViewModel
    {
        public List<Auto> Autos { get; set; }

        public HomeViewModel()
        {
            Autos = new List<Auto>();
        }
    }
}