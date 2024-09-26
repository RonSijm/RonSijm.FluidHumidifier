// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableReadOnDemandThroughputSettingsFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.ReadOnDemandThroughputSettings> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.ReadOnDemandThroughputSettings>
{

    protected override Humidifier.DynamoDB.GlobalTableTypes.ReadOnDemandThroughputSettings Create()
    {
        var readOnDemandThroughputSettingsResult = CreateReadOnDemandThroughputSettings();
        factoryAction?.Invoke(readOnDemandThroughputSettingsResult);

        return readOnDemandThroughputSettingsResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.ReadOnDemandThroughputSettings CreateReadOnDemandThroughputSettings()
    {
        var readOnDemandThroughputSettingsResult = new Humidifier.DynamoDB.GlobalTableTypes.ReadOnDemandThroughputSettings();

        return readOnDemandThroughputSettingsResult;
    }

} // End Of Class

public static class InnerGlobalTableReadOnDemandThroughputSettingsFactoryExtensions
{
}
