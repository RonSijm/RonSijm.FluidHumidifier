// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerApplicationIdentityCenterConfigurationFactory(Action<Humidifier.EMRServerless.ApplicationTypes.IdentityCenterConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.ApplicationTypes.IdentityCenterConfiguration>
{

    protected override Humidifier.EMRServerless.ApplicationTypes.IdentityCenterConfiguration Create()
    {
        var identityCenterConfigurationResult = CreateIdentityCenterConfiguration();
        factoryAction?.Invoke(identityCenterConfigurationResult);

        return identityCenterConfigurationResult;
    }

    private Humidifier.EMRServerless.ApplicationTypes.IdentityCenterConfiguration CreateIdentityCenterConfiguration()
    {
        var identityCenterConfigurationResult = new Humidifier.EMRServerless.ApplicationTypes.IdentityCenterConfiguration();

        return identityCenterConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationIdentityCenterConfigurationFactoryExtensions
{
}
