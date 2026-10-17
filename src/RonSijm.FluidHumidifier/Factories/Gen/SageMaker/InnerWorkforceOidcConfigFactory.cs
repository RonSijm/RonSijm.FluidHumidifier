// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerWorkforceOidcConfigFactory(Action<Humidifier.SageMaker.WorkforceTypes.OidcConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.WorkforceTypes.OidcConfig>
{

    protected override Humidifier.SageMaker.WorkforceTypes.OidcConfig Create()
    {
        var oidcConfigResult = CreateOidcConfig();
        factoryAction?.Invoke(oidcConfigResult);

        return oidcConfigResult;
    }

    private Humidifier.SageMaker.WorkforceTypes.OidcConfig CreateOidcConfig()
    {
        var oidcConfigResult = new Humidifier.SageMaker.WorkforceTypes.OidcConfig();

        return oidcConfigResult;
    }

} // End Of Class

public static class InnerWorkforceOidcConfigFactoryExtensions
{
}
