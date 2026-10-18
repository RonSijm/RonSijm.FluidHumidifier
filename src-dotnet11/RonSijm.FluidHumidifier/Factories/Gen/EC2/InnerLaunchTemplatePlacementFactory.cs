// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplatePlacementFactory(Action<Humidifier.EC2.LaunchTemplateTypes.Placement> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.Placement>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.Placement Create()
    {
        var placementResult = CreatePlacement();
        factoryAction?.Invoke(placementResult);

        return placementResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.Placement CreatePlacement()
    {
        var placementResult = new Humidifier.EC2.LaunchTemplateTypes.Placement();

        return placementResult;
    }

} // End Of Class

public static class InnerLaunchTemplatePlacementFactoryExtensions
{
}
