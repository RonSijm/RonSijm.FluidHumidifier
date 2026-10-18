// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MGN;

public class InnerLaunchConfigurationTemplatePostLaunchActionsFactory(Action<Humidifier.MGN.LaunchConfigurationTemplateTypes.PostLaunchActions> factoryAction = null) : SubResourceFactory<Humidifier.MGN.LaunchConfigurationTemplateTypes.PostLaunchActions>
{

    protected override Humidifier.MGN.LaunchConfigurationTemplateTypes.PostLaunchActions Create()
    {
        var postLaunchActionsResult = CreatePostLaunchActions();
        factoryAction?.Invoke(postLaunchActionsResult);

        return postLaunchActionsResult;
    }

    private Humidifier.MGN.LaunchConfigurationTemplateTypes.PostLaunchActions CreatePostLaunchActions()
    {
        var postLaunchActionsResult = new Humidifier.MGN.LaunchConfigurationTemplateTypes.PostLaunchActions();

        return postLaunchActionsResult;
    }

} // End Of Class

public static class InnerLaunchConfigurationTemplatePostLaunchActionsFactoryExtensions
{
}
