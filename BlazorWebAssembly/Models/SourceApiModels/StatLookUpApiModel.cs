namespace BlazorWebAssembly.Models.SourceApiModels
{
    public class StatLookUpApiModel
    {
        public int Base_stat { get; set; }
        public int Effort { get; set; }
        public LookUpApiModel Stat { get; set; }
    }
}
