using System.Diagnostics;
using RonSijm.FluidHumidifier.Features.Consumer;

namespace RonSijm.FluidHumidifier.Features.Output;

[DebuggerDisplay("EnvironmentOutput For {Environment.EnvironmentName}")]
public class EnvironmentOutputResult
{
    public virtual EnvironmentConfig Environment { get; init; }

    public List<IOutputResult> Stacks { get; set; } = [];
    public string RegionName { get; set; }

    public StackCreateResult Add(Func<StackCreateResult> stackFactory, string path = null)
    {
        var result = stackFactory();
        return Add(result, path);
    }

    public ScriptOutputResult Add(int counter, string name, Func<string> stackFactory, string path = null)
    {
        var factoryResult = stackFactory();

        var scriptOutputResult = new ScriptOutputResult
        {
            Result = factoryResult,
            RelativePath = path,
            Name = $"Script-{counter}-{Environment.EnvironmentName}-{name}-Script"
        };

        Stacks.Add(scriptOutputResult);

        return scriptOutputResult;
    }

    public StackCreateResult Add(StackCreateResult result, string path = null)
    {
        var stack = result.Stack;
        var counter = Stacks.Count + 1;

        Stacks.Add(new StackOutputResult
        {
            Result = stack,
            RelativePath = path,
            Name = $"CF-{counter}-{Environment.EnvironmentName}-{stack.Name}-Stack"
        });

        return result;
    }
}