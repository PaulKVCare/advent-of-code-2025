using AoC.Helpers.Helpers;

namespace AoC.Year2025;

public class Day10() : DayBase(10)
{
    public override object RunDay(int part)
    {
        return part switch
        {
            1 => Part1(),
            2 => Part2(),
            _ => throw new ArgumentOutOfRangeException(nameof(part))
        };
    }

    public object Part1()
    {
        throw new NotImplementedException();
    }

    public object Part2()
    {
        throw new NotImplementedException();
    }
}

// Floodfill problem 2024
// public object Part1()
// {
//     var grid = TextInputHelper.ReadLinesAs2DArray(DayPath, x => int.Parse(x.ToString()));
//
//     var trailheads = grid.FindAll(val => val == 0);
//     var totalScore = 0;
//
//     foreach (var (startRow, startCol) in trailheads)
//     {
//         totalScore += grid.CountReachableTargets(
//             startRow,
//             startCol,
//             canStep: (current, next) => next == current + 1, // The gradient rule
//             isTarget: val => val == 9 // The goal
//         );
//     }
//
//     return totalScore;
// }
//
// public object Part2()
// {
//     var grid = TextInputHelper.ReadLinesAs2DArray(DayPath, x => int.Parse(x.ToString()));
//     var trailheads = grid.FindAll(x => x == 0);
//     var totalRating = 0;
//
//     foreach (var (r, c) in trailheads)
//     {
//         totalRating += grid.CountDistinctPaths(
//             r, c, 
//             canStep: (curr, next) => next == curr + 1, 
//             isTarget: val => val == 9
//         );
//     }
//         
//     return totalRating;
// }
