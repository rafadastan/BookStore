using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.ViewModels
{
    public class EditorBookViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name= "Nome do Livro")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "*")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Data do Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "*")]
        public int CategoriaId { get; set; }
        
        public SelectList CategoriasOptions { get; set; }
    }
}