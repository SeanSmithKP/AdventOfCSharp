// This problem is too trivial a case to demand inclusion of nullability
// Consider removing this line on more complex solutions
// Additionally, you may add a #nullable enable line on the important sections of your code
#nullable disable

using AdventOfCSharp;
using System.Linq;

// Make sure the namespace of the problem class ends in its respective year
// For a problem for the year 2015, you would need to end the namespace in
// ".Year2015"
namespace AdventOfCode.Problems.Year2021;

// Also ensure the solution class is named DayXX, denoting the day in the year
// for which this problem is
public class Day1 : Problem<int>
{
    // This is the state of your parsed input
    private int[] numbers;

    // NOTE: This example solution does not actually reflect a solution for
    //       the problem for Year 2021, Day 1

    public override int SolvePart1()
    {
        // Use your parsed input state to solve part 1

        return numbers.Min() + numbers.Max();
    }
    public override int SolvePart2()
    {
        // Same for part 2

        return numbers.Sum();
    }

    protected override void LoadState()
    {
        // Here you parse your input, called before solving any part

        // FileNumbersInt32 is a property that returns an array of the
        // parsed numbers of the input file's lines for this problem
        // There are other properties to use, like FileContents and FileLines
        numbers = FileNumbersInt32;
    }
    protected override void ResetState()
    {
        // Here you reset the state of your parsed input
        // Usually this is called to unload state
        // It is almost always unnecessary to unload the state
        // Resetting to null is completely optional, and often times redundant

        numbers = null;
    }
}
