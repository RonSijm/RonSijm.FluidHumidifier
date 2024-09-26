// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class InnerDBInstanceProcessorFeatureFactory(Action<Humidifier.RDS.DBInstanceTypes.ProcessorFeature> factoryAction = null) : SubResourceFactory<Humidifier.RDS.DBInstanceTypes.ProcessorFeature>
{

    protected override Humidifier.RDS.DBInstanceTypes.ProcessorFeature Create()
    {
        var processorFeatureResult = CreateProcessorFeature();
        factoryAction?.Invoke(processorFeatureResult);

        return processorFeatureResult;
    }

    private Humidifier.RDS.DBInstanceTypes.ProcessorFeature CreateProcessorFeature()
    {
        var processorFeatureResult = new Humidifier.RDS.DBInstanceTypes.ProcessorFeature();

        return processorFeatureResult;
    }

} // End Of Class

public static class InnerDBInstanceProcessorFeatureFactoryExtensions
{
}
