// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OSIS;

public class InnerPipelineVpcOptionsFactory(Action<Humidifier.OSIS.PipelineTypes.VpcOptions> factoryAction = null) : SubResourceFactory<Humidifier.OSIS.PipelineTypes.VpcOptions>
{

    internal InnerPipelineVpcAttachmentOptionsFactory VpcAttachmentOptionsFactory { get; set; }

    protected override Humidifier.OSIS.PipelineTypes.VpcOptions Create()
    {
        var vpcOptionsResult = CreateVpcOptions();
        factoryAction?.Invoke(vpcOptionsResult);

        return vpcOptionsResult;
    }

    private Humidifier.OSIS.PipelineTypes.VpcOptions CreateVpcOptions()
    {
        var vpcOptionsResult = new Humidifier.OSIS.PipelineTypes.VpcOptions();

        return vpcOptionsResult;
    }
    public override void CreateChildren(Humidifier.OSIS.PipelineTypes.VpcOptions result)
    {
        base.CreateChildren(result);

        result.VpcAttachmentOptions ??= VpcAttachmentOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerPipelineVpcOptionsFactoryExtensions
{
    public static CombinedResult<InnerPipelineVpcOptionsFactory, InnerPipelineVpcAttachmentOptionsFactory> WithVpcAttachmentOptions(this InnerPipelineVpcOptionsFactory parentFactory, Action<Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions> subFactoryAction = null)
    {
        parentFactory.VpcAttachmentOptionsFactory = new InnerPipelineVpcAttachmentOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcAttachmentOptionsFactory);
    }

    public static CombinedResult<InnerPipelineVpcOptionsFactory, T1, InnerPipelineVpcAttachmentOptionsFactory> WithVpcAttachmentOptions<T1>(this CombinedResult<InnerPipelineVpcOptionsFactory, T1> combinedResult, Action<Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcAttachmentOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineVpcOptionsFactory, InnerPipelineVpcAttachmentOptionsFactory> WithVpcAttachmentOptions<T1>(this CombinedResult<T1, InnerPipelineVpcOptionsFactory> combinedResult, Action<Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcAttachmentOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPipelineVpcOptionsFactory, T1, T2, InnerPipelineVpcAttachmentOptionsFactory> WithVpcAttachmentOptions<T1, T2>(this CombinedResult<InnerPipelineVpcOptionsFactory, T1, T2> combinedResult, Action<Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcAttachmentOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineVpcOptionsFactory, T2, InnerPipelineVpcAttachmentOptionsFactory> WithVpcAttachmentOptions<T1, T2>(this CombinedResult<T1, InnerPipelineVpcOptionsFactory, T2> combinedResult, Action<Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcAttachmentOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelineVpcOptionsFactory, InnerPipelineVpcAttachmentOptionsFactory> WithVpcAttachmentOptions<T1, T2>(this CombinedResult<T1, T2, InnerPipelineVpcOptionsFactory> combinedResult, Action<Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcAttachmentOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPipelineVpcOptionsFactory, T1, T2, T3, InnerPipelineVpcAttachmentOptionsFactory> WithVpcAttachmentOptions<T1, T2, T3>(this CombinedResult<InnerPipelineVpcOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcAttachmentOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineVpcOptionsFactory, T2, T3, InnerPipelineVpcAttachmentOptionsFactory> WithVpcAttachmentOptions<T1, T2, T3>(this CombinedResult<T1, InnerPipelineVpcOptionsFactory, T2, T3> combinedResult, Action<Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcAttachmentOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelineVpcOptionsFactory, T3, InnerPipelineVpcAttachmentOptionsFactory> WithVpcAttachmentOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerPipelineVpcOptionsFactory, T3> combinedResult, Action<Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcAttachmentOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipelineVpcOptionsFactory, InnerPipelineVpcAttachmentOptionsFactory> WithVpcAttachmentOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPipelineVpcOptionsFactory> combinedResult, Action<Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcAttachmentOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPipelineVpcOptionsFactory, T1, T2, T3, T4, InnerPipelineVpcAttachmentOptionsFactory> WithVpcAttachmentOptions<T1, T2, T3, T4>(this CombinedResult<InnerPipelineVpcOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcAttachmentOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineVpcOptionsFactory, T2, T3, T4, InnerPipelineVpcAttachmentOptionsFactory> WithVpcAttachmentOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerPipelineVpcOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcAttachmentOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelineVpcOptionsFactory, T3, T4, InnerPipelineVpcAttachmentOptionsFactory> WithVpcAttachmentOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPipelineVpcOptionsFactory, T3, T4> combinedResult, Action<Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcAttachmentOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipelineVpcOptionsFactory, T4, InnerPipelineVpcAttachmentOptionsFactory> WithVpcAttachmentOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPipelineVpcOptionsFactory, T4> combinedResult, Action<Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcAttachmentOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPipelineVpcOptionsFactory, InnerPipelineVpcAttachmentOptionsFactory> WithVpcAttachmentOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPipelineVpcOptionsFactory> combinedResult, Action<Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcAttachmentOptions(combinedResult.T5, subFactoryAction));
}
