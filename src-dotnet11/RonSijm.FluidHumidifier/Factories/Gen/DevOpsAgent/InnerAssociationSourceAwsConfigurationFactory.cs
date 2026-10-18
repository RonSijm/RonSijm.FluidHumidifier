// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssociationSourceAwsConfigurationFactory(Action<Humidifier.DevOpsAgent.AssociationTypes.SourceAwsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssociationTypes.SourceAwsConfiguration>
{

    protected override Humidifier.DevOpsAgent.AssociationTypes.SourceAwsConfiguration Create()
    {
        var sourceAwsConfigurationResult = CreateSourceAwsConfiguration();
        factoryAction?.Invoke(sourceAwsConfigurationResult);

        return sourceAwsConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AssociationTypes.SourceAwsConfiguration CreateSourceAwsConfiguration()
    {
        var sourceAwsConfigurationResult = new Humidifier.DevOpsAgent.AssociationTypes.SourceAwsConfiguration();

        return sourceAwsConfigurationResult;
    }

} // End Of Class

public static class InnerAssociationSourceAwsConfigurationFactoryExtensions
{
}
