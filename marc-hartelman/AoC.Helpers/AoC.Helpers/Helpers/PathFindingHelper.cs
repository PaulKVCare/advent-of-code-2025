namespace AoC.Helpers.Helpers;

public static class PathFindingHelper
{
    /// <summary>
    /// A generic Breadth-First Search (BFS) to find the shortest path distance.
    /// </summary>
    /// <typeparam name="T">The type of the node (e.g., (int r, int c) or a custom Class).</typeparam>
    /// <param name="start">The starting node.</param>
    /// <param name="getNeighbors">Function that returns valid neighbors for a given node.</param>
    /// <param name="isGoal">Function that returns true if the node is the target.</param>
    /// <returns>The number of steps to reach the goal, or -1 if unreachable.</returns>
    public static int BfsDistance<T>(
        T start, 
        Func<T, IEnumerable<T>> getNeighbors, 
        Func<T, bool> isGoal) where T : notnull
    {
        var queue = new Queue<(T Node, int Distance)>();
        var visited = new HashSet<T>();

        queue.Enqueue((start, 0));
        visited.Add(start);

        while (queue.Count > 0)
        {
            var (current, dist) = queue.Dequeue();

            if (isGoal(current))
            {
                return dist;
            }

            foreach (var neighbor in getNeighbors(current))
            {
                if (visited.Add(neighbor))
                {
                    queue.Enqueue((neighbor, dist + 1));
                }
            }
        }

        return -1; // Path not found
    }
}