// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssociationSlackBidirectionalConfigurationFactory(Action<Humidifier.DevOpsAgent.AssociationTypes.SlackBidirectionalConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssociationTypes.SlackBidirectionalConfiguration>
{

    protected override Humidifier.DevOpsAgent.AssociationTypes.SlackBidirectionalConfiguration Create()
    {
        var slackBidirectionalConfigurationResult = CreateSlackBidirectionalConfiguration();
        factoryAction?.Invoke(slackBidirectionalConfigurationResult);

        return slackBidirectionalConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AssociationTypes.SlackBidirectionalConfiguration CreateSlackBidirectionalConfiguration()
    {
        var slackBidirectionalConfigurationResult = new Humidifier.DevOpsAgent.AssociationTypes.SlackBidirectionalConfiguration();

        return slackBidirectionalConfigurationResult;
    }

} // End Of Class

public static class InnerAssociationSlackBidirectionalConfigurationFactoryExtensions
{
}
