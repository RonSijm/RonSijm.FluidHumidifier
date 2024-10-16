// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerDataflowEndpointGroupIntegerRangeFactory(Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange>
{

    protected override Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange Create()
    {
        var integerRangeResult = CreateIntegerRange();
        factoryAction?.Invoke(integerRangeResult);

        return integerRangeResult;
    }

    private Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange CreateIntegerRange()
    {
        var integerRangeResult = new Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange();

        return integerRangeResult;
    }

} // End Of Class

public static class InnerDataflowEndpointGroupIntegerRangeFactoryExtensions
{
}
