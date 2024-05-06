namespace Serene_Movies_Task.Administration;


public class TranslationUpdateRequest : ServiceRequest
{
    public string TargetLanguageID { get; set; }
    public Dictionary<string, string> Translations { get; set; }
}