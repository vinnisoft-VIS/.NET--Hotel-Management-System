namespace DataViewModel
{
    public class CovidDeclarationModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int WorkingFromHome { get; set; }
        public int Symptomatic { get; set; }
        public int DeclarationSigned { get; set; }
        public string Name { get; set; }
    }
}
