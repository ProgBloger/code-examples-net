namespace VisitorForMongoDb.Core.Entities
{
    public class FormEntity
    {
        public Guid Id { get; set; }
        public List<QuestionBaseEntity> ListOfQuestions { get; set; } = [];
    }
}
