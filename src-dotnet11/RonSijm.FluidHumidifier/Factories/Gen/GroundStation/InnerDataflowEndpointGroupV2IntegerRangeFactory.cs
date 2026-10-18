// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerDataflowEndpointGroupV2IntegerRangeFactory(Action<Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange>
{

    protected override Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange Create()
    {
        var integerRangeResult = CreateIntegerRange();
        factoryAction?.Invoke(integerRangeResult);

        return integerRangeResult;
    }

    private Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange CreateIntegerRange()
    {
        var integerRangeResult = new Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange();

        return integerRangeResult;
    }

} // End Of Class

public static class InnerDataflowEndpointGroupV2IntegerRangeFactoryExtensions
{
}
