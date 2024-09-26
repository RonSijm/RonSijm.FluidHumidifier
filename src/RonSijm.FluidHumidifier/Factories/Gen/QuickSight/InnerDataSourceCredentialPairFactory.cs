// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceCredentialPairFactory(Action<Humidifier.QuickSight.DataSourceTypes.CredentialPair> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.CredentialPair>
{

    protected override Humidifier.QuickSight.DataSourceTypes.CredentialPair Create()
    {
        var credentialPairResult = CreateCredentialPair();
        factoryAction?.Invoke(credentialPairResult);

        return credentialPairResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.CredentialPair CreateCredentialPair()
    {
        var credentialPairResult = new Humidifier.QuickSight.DataSourceTypes.CredentialPair();

        return credentialPairResult;
    }

} // End Of Class

public static class InnerDataSourceCredentialPairFactoryExtensions
{
}
