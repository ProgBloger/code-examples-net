namespace VisitorForMongoDb.Core.Entities
{
    public class QuestionBaseEntity
    {
        public string Prompt { get; set; } = string.Empty;
        public int Order { get; set; }
    }
}
