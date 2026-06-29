using System;
using System.Collections.Generic;
using SmartMed.Models;

namespace SmartMed.Services
{
    /// <summary>
    /// Search and sort algorithms over the medicine catalogue. The methods here are
    /// written deliberately explicitly (rather than leaning entirely on LINQ) so the
    /// underlying algorithm and its time complexity are easy to read and explain.
    /// </summary>
    public class SearchService
    {
        // ------------------------------------------------------------------
        //  LINEAR SEARCH / FILTERING  ->  O(n)
        //  We visit every element once and keep the ones that match. This is
        //  the correct choice for substring/contains and range filters because
        //  the data is unsorted with respect to those criteria.
        // ------------------------------------------------------------------

        /// <summary>
        /// Case-insensitive substring search on medicine name. O(n): every medicine is
        /// examined exactly once. An empty/whitespace term returns the whole list.
        /// </summary>
        public List<Medicine> SearchByName(IEnumerable<Medicine> source, string term)
        {
            List<Medicine> results = new List<Medicine>();
            string needle = (term ?? string.Empty).Trim().ToLowerInvariant();

            foreach (Medicine medicine in source)
            {
                if (needle.Length == 0)
                {
                    results.Add(medicine);
                    continue;
                }

                string name = (medicine.Name ?? string.Empty).ToLowerInvariant();
                if (name.Contains(needle)) // linear scan of the collection
                {
                    results.Add(medicine);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters by exact category (case-insensitive). O(n) linear scan.
        /// A null/empty category returns the whole list.
        /// </summary>
        public List<Medicine> FilterByCategory(IEnumerable<Medicine> source, string category)
        {
            List<Medicine> results = new List<Medicine>();
            bool all = string.IsNullOrWhiteSpace(category);
            string wanted = all ? null : category.Trim();

            foreach (Medicine medicine in source)
            {
                if (all || string.Equals(medicine.Category, wanted, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(medicine);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters by an inclusive price range. O(n) linear scan. Either bound may be
        /// null to leave that side open.
        /// </summary>
        public List<Medicine> FilterByPriceRange(IEnumerable<Medicine> source, decimal? min, decimal? max)
        {
            List<Medicine> results = new List<Medicine>();
            foreach (Medicine medicine in source)
            {
                if (min.HasValue && medicine.Price < min.Value)
                {
                    continue;
                }
                if (max.HasValue && medicine.Price > max.Value)
                {
                    continue;
                }
                results.Add(medicine);
            }
            return results;
        }

        // ------------------------------------------------------------------
        //  SORTING  ->  O(n log n)
        //  List.Sort uses an introspective sort (quicksort/heapsort hybrid).
        //  A comparison-based sort cannot beat O(n log n) in the general case.
        // ------------------------------------------------------------------

        /// <summary>
        /// Returns a new list sorted by name (A→Z), case-insensitive. O(n log n).
        /// This also produces the sorted input that binary search requires.
        /// </summary>
        public List<Medicine> SortByName(IEnumerable<Medicine> source)
        {
            List<Medicine> list = new List<Medicine>(source);
            list.Sort((a, b) => string.Compare(a.Name, b.Name, StringComparison.OrdinalIgnoreCase));
            return list;
        }

        /// <summary>
        /// Returns a new list sorted by price. O(n log n).
        /// </summary>
        /// <param name="ascending">Ascending (cheapest first) when true.</param>
        public List<Medicine> SortByPrice(IEnumerable<Medicine> source, bool ascending = true)
        {
            List<Medicine> list = new List<Medicine>(source);
            list.Sort((a, b) => ascending
                ? a.Price.CompareTo(b.Price)
                : b.Price.CompareTo(a.Price));
            return list;
        }

        // ------------------------------------------------------------------
        //  BINARY SEARCH  ->  O(log n)
        //  PRECONDITION: the list MUST already be sorted by Name (use SortByName).
        //  We repeatedly halve the search range, so the work grows with the
        //  logarithm of n. Contrast with the linear search above (O(n)): binary
        //  search is far faster for exact-match lookups on large, sorted data,
        //  but it cannot do substring matching and it costs an O(n log n) sort
        //  up front, so it is only worthwhile when the list is already sorted
        //  and we need exact matches repeatedly.
        // ------------------------------------------------------------------

        /// <summary>
        /// Finds a medicine by its exact name in a list that is ALREADY sorted by name,
        /// using binary search in O(log n). Returns null when there is no exact match.
        /// </summary>
        public Medicine BinarySearchByName(List<Medicine> sortedByName, string exactName)
        {
            if (sortedByName == null || exactName == null)
            {
                return null;
            }

            string target = exactName.Trim();
            int low = 0;
            int high = sortedByName.Count - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2; // avoids integer overflow
                int comparison = string.Compare(
                    sortedByName[mid].Name, target, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                {
                    return sortedByName[mid]; // found
                }
                if (comparison < 0)
                {
                    low = mid + 1;  // target is in the upper half
                }
                else
                {
                    high = mid - 1; // target is in the lower half
                }
            }

            return null; // not found
        }
    }
}
