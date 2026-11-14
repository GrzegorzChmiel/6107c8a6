using System.Collections;

namespace VipCredoMetric.Web.Models.Common;

public class PaginationMetadata(int pageNumber, int totalPages)
{
   public int PageNumber { get; } = pageNumber;
   public int TotalPages { get; } = totalPages;
   public bool HasPreviousPage => PageNumber > 1;
   public bool HasNextPage => PageNumber < TotalPages;
}

public class PagedListViewModel<T> : IEnumerable<T>
{
   public IReadOnlyList<T> Items { get; }
   public int PageNumber { get; }
   public int PageSize { get; }
   public int TotalCount { get; }
   public int TotalPages => Metadata.TotalPages;
   public bool HasPreviousPage => Metadata.HasPreviousPage;
   public bool HasNextPage => Metadata.HasNextPage;
   public PaginationMetadata Metadata => new(PageNumber, (int)Math.Ceiling(TotalCount / (double)PageSize));

   private PagedListViewModel(IReadOnlyList<T> items, int pageNumber, int pageSize, int totalCount)
   {
      Items = items;
      PageNumber = pageNumber;
      PageSize = pageSize;
      TotalCount = totalCount;
   }

   public static PagedListViewModel<T> Create(IReadOnlyCollection<T> source, int pageNumber, int pageSize)
   {
      pageNumber = Math.Max(pageNumber, 1);
      pageSize = Math.Max(pageSize, 1);

      var totalCount = source.Count;
      var items = source
         .Skip((pageNumber - 1) * pageSize)
         .Take(pageSize)
         .ToList();

      return new PagedListViewModel<T>(items, pageNumber, pageSize, totalCount);
   }

   public IEnumerator<T> GetEnumerator() => Items.GetEnumerator();

   IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

