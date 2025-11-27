using Microsoft.EntityFrameworkCore;
namespace PetShop.Helpers.Pagination
{
    public static class QueryableExtensions
    {
        public static async Task<PageResult<T>> PaginateAsync<T>(
            this IQueryable<T> query,
            PageRequest request)
        {
            var result = new PageResult<T>();
            result.PageNumber = request.PageNumber;
            result.PageSize = request.PageSize;

            result.TotalItems = await query.CountAsync();

            result.Items = await query
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync();

            return result;
        }
    }
}
