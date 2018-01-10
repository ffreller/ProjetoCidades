using System.Collections.Generic;

namespace ProjetoCidades.Models
{
    public class Cidade
    {
        public int id { get; set; } 
        public string nome { get; set; }
        public string estado { get; set; }
        public int habitantes { get; set; }

        public List<Cidade> ListarCidades()
        {
            List<Cidade> cidade = new List <Cidade>()
            {
                new Cidade {id= 10, nome = "Curitiba", estado = "Paraná", habitantes = 1235},
                new Cidade {id= 17, nome = "Bertioga", estado = "São Paulo", habitantes = 1576},
                new Cidade {id= 90, nome = "Porto Alegre", estado = "Rio Grande do Sul", habitantes = 1275},
                new Cidade {id= 87, nome = "Ponta Grossa", estado = "Paraná", habitantes = 3452},
                new Cidade {id= 34, nome = "Campinas", estado = "São Paulo", habitantes = 456},
                new Cidade {id= 20, nome = "Salvador", estado = "Bahia", habitantes = 2342},
            };
            return cidade;
        }
    }
}