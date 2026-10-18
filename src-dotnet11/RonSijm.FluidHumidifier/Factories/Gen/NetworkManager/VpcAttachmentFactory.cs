// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class VpcAttachmentFactory(string resourceName = null, Action<Humidifier.NetworkManager.VpcAttachment> factoryAction = null) : ResourceFactory<Humidifier.NetworkManager.VpcAttachment>(resourceName)
{

    internal InnerVpcAttachmentVpcOptionsFactory OptionsFactory { get; set; }

    protected override Humidifier.NetworkManager.VpcAttachment Create()
    {
        var vpcAttachmentResult = CreateVpcAttachment();
        factoryAction?.Invoke(vpcAttachmentResult);

        return vpcAttachmentResult;
    }

    private Humidifier.NetworkManager.VpcAttachment CreateVpcAttachment()
    {
        var vpcAttachmentResult = new Humidifier.NetworkManager.VpcAttachment
        {
            GivenName = InputResourceName,
        };

        return vpcAttachmentResult;
    }
    public override void CreateChildren(Humidifier.NetworkManager.VpcAttachment result)
    {
        base.CreateChildren(result);

        result.Options ??= OptionsFactory?.Build();
    }

} // End Of Class

public static class VpcAttachmentFactoryExtensions
{
    public static CombinedResult<VpcAttachmentFactory, InnerVpcAttachmentVpcOptionsFactory> WithOptions(this VpcAttachmentFactory parentFactory, Action<Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions> subFactoryAction = null)
    {
        parentFactory.OptionsFactory = new InnerVpcAttachmentVpcOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OptionsFactory);
    }

    public static CombinedResult<VpcAttachmentFactory, T1, InnerVpcAttachmentVpcOptionsFactory> WithOptions<T1>(this CombinedResult<VpcAttachmentFactory, T1> combinedResult, Action<Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VpcAttachmentFactory, InnerVpcAttachmentVpcOptionsFactory> WithOptions<T1>(this CombinedResult<T1, VpcAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<VpcAttachmentFactory, T1, T2, InnerVpcAttachmentVpcOptionsFactory> WithOptions<T1, T2>(this CombinedResult<VpcAttachmentFactory, T1, T2> combinedResult, Action<Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VpcAttachmentFactory, T2, InnerVpcAttachmentVpcOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, VpcAttachmentFactory, T2> combinedResult, Action<Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VpcAttachmentFactory, InnerVpcAttachmentVpcOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, T2, VpcAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<VpcAttachmentFactory, T1, T2, T3, InnerVpcAttachmentVpcOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<VpcAttachmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VpcAttachmentFactory, T2, T3, InnerVpcAttachmentVpcOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, VpcAttachmentFactory, T2, T3> combinedResult, Action<Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VpcAttachmentFactory, T3, InnerVpcAttachmentVpcOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, VpcAttachmentFactory, T3> combinedResult, Action<Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, VpcAttachmentFactory, InnerVpcAttachmentVpcOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, VpcAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<VpcAttachmentFactory, T1, T2, T3, T4, InnerVpcAttachmentVpcOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<VpcAttachmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VpcAttachmentFactory, T2, T3, T4, InnerVpcAttachmentVpcOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, VpcAttachmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VpcAttachmentFactory, T3, T4, InnerVpcAttachmentVpcOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, VpcAttachmentFactory, T3, T4> combinedResult, Action<Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, VpcAttachmentFactory, T4, InnerVpcAttachmentVpcOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VpcAttachmentFactory, T4> combinedResult, Action<Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, VpcAttachmentFactory, InnerVpcAttachmentVpcOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VpcAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T5, subFactoryAction).T2);
}
