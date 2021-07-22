namespace Scripts.Locomotion
{
    public interface IInputHandler
    {
        float tankHorizontal { get; }
        float tankVertical { get; }
        float turrentHorizontal { get; }
        float turrentVertical { get; }
        bool canFire { get; }
    }
}