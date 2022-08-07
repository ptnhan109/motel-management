﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Motel.Common.Generics
{
    public class PagedResult<TEntity>
    {
        public IReadOnlyList<TEntity> Items { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; } = 10;
        public int TotalCount { get; set; }
        public int TotalPage => (int)Math.Ceiling(TotalCount / (double)PageSize);

        public PagedResult<TDto> ChangeType<TDto>(Func<TEntity, TDto> cast)
        {
            return new PagedResult<TDto>
            {
                Items = Items.Select(cast).ToList(),
                PageIndex = PageIndex,
                PageSize = PageSize,
                TotalCount = TotalCount
            };
        }
    }
}
