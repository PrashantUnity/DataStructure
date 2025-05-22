using DataStructure.Models;

namespace DataStructure.Pages;

public partial class Home
{
    private readonly List<ProblemModel> _problems =
    [
        new()
        {
            Name = "MWS",
            LogoSource = "IconCodefrydev.svg",
            PageUri = "https://leetcode.com/problems/two-sum/",
            Alt = "76. Minimum Window Substring",
            Description = "Given two strings s and t of lengths m and n respectively, return the minimum window substring of s such that every character in t (including duplicates) is included in the window.",
        }
    ];
}