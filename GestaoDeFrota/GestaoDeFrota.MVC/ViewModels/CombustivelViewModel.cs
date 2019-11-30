using System.ComponentModel.DataAnnotations;

namespace GestaoDeFrota.MVC.ViewModels
{
    public class CombustivelViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Combustível")]
        public string Nome { get; private set; }
    }
}
