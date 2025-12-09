namespace AoC.Helpers.Models;

/// <summary>
/// A generic record to hold state for BFS/Dijkstra algorithms.
/// </summary>
/// <typeparam name="T">The type identifying the location (e.g., Point2D).</typeparam>
public record SearchState<T>(T Node, long Cost) : IComparable<SearchState<T>>
{
    public int CompareTo(SearchState<T>? other)
    {
        if (other is null) return 1;
        return Cost.CompareTo(other.Cost);
    }
}