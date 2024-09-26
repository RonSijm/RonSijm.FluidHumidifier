// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerApplicationInteractiveConfigurationFactory(Action<Humidifier.EMRServerless.ApplicationTypes.InteractiveConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.ApplicationTypes.InteractiveConfiguration>
{

    protected override Humidifier.EMRServerless.ApplicationTypes.InteractiveConfiguration Create()
    {
        var interactiveConfigurationResult = CreateInteractiveConfiguration();
        factoryAction?.Invoke(interactiveConfigurationResult);

        return interactiveConfigurationResult;
    }

    private Humidifier.EMRServerless.ApplicationTypes.InteractiveConfiguration CreateInteractiveConfiguration()
    {
        var interactiveConfigurationResult = new Humidifier.EMRServerless.ApplicationTypes.InteractiveConfiguration();

        return interactiveConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationInteractiveConfigurationFactoryExtensions
{
}
