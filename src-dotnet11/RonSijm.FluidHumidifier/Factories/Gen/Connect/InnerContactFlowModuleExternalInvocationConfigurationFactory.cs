// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerContactFlowModuleExternalInvocationConfigurationFactory(Action<Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration>
{

    protected override Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration Create()
    {
        var externalInvocationConfigurationResult = CreateExternalInvocationConfiguration();
        factoryAction?.Invoke(externalInvocationConfigurationResult);

        return externalInvocationConfigurationResult;
    }

    private Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration CreateExternalInvocationConfiguration()
    {
        var externalInvocationConfigurationResult = new Humidifier.Connect.ContactFlowModuleTypes.ExternalInvocationConfiguration();

        return externalInvocationConfigurationResult;
    }

} // End Of Class

public static class InnerContactFlowModuleExternalInvocationConfigurationFactoryExtensions
{
}
