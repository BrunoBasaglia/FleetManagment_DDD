using System.ComponentModel.DataAnnotations;

namespace GestaoDeFrota.MVC.ViewModels
{
    public class QuilometragemViewModel
    {
        public int Id { get; set; }
        [Display(Name ="Km Atual")]
        public float Atual { get; private set; }
        public float Anterior { get; private set; }
    }
}
