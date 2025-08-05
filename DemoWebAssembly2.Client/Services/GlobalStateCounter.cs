namespace DemoWebAssembly2.Client.Services
{
    public class GlobalStateCounter : IGlobalStateCounter
    {
        public int Counter { get; set; } = 0;

        public event Action? OnChange;

        public void Increment(int step)
        {
            Counter += step;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();

    }
}
