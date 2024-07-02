using System;
namespace LanchesMac.Models
{
	public class Categoria
	{
		
		public int CategoriaId { get; set; }
		public string CategoriaNome { get; set; }
        public string Descrição { get; set; }

		//para identificar o relacionamento entre categoria e lanches
		public List<Lanche> Lanches { get; set; }


}
	
}


