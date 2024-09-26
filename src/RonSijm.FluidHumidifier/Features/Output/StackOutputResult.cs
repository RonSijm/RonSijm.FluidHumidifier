namespace RonSijm.FluidHumidifier.Features.Output;

public class StackOutputResult : BaseOutputResult<Stack>
{
    public override string Description => Result.Description;
    public override string FileName => $"{Name}.json";
}

public class ScriptOutputResult : BaseOutputResult<string>
{
    public override string Description
    {
        get { return null; }
    }

    public override string FileName => $"{Name}.bat";
}