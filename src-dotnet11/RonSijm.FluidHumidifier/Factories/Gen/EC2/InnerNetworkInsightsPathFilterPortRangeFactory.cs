// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerNetworkInsightsPathFilterPortRangeFactory(Action<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange> factoryAction = null) : SubResourceFactory<Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange>
{

    protected override Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange Create()
    {
        var filterPortRangeResult = CreateFilterPortRange();
        factoryAction?.Invoke(filterPortRangeResult);

        return filterPortRangeResult;
    }

    private Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange CreateFilterPortRange()
    {
        var filterPortRangeResult = new Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange();

        return filterPortRangeResult;
    }

} // End Of Class

public static class InnerNetworkInsightsPathFilterPortRangeFactoryExtensions
{
}
