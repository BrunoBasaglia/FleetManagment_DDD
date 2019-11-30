namespace GestaoDeFrota.MVC.ViewModels
{
    public class ImagemViewModel
    {
        public int Id { get; set; }
        public string Arquivo { get; set; }
        public string Diretorio { get; private set; }
        public string Extensao { get; private set; }
    }
}
