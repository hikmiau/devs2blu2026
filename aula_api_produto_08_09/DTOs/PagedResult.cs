namespace ProdutosApi.DTOs;

public class PagedResult<T>
{
    public IEnumerable<T> Items { get; set; } = Array.Empty<T>();
    public int Page { get; set; }
    public int PageSize { get; set; }
    public int TotalItems { get; set; }
    public int TotalPages => PageSize == 0 ? 0 : (int)Math.Ceiling((double)TotalItems / PageSize);
    public bool HasPreviousPage => Page > 1;
    public bool HasNextPage => Page < TotalPages;
    
    public PagedResult(){}
    
    public PagedResult(IReadOnlyList<T> items, int page, int pageSize, int totalItems)
    {
        Items = items;
        TotalItems = totalItems;
        Page = page;
        PageSize = pageSize;
    }
}