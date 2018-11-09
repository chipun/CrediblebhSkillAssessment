using System;
using System.Linq;

namespace Credible.WebApp.Models
{
    public interface IPagination<T> where T:class
    {

        IQueryable<T> GetPaginated(string filter, int initalPage, int pageSize, out int totalRecords, out int recordsFiltered);
    }
}
