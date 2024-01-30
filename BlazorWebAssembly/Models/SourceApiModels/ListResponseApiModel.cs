namespace BlazorWebAssembly.Models.SourceApiModels
{
    public class ListResponseApiModel<T> where T : class
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public T[] Results { get; set; }
    }
}
