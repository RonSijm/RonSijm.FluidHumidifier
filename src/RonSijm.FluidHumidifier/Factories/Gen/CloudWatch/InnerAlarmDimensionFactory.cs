// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAlarmDimensionFactory(Action<Humidifier.CloudWatch.AlarmTypes.Dimension> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AlarmTypes.Dimension>
{

    protected override Humidifier.CloudWatch.AlarmTypes.Dimension Create()
    {
        var dimensionResult = CreateDimension();
        factoryAction?.Invoke(dimensionResult);

        return dimensionResult;
    }

    private Humidifier.CloudWatch.AlarmTypes.Dimension CreateDimension()
    {
        var dimensionResult = new Humidifier.CloudWatch.AlarmTypes.Dimension();

        return dimensionResult;
    }

} // End Of Class

public static class InnerAlarmDimensionFactoryExtensions
{
}
