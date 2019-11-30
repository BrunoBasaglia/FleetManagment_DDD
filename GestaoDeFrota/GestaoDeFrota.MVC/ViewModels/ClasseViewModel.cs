using System.ComponentModel.DataAnnotations;

namespace GestaoDeFrota.MVC.ViewModels
{
    public class ClasseViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Classificação")]
        public string Classificacao { get; private set; }
    }
}
