using System.Runtime.CompilerServices;

namespace DataStructure.Models;

public class ProblemModel
{
    public string Name { get; set; } = "Two Sum";
    public string LogoSource { get; set; } = "/IconCodefrydev.svg";
    public string PageUri { get; set; } 
    public string Alt { get; set; } = "Two Sum";
    public string Description { get; set; } = "Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.";
    public int Priority { get; set; } = 0;
    public Difficulty Difficulty { get; set; } = Difficulty.Easy;
    public List<string> Tags { get; set; } =[];
    public bool IsPinned  { get; set; }
}