// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionSparkEmrPropertiesInputFactory(Action<Humidifier.DataZone.ConnectionTypes.SparkEmrPropertiesInput> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.SparkEmrPropertiesInput>
{

    protected override Humidifier.DataZone.ConnectionTypes.SparkEmrPropertiesInput Create()
    {
        var sparkEmrPropertiesInputResult = CreateSparkEmrPropertiesInput();
        factoryAction?.Invoke(sparkEmrPropertiesInputResult);

        return sparkEmrPropertiesInputResult;
    }

    private Humidifier.DataZone.ConnectionTypes.SparkEmrPropertiesInput CreateSparkEmrPropertiesInput()
    {
        var sparkEmrPropertiesInputResult = new Humidifier.DataZone.ConnectionTypes.SparkEmrPropertiesInput();

        return sparkEmrPropertiesInputResult;
    }

} // End Of Class

public static class InnerConnectionSparkEmrPropertiesInputFactoryExtensions
{
}
