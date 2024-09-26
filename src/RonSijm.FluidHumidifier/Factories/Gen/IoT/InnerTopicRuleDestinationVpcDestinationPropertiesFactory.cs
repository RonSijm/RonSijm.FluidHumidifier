// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleDestinationVpcDestinationPropertiesFactory(Action<Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties>
{

    protected override Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties Create()
    {
        var vpcDestinationPropertiesResult = CreateVpcDestinationProperties();
        factoryAction?.Invoke(vpcDestinationPropertiesResult);

        return vpcDestinationPropertiesResult;
    }

    private Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties CreateVpcDestinationProperties()
    {
        var vpcDestinationPropertiesResult = new Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties();

        return vpcDestinationPropertiesResult;
    }

} // End Of Class

public static class InnerTopicRuleDestinationVpcDestinationPropertiesFactoryExtensions
{
}
