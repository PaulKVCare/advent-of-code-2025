using AoC.Helpers.Helpers;

namespace AoC.Year2025;

public class Day1() : DayBase(1)
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

    public int Part1()
    {
        var initialValue = 50;
        var password = 0;
        
        var lines = TextInputHelper.ReadLinesAsList(DayPath, x => new combination(x[0] == 'L' ? DirectionCombination.L : DirectionCombination.R, int.Parse(x[1..])));

        foreach (var line in lines)
        {
            if (line.direction == DirectionCombination.L)
            {
                initialValue -= line.distance;
            }else if (line.direction == DirectionCombination.R)
            {
                initialValue += line.distance;
            }

            if (initialValue % 100 == 0)
            {
                password++;
            }

            ConsoleWrite($"current value: {initialValue}, password: {password}");
        }

        return password;
    }

    public int Part2()
    {
        var initialValue = 50;
        var password = 0;
        
        var lines = TextInputHelper.ReadLinesAsList(DayPath, x => new combination(x[0] == 'L' ? DirectionCombination.L : DirectionCombination.R, int.Parse(x[1..])));

        foreach (var line in lines)
        {
            var currentValue = initialValue;
            
            if (line.direction == DirectionCombination.L)
            {
                initialValue -= line.distance;
            }else if (line.direction == DirectionCombination.R)
            {
                initialValue += line.distance;
            }

            for (var i = currentValue; i != initialValue; i += line.direction == DirectionCombination.L ? -1 : 1)
            {
                if (i % 100 == 0) password++;
            }

            ConsoleWrite($"current value: {initialValue}, password: {password}");
        }

        return password;
    }
}

public record combination(DirectionCombination direction, int distance);


public enum DirectionCombination
{
    L = 0,
    R = 1
}