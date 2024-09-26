// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Amplify;

public class InnerBranchBasicAuthConfigFactory(Action<Humidifier.Amplify.BranchTypes.BasicAuthConfig> factoryAction = null) : SubResourceFactory<Humidifier.Amplify.BranchTypes.BasicAuthConfig>
{

    protected override Humidifier.Amplify.BranchTypes.BasicAuthConfig Create()
    {
        var basicAuthConfigResult = CreateBasicAuthConfig();
        factoryAction?.Invoke(basicAuthConfigResult);

        return basicAuthConfigResult;
    }

    private Humidifier.Amplify.BranchTypes.BasicAuthConfig CreateBasicAuthConfig()
    {
        var basicAuthConfigResult = new Humidifier.Amplify.BranchTypes.BasicAuthConfig();

        return basicAuthConfigResult;
    }

} // End Of Class

public static class InnerBranchBasicAuthConfigFactoryExtensions
{
}
