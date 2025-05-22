using DataStructure.Models;
using Microsoft.AspNetCore.Components;

namespace DataStructure.Components;

public partial class ProblemCard : ComponentBase
{
    [Parameter] public ProblemModel Model { get; set; } = null!;
}