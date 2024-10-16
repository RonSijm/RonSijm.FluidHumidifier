// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class InnerSecurityConfigSamlConfigOptionsFactory(Action<Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions>
{

    protected override Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions Create()
    {
        var samlConfigOptionsResult = CreateSamlConfigOptions();
        factoryAction?.Invoke(samlConfigOptionsResult);

        return samlConfigOptionsResult;
    }

    private Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions CreateSamlConfigOptions()
    {
        var samlConfigOptionsResult = new Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions();

        return samlConfigOptionsResult;
    }

} // End Of Class

public static class InnerSecurityConfigSamlConfigOptionsFactoryExtensions
{
}
