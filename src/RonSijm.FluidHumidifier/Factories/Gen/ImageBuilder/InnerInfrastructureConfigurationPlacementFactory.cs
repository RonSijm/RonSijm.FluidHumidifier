// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerInfrastructureConfigurationPlacementFactory(Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Placement> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Placement>
{

    protected override Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Placement Create()
    {
        var placementResult = CreatePlacement();
        factoryAction?.Invoke(placementResult);

        return placementResult;
    }

    private Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Placement CreatePlacement()
    {
        var placementResult = new Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Placement();

        return placementResult;
    }

} // End Of Class

public static class InnerInfrastructureConfigurationPlacementFactoryExtensions
{
}
