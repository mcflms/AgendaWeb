
using System.ComponentModel.DataAnnotations;

namespace AgendaWeb.Presentation.Models
{
    /// <summary>
    /// Classe de modelo de dados para a pagína de cadastro eventos
    /// </summary>
    public class EventoCadastroViewModel
    {
        [MinLength(6, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1}caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o Nome do evento.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe a Data do evento.")]
        public string? Data { get; set; }

        [Required(ErrorMessage = "Por favor, informe a Hora do evento.")]
        public string? Hora { get; set; }

        [MaxLength(500, ErrorMessage = "Por favor, informe no minimo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a descrição do evento.")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "Por favor, informe a Prioridade do evento.")]
        public string? Prioridade { get; set; }
    }


}





