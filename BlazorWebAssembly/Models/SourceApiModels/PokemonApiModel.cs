namespace BlazorWebAssembly.Models.SourceApiModels
{
    public class PokemonApiModel
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public int Base_experience { get; set; }
        public int Height { get; set; }
        public int Order { get; set; }
        public int Weight { get; set; }
        public SpriteApiModel Sprites { get; set; }
        public LookUpApiModel Species{ get; set; }
        public List<AbilityLookUpApiModel> Abilities { get; set; }
        public List<MoveLookUpApiModel> Moves { get; set; }
        public List<StatLookUpApiModel> Stats { get; set; }
        public List<HeldItemLookUpApiModel> Held_items { get; set; }
    }
}
