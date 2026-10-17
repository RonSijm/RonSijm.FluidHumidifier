// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCS;

public class InnerClusterAccountingFactory(Action<Humidifier.PCS.ClusterTypes.Accounting> factoryAction = null) : SubResourceFactory<Humidifier.PCS.ClusterTypes.Accounting>
{

    protected override Humidifier.PCS.ClusterTypes.Accounting Create()
    {
        var accountingResult = CreateAccounting();
        factoryAction?.Invoke(accountingResult);

        return accountingResult;
    }

    private Humidifier.PCS.ClusterTypes.Accounting CreateAccounting()
    {
        var accountingResult = new Humidifier.PCS.ClusterTypes.Accounting();

        return accountingResult;
    }

} // End Of Class

public static class InnerClusterAccountingFactoryExtensions
{
}
