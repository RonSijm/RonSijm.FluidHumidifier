// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Amplify;

public class InnerAppBasicAuthConfigFactory(Action<Humidifier.Amplify.AppTypes.BasicAuthConfig> factoryAction = null) : SubResourceFactory<Humidifier.Amplify.AppTypes.BasicAuthConfig>
{

    protected override Humidifier.Amplify.AppTypes.BasicAuthConfig Create()
    {
        var basicAuthConfigResult = CreateBasicAuthConfig();
        factoryAction?.Invoke(basicAuthConfigResult);

        return basicAuthConfigResult;
    }

    private Humidifier.Amplify.AppTypes.BasicAuthConfig CreateBasicAuthConfig()
    {
        var basicAuthConfigResult = new Humidifier.Amplify.AppTypes.BasicAuthConfig();

        return basicAuthConfigResult;
    }

} // End Of Class

public static class InnerAppBasicAuthConfigFactoryExtensions
{
}
