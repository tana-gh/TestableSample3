using System.Threading.Tasks;

namespace TestableSample3.Lib
{
    public interface ITaskWrapper
    {
        Task Delay(int milliseconds);
    }
}
