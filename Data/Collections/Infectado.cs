using MongoDB.Driver.GeoJsonObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Data.Collections
{
    public class Infectado
    {
        public DateTime DatadeNascimento { get; set; }
        public string Sexo { get; set; }
        public GeoJson2DGeographicCoordinates Localizacao { get; set; }
        public Infectado(DateTime dataDeNascimento, string sexo, double latitude, double longitude)
        {
            DatadeNascimento = dataDeNascimento;
            Sexo = sexo;
            Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude);
        }
    }
}
