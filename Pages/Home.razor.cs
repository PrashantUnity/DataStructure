using DataStructure.Models;

namespace DataStructure.Pages;

public partial class Home
{
    private readonly List<ProblemModel> _problems =
    [
        new()
        {
            Name = "Two Sum",
            LogoSource = "/IconCodefrydev.svg",
            PageUri = "https://leetcode.com/problems/two-sum/",
            Alt = "Two Sum",
            Description =
                "Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target."
        }

    ];
}