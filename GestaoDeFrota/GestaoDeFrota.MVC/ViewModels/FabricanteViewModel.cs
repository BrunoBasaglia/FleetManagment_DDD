using System.ComponentModel.DataAnnotations;

namespace GestaoDeFrota.MVC.ViewModels
{
    public class FabricanteViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Marca")]
        public string Nome { get; set; }
        public int ModeloId { get; set; }
    }
}
