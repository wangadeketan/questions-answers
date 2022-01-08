using ModuleZeroSampleProject.Questions;

namespace ModuleZeroSampleProject.Event
{
    public class QuestionCreatedEvent : QuestionEventData
    {
        public Question QuestionsCreated { get; set; }

    }
}
