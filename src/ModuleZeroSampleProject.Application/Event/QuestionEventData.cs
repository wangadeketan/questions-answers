using Abp.Events.Bus;
using System.Threading.Tasks;

namespace ModuleZeroSampleProject.Event
{
    public class QuestionEventData : EventData
    {
        public Task Task { get; set; }
    }
}
