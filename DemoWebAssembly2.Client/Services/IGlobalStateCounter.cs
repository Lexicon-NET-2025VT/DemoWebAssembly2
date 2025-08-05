
namespace DemoWebAssembly2.Client.Services
{
    public interface IGlobalStateCounter
    {
        int Counter { get; set; }

        event Action? OnChange;

        void Increment(int step);
    }
}