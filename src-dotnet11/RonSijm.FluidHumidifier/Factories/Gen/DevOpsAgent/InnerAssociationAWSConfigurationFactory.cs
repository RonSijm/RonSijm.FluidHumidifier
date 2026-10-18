// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssociationAWSConfigurationFactory(Action<Humidifier.DevOpsAgent.AssociationTypes.AWSConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssociationTypes.AWSConfiguration>
{

    protected override Humidifier.DevOpsAgent.AssociationTypes.AWSConfiguration Create()
    {
        var aWSConfigurationResult = CreateAWSConfiguration();
        factoryAction?.Invoke(aWSConfigurationResult);

        return aWSConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AssociationTypes.AWSConfiguration CreateAWSConfiguration()
    {
        var aWSConfigurationResult = new Humidifier.DevOpsAgent.AssociationTypes.AWSConfiguration();

        return aWSConfigurationResult;
    }

} // End Of Class

public static class InnerAssociationAWSConfigurationFactoryExtensions
{
}
