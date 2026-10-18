// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KMS;

public class AliasFactory(string resourceName = null, Action<Humidifier.KMS.Alias> factoryAction = null) : ResourceFactory<Humidifier.KMS.Alias>(resourceName)
{

    protected override Humidifier.KMS.Alias Create()
    {
        var aliasResult = CreateAlias();
        factoryAction?.Invoke(aliasResult);

        return aliasResult;
    }

    private Humidifier.KMS.Alias CreateAlias()
    {
        var aliasResult = new Humidifier.KMS.Alias
        {
            GivenName = InputResourceName,
        };

        return aliasResult;
    }

} // End Of Class

public static class AliasFactoryExtensions
{
}
