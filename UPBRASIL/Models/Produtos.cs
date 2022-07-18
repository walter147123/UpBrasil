using System;

namespace UPBRASIL.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public DateTime Data { get; set; } 
    }
}
