// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class InnerLegalHoldDateRangeFactory(Action<Humidifier.Backup.LegalHoldTypes.DateRange> factoryAction = null) : SubResourceFactory<Humidifier.Backup.LegalHoldTypes.DateRange>
{

    protected override Humidifier.Backup.LegalHoldTypes.DateRange Create()
    {
        var dateRangeResult = CreateDateRange();
        factoryAction?.Invoke(dateRangeResult);

        return dateRangeResult;
    }

    private Humidifier.Backup.LegalHoldTypes.DateRange CreateDateRange()
    {
        var dateRangeResult = new Humidifier.Backup.LegalHoldTypes.DateRange();

        return dateRangeResult;
    }

} // End Of Class

public static class InnerLegalHoldDateRangeFactoryExtensions
{
}
