namespace EsolCoreApp.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { get; set; }

    }
}