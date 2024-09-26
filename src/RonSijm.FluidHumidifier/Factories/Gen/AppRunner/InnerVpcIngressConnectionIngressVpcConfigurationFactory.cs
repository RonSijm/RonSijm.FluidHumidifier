// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class InnerVpcIngressConnectionIngressVpcConfigurationFactory(Action<Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration>
{

    protected override Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration Create()
    {
        var ingressVpcConfigurationResult = CreateIngressVpcConfiguration();
        factoryAction?.Invoke(ingressVpcConfigurationResult);

        return ingressVpcConfigurationResult;
    }

    private Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration CreateIngressVpcConfiguration()
    {
        var ingressVpcConfigurationResult = new Humidifier.AppRunner.VpcIngressConnectionTypes.IngressVpcConfiguration();

        return ingressVpcConfigurationResult;
    }

} // End Of Class

public static class InnerVpcIngressConnectionIngressVpcConfigurationFactoryExtensions
{
}
