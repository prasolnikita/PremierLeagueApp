namespace PremierLeagueApp.Domain.SharedKernel
{
    public abstract class BaseEntity<TId> : IEntity
    {
        public TId Id { get; protected set; } = default!;
    }
}
