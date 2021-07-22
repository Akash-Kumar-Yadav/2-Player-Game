namespace Scripts.Core
{
    public interface IHealth
    {
        bool IsDead { get; }

        void TakeDamage(int damage);
    }
}