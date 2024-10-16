// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerGameServerGroupLaunchTemplateFactory(Action<Humidifier.GameLift.GameServerGroupTypes.LaunchTemplate> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.GameServerGroupTypes.LaunchTemplate>
{

    protected override Humidifier.GameLift.GameServerGroupTypes.LaunchTemplate Create()
    {
        var launchTemplateResult = CreateLaunchTemplate();
        factoryAction?.Invoke(launchTemplateResult);

        return launchTemplateResult;
    }

    private Humidifier.GameLift.GameServerGroupTypes.LaunchTemplate CreateLaunchTemplate()
    {
        var launchTemplateResult = new Humidifier.GameLift.GameServerGroupTypes.LaunchTemplate();

        return launchTemplateResult;
    }

} // End Of Class

public static class InnerGameServerGroupLaunchTemplateFactoryExtensions
{
}
