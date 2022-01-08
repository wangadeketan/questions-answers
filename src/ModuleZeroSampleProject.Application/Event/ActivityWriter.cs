using Abp.Dependency;
using Abp.Events.Bus.Handlers;
using Castle.Core.Logging;

namespace ModuleZeroSampleProject.Event
{
    public class ActivityWriter : 
        IEventHandler<QuestionEventData>,
        ITransientDependency
    {
        public ILogger Logger { get; set; }
        public void HandleEvent(QuestionEventData eventData)
        {
            if (eventData is QuestionCreatedEvent)
            {
                Logger.Debug("Question created event occur");
            }
        }
    }
}
