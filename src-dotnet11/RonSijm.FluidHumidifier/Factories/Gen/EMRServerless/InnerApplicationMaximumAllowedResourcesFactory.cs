// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerApplicationMaximumAllowedResourcesFactory(Action<Humidifier.EMRServerless.ApplicationTypes.MaximumAllowedResources> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.ApplicationTypes.MaximumAllowedResources>
{

    protected override Humidifier.EMRServerless.ApplicationTypes.MaximumAllowedResources Create()
    {
        var maximumAllowedResourcesResult = CreateMaximumAllowedResources();
        factoryAction?.Invoke(maximumAllowedResourcesResult);

        return maximumAllowedResourcesResult;
    }

    private Humidifier.EMRServerless.ApplicationTypes.MaximumAllowedResources CreateMaximumAllowedResources()
    {
        var maximumAllowedResourcesResult = new Humidifier.EMRServerless.ApplicationTypes.MaximumAllowedResources();

        return maximumAllowedResourcesResult;
    }

} // End Of Class

public static class InnerApplicationMaximumAllowedResourcesFactoryExtensions
{
}
