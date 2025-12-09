namespace AoC.Helpers.Models;

/// <summary>
/// A specific state for "Crucible" style problems where direction matters.
/// </summary>
public record DirectedSearchState(Point2D Position, Direction Facing, long Cost) 
    : IComparable<DirectedSearchState>
{
    public int CompareTo(DirectedSearchState? other)
    {
        if (other is null) return 1;
        return Cost.CompareTo(other.Cost);
    }
}