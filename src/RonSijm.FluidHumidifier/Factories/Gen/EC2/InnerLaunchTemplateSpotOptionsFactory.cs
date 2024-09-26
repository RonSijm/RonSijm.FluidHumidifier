// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateSpotOptionsFactory(Action<Humidifier.EC2.LaunchTemplateTypes.SpotOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.SpotOptions>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.SpotOptions Create()
    {
        var spotOptionsResult = CreateSpotOptions();
        factoryAction?.Invoke(spotOptionsResult);

        return spotOptionsResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.SpotOptions CreateSpotOptions()
    {
        var spotOptionsResult = new Humidifier.EC2.LaunchTemplateTypes.SpotOptions();

        return spotOptionsResult;
    }

} // End Of Class

public static class InnerLaunchTemplateSpotOptionsFactoryExtensions
{
}
