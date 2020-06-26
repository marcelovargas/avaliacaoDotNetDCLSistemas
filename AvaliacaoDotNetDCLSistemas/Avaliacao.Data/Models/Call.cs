namespace Avaliacao.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Call
    {
        public int Id { get; set; }

        [Display(Name = "Inicio")]
        public DateTime Begin { get; set; }

        [Display(Name = "Fim")]
        public DateTime End { get; set; }

    }
}
