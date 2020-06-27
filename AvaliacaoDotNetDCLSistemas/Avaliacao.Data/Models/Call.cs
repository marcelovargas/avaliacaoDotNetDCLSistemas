namespace Avaliacao.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Call
    {
        public int Id { get; set; }

        [Display(Name = "Inicio")]
        public TimeSpan Begin { get; set; }

        [Display(Name = "Fim")]
        public TimeSpan End { get; set; }

    }
}
