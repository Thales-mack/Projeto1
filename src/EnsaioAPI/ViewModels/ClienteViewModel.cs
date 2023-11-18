namespace EnsaioAPI.ViewModels
{
    public class ClienteViewModel
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
    }
    public class ClienteViewModelResponse : ClienteViewModel
    {
        public int Id { get; set; }
    }
}
