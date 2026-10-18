// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MGN;

public class InnerNetworkMigrationDefinitionTargetS3ConfigurationFactory(Action<Humidifier.MGN.NetworkMigrationDefinitionTypes.TargetS3Configuration> factoryAction = null) : SubResourceFactory<Humidifier.MGN.NetworkMigrationDefinitionTypes.TargetS3Configuration>
{

    protected override Humidifier.MGN.NetworkMigrationDefinitionTypes.TargetS3Configuration Create()
    {
        var targetS3ConfigurationResult = CreateTargetS3Configuration();
        factoryAction?.Invoke(targetS3ConfigurationResult);

        return targetS3ConfigurationResult;
    }

    private Humidifier.MGN.NetworkMigrationDefinitionTypes.TargetS3Configuration CreateTargetS3Configuration()
    {
        var targetS3ConfigurationResult = new Humidifier.MGN.NetworkMigrationDefinitionTypes.TargetS3Configuration();

        return targetS3ConfigurationResult;
    }

} // End Of Class

public static class InnerNetworkMigrationDefinitionTargetS3ConfigurationFactoryExtensions
{
}
