// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OSIS;

public class InnerPipelineVpcAttachmentOptionsFactory(Action<Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions> factoryAction = null) : SubResourceFactory<Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions>
{

    protected override Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions Create()
    {
        var vpcAttachmentOptionsResult = CreateVpcAttachmentOptions();
        factoryAction?.Invoke(vpcAttachmentOptionsResult);

        return vpcAttachmentOptionsResult;
    }

    private Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions CreateVpcAttachmentOptions()
    {
        var vpcAttachmentOptionsResult = new Humidifier.OSIS.PipelineTypes.VpcAttachmentOptions();

        return vpcAttachmentOptionsResult;
    }

} // End Of Class

public static class InnerPipelineVpcAttachmentOptionsFactoryExtensions
{
}
