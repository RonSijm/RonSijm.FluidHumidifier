// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleSigV4AuthorizationFactory(Action<Humidifier.IoT.TopicRuleTypes.SigV4Authorization> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.SigV4Authorization>
{

    protected override Humidifier.IoT.TopicRuleTypes.SigV4Authorization Create()
    {
        var sigV4AuthorizationResult = CreateSigV4Authorization();
        factoryAction?.Invoke(sigV4AuthorizationResult);

        return sigV4AuthorizationResult;
    }

    private Humidifier.IoT.TopicRuleTypes.SigV4Authorization CreateSigV4Authorization()
    {
        var sigV4AuthorizationResult = new Humidifier.IoT.TopicRuleTypes.SigV4Authorization();

        return sigV4AuthorizationResult;
    }

} // End Of Class

public static class InnerTopicRuleSigV4AuthorizationFactoryExtensions
{
}
