// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class ElasticLoadBalancerAttachmentFactory(string resourceName = null, Action<Humidifier.OpsWorks.ElasticLoadBalancerAttachment> factoryAction = null) : ResourceFactory<Humidifier.OpsWorks.ElasticLoadBalancerAttachment>(resourceName)
{

    protected override Humidifier.OpsWorks.ElasticLoadBalancerAttachment Create()
    {
        var elasticLoadBalancerAttachmentResult = CreateElasticLoadBalancerAttachment();
        factoryAction?.Invoke(elasticLoadBalancerAttachmentResult);

        return elasticLoadBalancerAttachmentResult;
    }

    private Humidifier.OpsWorks.ElasticLoadBalancerAttachment CreateElasticLoadBalancerAttachment()
    {
        var elasticLoadBalancerAttachmentResult = new Humidifier.OpsWorks.ElasticLoadBalancerAttachment
        {
            GivenName = InputResourceName,
        };

        return elasticLoadBalancerAttachmentResult;
    }

} // End Of Class

public static class ElasticLoadBalancerAttachmentFactoryExtensions
{
}
