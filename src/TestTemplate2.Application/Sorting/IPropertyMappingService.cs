using System.Collections.Generic;
using TestTemplate2.Application.Sorting.Models;

namespace TestTemplate2.Application.Sorting
{
    public interface IPropertyMappingService
    {
        IEnumerable<SortCriteria> Resolve(BaseSortable sortableSource, BaseSortable sortableTarget);
    }
}
