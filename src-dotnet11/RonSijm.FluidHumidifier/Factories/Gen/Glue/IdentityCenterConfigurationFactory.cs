// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class IdentityCenterConfigurationFactory(string resourceName = null, Action<Humidifier.Glue.IdentityCenterConfiguration> factoryAction = null) : ResourceFactory<Humidifier.Glue.IdentityCenterConfiguration>(resourceName)
{

    protected override Humidifier.Glue.IdentityCenterConfiguration Create()
    {
        var identityCenterConfigurationResult = CreateIdentityCenterConfiguration();
        factoryAction?.Invoke(identityCenterConfigurationResult);

        return identityCenterConfigurationResult;
    }

    private Humidifier.Glue.IdentityCenterConfiguration CreateIdentityCenterConfiguration()
    {
        var identityCenterConfigurationResult = new Humidifier.Glue.IdentityCenterConfiguration
        {
            GivenName = InputResourceName,
        };

        return identityCenterConfigurationResult;
    }

} // End Of Class

public static class IdentityCenterConfigurationFactoryExtensions
{
}
