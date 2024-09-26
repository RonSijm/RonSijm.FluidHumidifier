using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Resources;

namespace RonSijm.FluidHumidifier.Features.Decorating.Decorators.ECS;

public class TaskDefinitionNameDecorator : BaseTypeDecorator<Humidifier.ECS.TaskDefinition>, IWantEnvironmentName, IWantStackName
{
    // Rank matter because you could change the resource name to affect the policy name
    public override int Rank { get; set; } = 50;

    public override void Decorate(Humidifier.ECS.TaskDefinition target)
    {
        target.GivenName = $"{target.GivenName}-{EnvironmentName}-TaskDefinition";
    }

    public string EnvironmentName { get; set; }
    public string StackName { get; set; }
}