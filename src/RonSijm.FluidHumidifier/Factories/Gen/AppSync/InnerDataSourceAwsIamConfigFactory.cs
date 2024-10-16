// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerDataSourceAwsIamConfigFactory(Action<Humidifier.AppSync.DataSourceTypes.AwsIamConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.DataSourceTypes.AwsIamConfig>
{

    protected override Humidifier.AppSync.DataSourceTypes.AwsIamConfig Create()
    {
        var awsIamConfigResult = CreateAwsIamConfig();
        factoryAction?.Invoke(awsIamConfigResult);

        return awsIamConfigResult;
    }

    private Humidifier.AppSync.DataSourceTypes.AwsIamConfig CreateAwsIamConfig()
    {
        var awsIamConfigResult = new Humidifier.AppSync.DataSourceTypes.AwsIamConfig();

        return awsIamConfigResult;
    }

} // End Of Class

public static class InnerDataSourceAwsIamConfigFactoryExtensions
{
}
