namespace Game.Interfaces
{
    public interface IInputProvider
    {
        public bool IsActive { get; set; }
        void Update();
    }
}