namespace BlazorWebAssembly.Models.SourceApiModels
{
    public class AbilityLookUpApiModel
    {
        public bool Is_hidden { get; set; }
        public int Slot { get; set; }
        public LookUpApiModel Ability { get; set; }
    }
}
