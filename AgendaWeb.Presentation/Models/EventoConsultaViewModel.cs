using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace AgendaWeb.Presentation.Models
{
    public class EventoConsultaViewModel
    {
        
        [Required(ErrorMessage = "Por Favor, Informe a Data de Início.")]
        public string? DataMin { get; set; }

        [Required(ErrorMessage = "Por Favor, Informe a Data de Término.")]
        public string? DataMax { get; set; }
    }

}
