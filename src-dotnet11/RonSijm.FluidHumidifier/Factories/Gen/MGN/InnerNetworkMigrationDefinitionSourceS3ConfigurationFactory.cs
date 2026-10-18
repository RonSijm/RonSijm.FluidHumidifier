// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MGN;

public class InnerNetworkMigrationDefinitionSourceS3ConfigurationFactory(Action<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration> factoryAction = null) : SubResourceFactory<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration>
{

    protected override Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration Create()
    {
        var sourceS3ConfigurationResult = CreateSourceS3Configuration();
        factoryAction?.Invoke(sourceS3ConfigurationResult);

        return sourceS3ConfigurationResult;
    }

    private Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration CreateSourceS3Configuration()
    {
        var sourceS3ConfigurationResult = new Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration();

        return sourceS3ConfigurationResult;
    }

} // End Of Class

public static class InnerNetworkMigrationDefinitionSourceS3ConfigurationFactoryExtensions
{
}
