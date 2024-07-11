
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comandas
{
    public class Usuario
    {
        // propriedades da classe 
        // colunas da tabela usuarios
        [Key] // chave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // 
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty ;

        [Required]
        public string Senha{ get; set; } = string.Empty ;
        

    }
}
