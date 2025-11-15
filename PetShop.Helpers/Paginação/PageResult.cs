using System.Collections.Generic;

namespace PetShop.Helpers.Pagination
{
    public class PageResult<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public int TotalItems { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalItems / PageSize);

        public List<T> Items { get; set; }
    }
}
