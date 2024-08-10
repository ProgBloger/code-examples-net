namespace VisitorForMongoDb.Core.Entities
{
    public class QuestionBase
    {
        public string Prompt { get; set; } = string.Empty;
        public int Order { get; set; }
    }
}
