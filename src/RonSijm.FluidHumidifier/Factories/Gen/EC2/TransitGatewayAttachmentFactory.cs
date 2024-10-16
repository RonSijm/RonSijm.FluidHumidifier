// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayAttachmentFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayAttachment> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayAttachment>(resourceName)
{

    internal InnerTransitGatewayAttachmentOptionsFactory OptionsFactory { get; set; }

    protected override Humidifier.EC2.TransitGatewayAttachment Create()
    {
        var transitGatewayAttachmentResult = CreateTransitGatewayAttachment();
        factoryAction?.Invoke(transitGatewayAttachmentResult);

        return transitGatewayAttachmentResult;
    }

    private Humidifier.EC2.TransitGatewayAttachment CreateTransitGatewayAttachment()
    {
        var transitGatewayAttachmentResult = new Humidifier.EC2.TransitGatewayAttachment
        {
            GivenName = InputResourceName,
        };

        return transitGatewayAttachmentResult;
    }
    public override void CreateChildren(Humidifier.EC2.TransitGatewayAttachment result)
    {
        base.CreateChildren(result);

        result.Options ??= OptionsFactory?.Build();
    }

} // End Of Class

public static class TransitGatewayAttachmentFactoryExtensions
{
    public static CombinedResult<TransitGatewayAttachmentFactory, InnerTransitGatewayAttachmentOptionsFactory> WithOptions(this TransitGatewayAttachmentFactory parentFactory, Action<Humidifier.EC2.TransitGatewayAttachmentTypes.Options> subFactoryAction = null)
    {
        parentFactory.OptionsFactory = new InnerTransitGatewayAttachmentOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OptionsFactory);
    }

    public static CombinedResult<TransitGatewayAttachmentFactory, T1, InnerTransitGatewayAttachmentOptionsFactory> WithOptions<T1>(this CombinedResult<TransitGatewayAttachmentFactory, T1> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransitGatewayAttachmentFactory, InnerTransitGatewayAttachmentOptionsFactory> WithOptions<T1>(this CombinedResult<T1, TransitGatewayAttachmentFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TransitGatewayAttachmentFactory, T1, T2, InnerTransitGatewayAttachmentOptionsFactory> WithOptions<T1, T2>(this CombinedResult<TransitGatewayAttachmentFactory, T1, T2> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransitGatewayAttachmentFactory, T2, InnerTransitGatewayAttachmentOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, TransitGatewayAttachmentFactory, T2> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TransitGatewayAttachmentFactory, InnerTransitGatewayAttachmentOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, T2, TransitGatewayAttachmentFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TransitGatewayAttachmentFactory, T1, T2, T3, InnerTransitGatewayAttachmentOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<TransitGatewayAttachmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransitGatewayAttachmentFactory, T2, T3, InnerTransitGatewayAttachmentOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, TransitGatewayAttachmentFactory, T2, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TransitGatewayAttachmentFactory, T3, InnerTransitGatewayAttachmentOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, TransitGatewayAttachmentFactory, T3> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TransitGatewayAttachmentFactory, InnerTransitGatewayAttachmentOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, TransitGatewayAttachmentFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TransitGatewayAttachmentFactory, T1, T2, T3, T4, InnerTransitGatewayAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<TransitGatewayAttachmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TransitGatewayAttachmentFactory, T2, T3, T4, InnerTransitGatewayAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, TransitGatewayAttachmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TransitGatewayAttachmentFactory, T3, T4, InnerTransitGatewayAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, TransitGatewayAttachmentFactory, T3, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TransitGatewayAttachmentFactory, T4, InnerTransitGatewayAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TransitGatewayAttachmentFactory, T4> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TransitGatewayAttachmentFactory, InnerTransitGatewayAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TransitGatewayAttachmentFactory> combinedResult, Action<Humidifier.EC2.TransitGatewayAttachmentTypes.Options> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T5, subFactoryAction));
}
