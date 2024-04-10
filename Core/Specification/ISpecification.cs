using System.Linq.Expressions;
namespace Core.Specification
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
        public int Take { get; }

        public int Skip { get; }
        bool IsPagingEnabled { get; }

    }
}
