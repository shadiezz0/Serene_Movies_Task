namespace Serene_Movies_Task.Administration;

public class TranslationListRequest : ListRequest
{
    public string SourceLanguageID { get; set; }
    public string TargetLanguageID { get; set; }
}