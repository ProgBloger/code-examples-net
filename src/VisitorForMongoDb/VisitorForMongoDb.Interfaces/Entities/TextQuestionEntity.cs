namespace VisitorForMongoDb.Core.Entities
{
    public class TextQuestionEntity : QuestionBaseEntity
    {
        public string Answer { get; set; } = string.Empty;
    }
}
