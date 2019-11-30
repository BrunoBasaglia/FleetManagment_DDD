using System.ComponentModel.DataAnnotations;

namespace GestaoDeFrota.MVC.ViewModels
{
    public class MotorViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Motorização")]
        public string Motorizacao { get; private set; }
    }
}
