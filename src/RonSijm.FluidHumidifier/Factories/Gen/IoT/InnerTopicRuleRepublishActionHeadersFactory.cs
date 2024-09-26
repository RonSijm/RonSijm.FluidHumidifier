// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleRepublishActionHeadersFactory(Action<Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders>
{

    protected override Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders Create()
    {
        var republishActionHeadersResult = CreateRepublishActionHeaders();
        factoryAction?.Invoke(republishActionHeadersResult);

        return republishActionHeadersResult;
    }

    private Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders CreateRepublishActionHeaders()
    {
        var republishActionHeadersResult = new Humidifier.IoT.TopicRuleTypes.RepublishActionHeaders();

        return republishActionHeadersResult;
    }

} // End Of Class

public static class InnerTopicRuleRepublishActionHeadersFactoryExtensions
{
}
