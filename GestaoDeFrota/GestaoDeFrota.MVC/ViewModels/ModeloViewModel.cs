using System.ComponentModel.DataAnnotations;

namespace GestaoDeFrota.MVC.ViewModels
{
    public class ModeloViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Modelo")]
        public string Nome { get; private set; }
    }
}
