// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableWriteOnDemandThroughputSettingsFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings>
{

    protected override Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings Create()
    {
        var writeOnDemandThroughputSettingsResult = CreateWriteOnDemandThroughputSettings();
        factoryAction?.Invoke(writeOnDemandThroughputSettingsResult);

        return writeOnDemandThroughputSettingsResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings CreateWriteOnDemandThroughputSettings()
    {
        var writeOnDemandThroughputSettingsResult = new Humidifier.DynamoDB.GlobalTableTypes.WriteOnDemandThroughputSettings();

        return writeOnDemandThroughputSettingsResult;
    }

} // End Of Class

public static class InnerGlobalTableWriteOnDemandThroughputSettingsFactoryExtensions
{
}
