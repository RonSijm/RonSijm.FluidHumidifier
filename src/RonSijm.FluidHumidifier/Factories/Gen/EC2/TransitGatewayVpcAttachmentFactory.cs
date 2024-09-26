// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayVpcAttachmentFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayVpcAttachment> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayVpcAttachment>(resourceName)
{

    internal InnerTransitGatewayVpcAttachmentOptionsFactory OptionsFactory { get; set; }

    protected override Humidifier.EC2.TransitGatewayVpcAttachment Create()
    {
        var transitGatewayVpcAttachmentResult = CreateTransitGatewayVpcAttachment();
        factoryAction?.Invoke(transitGatewayVpcAttachmentResult);

        return transitGatewayVpcAttachmentResult;
    }

    private Humidifier.EC2.TransitGatewayVpcAttachment CreateTransitGatewayVpcAttachment()
    {
        var transitGatewayVpcAttachmentResult = new Humidifier.EC2.TransitGatewayVpcAttachment
        {
            GivenName = InputResourceName,
        };

        return transitGatewayVpcAttachmentResult;
    }
    public override void CreateChildren(Humidifier.EC2.TransitGatewayVpcAttachment result)
    {
        base.CreateChildren(result);

        result.Options ??= OptionsFactory?.Build();
    }

} // End Of Class

public static class TransitGatewayVpcAttachmentFactoryExtensions
{
    public static CombinedResult<TransitGatewayVpcAttachmentFactory, InnerTransitGatewayVpcAttachmentOptionsFactory> WithOptions(this TransitGatewayVpcAttachmentFactory parentFactory, Action<Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options> subFactoryAction = null)
    {
        parentFactory.OptionsFactory = new InnerTransitGatewayVpcAttachmentOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OptionsFactory);
    }

    public static CombinedResult<TransitGatewayVpcAttachmentFactory, T1, InnerTransitGatewayVpcAttachmentOptionsFactory> WithOptions<T1>(this CombinedResult<TransitGatewayVpcAttachmentFactory, T1> combinedResult, Action<Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransitGatewayVpcAttachmentFactory, InnerTransitGatewayVpcAttachmentOptionsFactory> WithOptions<T1>(this CombinedResult<T1, TransitGatewayVpcAttachmentFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TransitGatewayVpcAttachmentFactory, T1, T2, InnerTransitGatewayVpcAttachmentOptionsFactory> WithOptions<T1, T2>(this CombinedResult<TransitGatewayVpcAttachmentFactory, T1, T2> combinedResult, Action<Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransitGatewayVpcAttachmentFactory, T2, InnerTransitGatewayVpcAttachmentOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, TransitGatewayVpcAttachmentFactory, T2> combinedResult, Action<Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TransitGatewayVpcAttachmentFactory, InnerTransitGatewayVpcAttachmentOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, T2, TransitGatewayVpcAttachmentFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TransitGatewayVpcAttachmentFactory, T1, T2, T3, InnerTransitGatewayVpcAttachmentOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<TransitGatewayVpcAttachmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransitGatewayVpcAttachmentFactory, T2, T3, InnerTransitGatewayVpcAttachmentOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, TransitGatewayVpcAttachmentFactory, T2, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TransitGatewayVpcAttachmentFactory, T3, InnerTransitGatewayVpcAttachmentOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, TransitGatewayVpcAttachmentFactory, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TransitGatewayVpcAttachmentFactory, InnerTransitGatewayVpcAttachmentOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, TransitGatewayVpcAttachmentFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TransitGatewayVpcAttachmentFactory, T1, T2, T3, T4, InnerTransitGatewayVpcAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<TransitGatewayVpcAttachmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransitGatewayVpcAttachmentFactory, T2, T3, T4, InnerTransitGatewayVpcAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, TransitGatewayVpcAttachmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TransitGatewayVpcAttachmentFactory, T3, T4, InnerTransitGatewayVpcAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, TransitGatewayVpcAttachmentFactory, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TransitGatewayVpcAttachmentFactory, T4, InnerTransitGatewayVpcAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TransitGatewayVpcAttachmentFactory, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TransitGatewayVpcAttachmentFactory, InnerTransitGatewayVpcAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TransitGatewayVpcAttachmentFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayVpcAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T5, subFactoryAction));
}
