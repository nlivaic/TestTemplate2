﻿using System.Collections.Generic;
using TestTemplate2.Application.Sorting.Models;

namespace TestTemplate2.Application.Tests.Helpers
{
    public class ResourceParameters2
        : BaseSortable<MappingSourceModel2>
    {
        public override IEnumerable<SortCriteria> SortBy { get; set; } = new List<SortCriteria>();
    }
}
