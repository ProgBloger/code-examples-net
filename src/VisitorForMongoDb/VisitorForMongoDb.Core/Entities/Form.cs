namespace VisitorForMongoDb.Core.Entities
{
    public class Form
    {
        public Guid Id { get; set; }
        public List<GradeQuestion> GradeQuestions { get; set; } = new List<GradeQuestion>();
        public List<TextQuestion> TextQuestions { get; set; } = new List<TextQuestion>();
        public List<BinaryQuestion> BinaryQuestions { get; set; } = new List<BinaryQuestion>();

    }
}
