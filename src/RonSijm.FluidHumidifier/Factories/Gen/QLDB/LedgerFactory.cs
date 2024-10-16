// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QLDB;

public class LedgerFactory(string resourceName = null, Action<Humidifier.QLDB.Ledger> factoryAction = null) : ResourceFactory<Humidifier.QLDB.Ledger>(resourceName)
{

    protected override Humidifier.QLDB.Ledger Create()
    {
        var ledgerResult = CreateLedger();
        factoryAction?.Invoke(ledgerResult);

        return ledgerResult;
    }

    private Humidifier.QLDB.Ledger CreateLedger()
    {
        var ledgerResult = new Humidifier.QLDB.Ledger
        {
            GivenName = InputResourceName,
        };

        return ledgerResult;
    }

} // End Of Class

public static class LedgerFactoryExtensions
{
}
