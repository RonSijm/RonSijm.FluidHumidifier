// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssociationSlackChannelFactory(Action<Humidifier.DevOpsAgent.AssociationTypes.SlackChannel> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssociationTypes.SlackChannel>
{

    protected override Humidifier.DevOpsAgent.AssociationTypes.SlackChannel Create()
    {
        var slackChannelResult = CreateSlackChannel();
        factoryAction?.Invoke(slackChannelResult);

        return slackChannelResult;
    }

    private Humidifier.DevOpsAgent.AssociationTypes.SlackChannel CreateSlackChannel()
    {
        var slackChannelResult = new Humidifier.DevOpsAgent.AssociationTypes.SlackChannel();

        return slackChannelResult;
    }

} // End Of Class

public static class InnerAssociationSlackChannelFactoryExtensions
{
}
