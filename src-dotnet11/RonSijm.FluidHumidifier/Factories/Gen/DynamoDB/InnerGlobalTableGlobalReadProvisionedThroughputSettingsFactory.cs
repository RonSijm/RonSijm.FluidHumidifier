// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableGlobalReadProvisionedThroughputSettingsFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.GlobalReadProvisionedThroughputSettings> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.GlobalReadProvisionedThroughputSettings>
{

    protected override Humidifier.DynamoDB.GlobalTableTypes.GlobalReadProvisionedThroughputSettings Create()
    {
        var globalReadProvisionedThroughputSettingsResult = CreateGlobalReadProvisionedThroughputSettings();
        factoryAction?.Invoke(globalReadProvisionedThroughputSettingsResult);

        return globalReadProvisionedThroughputSettingsResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.GlobalReadProvisionedThroughputSettings CreateGlobalReadProvisionedThroughputSettings()
    {
        var globalReadProvisionedThroughputSettingsResult = new Humidifier.DynamoDB.GlobalTableTypes.GlobalReadProvisionedThroughputSettings();

        return globalReadProvisionedThroughputSettingsResult;
    }

} // End Of Class

public static class InnerGlobalTableGlobalReadProvisionedThroughputSettingsFactoryExtensions
{
}
