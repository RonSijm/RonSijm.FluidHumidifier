// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class InnerVpcAttachmentVpcOptionsFactory(Action<Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions> factoryAction = null) : SubResourceFactory<Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions>
{

    protected override Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions Create()
    {
        var vpcOptionsResult = CreateVpcOptions();
        factoryAction?.Invoke(vpcOptionsResult);

        return vpcOptionsResult;
    }

    private Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions CreateVpcOptions()
    {
        var vpcOptionsResult = new Humidifier.NetworkManager.VpcAttachmentTypes.VpcOptions();

        return vpcOptionsResult;
    }

} // End Of Class

public static class InnerVpcAttachmentVpcOptionsFactoryExtensions
{
}
