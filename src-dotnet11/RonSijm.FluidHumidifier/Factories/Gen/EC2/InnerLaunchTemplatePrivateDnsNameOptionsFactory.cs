// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplatePrivateDnsNameOptionsFactory(Action<Humidifier.EC2.LaunchTemplateTypes.PrivateDnsNameOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.PrivateDnsNameOptions>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.PrivateDnsNameOptions Create()
    {
        var privateDnsNameOptionsResult = CreatePrivateDnsNameOptions();
        factoryAction?.Invoke(privateDnsNameOptionsResult);

        return privateDnsNameOptionsResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.PrivateDnsNameOptions CreatePrivateDnsNameOptions()
    {
        var privateDnsNameOptionsResult = new Humidifier.EC2.LaunchTemplateTypes.PrivateDnsNameOptions();

        return privateDnsNameOptionsResult;
    }

} // End Of Class

public static class InnerLaunchTemplatePrivateDnsNameOptionsFactoryExtensions
{
}
