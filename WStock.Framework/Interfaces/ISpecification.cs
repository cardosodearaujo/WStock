namespace WStock.Framework.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T objeto);
    }
}
