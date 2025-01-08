// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class InnerSecurityConfigIamIdentityCenterConfigOptionsFactory(Action<Humidifier.OpenSearchServerless.SecurityConfigTypes.IamIdentityCenterConfigOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchServerless.SecurityConfigTypes.IamIdentityCenterConfigOptions>
{

    protected override Humidifier.OpenSearchServerless.SecurityConfigTypes.IamIdentityCenterConfigOptions Create()
    {
        var iamIdentityCenterConfigOptionsResult = CreateIamIdentityCenterConfigOptions();
        factoryAction?.Invoke(iamIdentityCenterConfigOptionsResult);

        return iamIdentityCenterConfigOptionsResult;
    }

    private Humidifier.OpenSearchServerless.SecurityConfigTypes.IamIdentityCenterConfigOptions CreateIamIdentityCenterConfigOptions()
    {
        var iamIdentityCenterConfigOptionsResult = new Humidifier.OpenSearchServerless.SecurityConfigTypes.IamIdentityCenterConfigOptions();

        return iamIdentityCenterConfigOptionsResult;
    }

} // End Of Class

public static class InnerSecurityConfigIamIdentityCenterConfigOptionsFactoryExtensions
{
}
