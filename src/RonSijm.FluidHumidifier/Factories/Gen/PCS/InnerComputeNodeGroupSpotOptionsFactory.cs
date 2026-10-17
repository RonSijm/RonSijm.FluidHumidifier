// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCS;

public class InnerComputeNodeGroupSpotOptionsFactory(Action<Humidifier.PCS.ComputeNodeGroupTypes.SpotOptions> factoryAction = null) : SubResourceFactory<Humidifier.PCS.ComputeNodeGroupTypes.SpotOptions>
{

    protected override Humidifier.PCS.ComputeNodeGroupTypes.SpotOptions Create()
    {
        var spotOptionsResult = CreateSpotOptions();
        factoryAction?.Invoke(spotOptionsResult);

        return spotOptionsResult;
    }

    private Humidifier.PCS.ComputeNodeGroupTypes.SpotOptions CreateSpotOptions()
    {
        var spotOptionsResult = new Humidifier.PCS.ComputeNodeGroupTypes.SpotOptions();

        return spotOptionsResult;
    }

} // End Of Class

public static class InnerComputeNodeGroupSpotOptionsFactoryExtensions
{
}
