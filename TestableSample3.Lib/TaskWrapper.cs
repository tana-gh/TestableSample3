using System.Threading.Tasks;

namespace TestableSample3.Lib
{
    public class TaskWrapper : ITaskWrapper
    {
        public Task Delay(int milliseconds)
        {
            return Task.Delay(milliseconds);
        }
    }
}
