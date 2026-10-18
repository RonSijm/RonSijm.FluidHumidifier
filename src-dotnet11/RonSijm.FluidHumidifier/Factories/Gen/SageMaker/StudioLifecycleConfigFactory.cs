// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class StudioLifecycleConfigFactory(string resourceName = null, Action<Humidifier.SageMaker.StudioLifecycleConfig> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.StudioLifecycleConfig>(resourceName)
{

    protected override Humidifier.SageMaker.StudioLifecycleConfig Create()
    {
        var studioLifecycleConfigResult = CreateStudioLifecycleConfig();
        factoryAction?.Invoke(studioLifecycleConfigResult);

        return studioLifecycleConfigResult;
    }

    private Humidifier.SageMaker.StudioLifecycleConfig CreateStudioLifecycleConfig()
    {
        var studioLifecycleConfigResult = new Humidifier.SageMaker.StudioLifecycleConfig
        {
            GivenName = InputResourceName,
        };

        return studioLifecycleConfigResult;
    }

} // End Of Class

public static class StudioLifecycleConfigFactoryExtensions
{
}
