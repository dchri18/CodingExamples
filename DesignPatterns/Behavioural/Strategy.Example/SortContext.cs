﻿using Strategy.Example.Interfaces;

namespace Strategy.Example
{
    public class SortContext
    {
        private ISortStrategy _sortStrategy;

        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Sort(List<int> list)
        {
            _sortStrategy.Sort(list);
        }
    }
}
