using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EEstoque.Model
{
    public class Proporcao
    {
        [Key]
        public int Id { get; set; }
        public string Proporcaos { get; set; }

        public List<Proporcao> ListarProporcaos()
        {
            return new List<Proporcao>
            {
                 new Proporcao{ Id = 1, Proporcaos = "gr" },
                 new Proporcao{ Id = 2, Proporcaos = "kg" },
                 new Proporcao{ Id = 3, Proporcaos = "ton" }
            };
        }
    }
}