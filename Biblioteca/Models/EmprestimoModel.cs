using System;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class EmprestimoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, insira o nome do Recebedor.")]
        public string Recebedor { get; set; } = "";

        [Required(ErrorMessage = "Por favor, insira o nome do Fornecedor.")]
        public string Fornecedor { get; set; } = "";

        [Required(ErrorMessage = "Por favor, insira o nome do Livro.")]
        public string LivroEmprestado { get; set; } = "";

        public DateTime? DataAtualizacao { get; set; }


    }
}
