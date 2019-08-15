namespace EsolCoreApp.Infrastructure.ShareKernel
{
    public interface IDomainEntity<T>
    {
        T Id { get; set; }

        bool IsTransient();
    }
}