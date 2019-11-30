using System.ComponentModel.DataAnnotations;

namespace GestaoDeFrota.MVC.ViewModels
{
    public class CategoriaViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Categoria")]
        public string Tipo { get; private set; }
    }
}
