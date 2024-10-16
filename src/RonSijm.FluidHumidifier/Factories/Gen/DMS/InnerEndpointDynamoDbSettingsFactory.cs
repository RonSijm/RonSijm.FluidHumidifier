// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerEndpointDynamoDbSettingsFactory(Action<Humidifier.DMS.EndpointTypes.DynamoDbSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.EndpointTypes.DynamoDbSettings>
{

    protected override Humidifier.DMS.EndpointTypes.DynamoDbSettings Create()
    {
        var dynamoDbSettingsResult = CreateDynamoDbSettings();
        factoryAction?.Invoke(dynamoDbSettingsResult);

        return dynamoDbSettingsResult;
    }

    private Humidifier.DMS.EndpointTypes.DynamoDbSettings CreateDynamoDbSettings()
    {
        var dynamoDbSettingsResult = new Humidifier.DMS.EndpointTypes.DynamoDbSettings();

        return dynamoDbSettingsResult;
    }

} // End Of Class

public static class InnerEndpointDynamoDbSettingsFactoryExtensions
{
}
