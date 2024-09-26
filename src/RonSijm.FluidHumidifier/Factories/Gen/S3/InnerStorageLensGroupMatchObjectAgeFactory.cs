// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensGroupMatchObjectAgeFactory(Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge>
{

    protected override Humidifier.S3.StorageLensGroupTypes.MatchObjectAge Create()
    {
        var matchObjectAgeResult = CreateMatchObjectAge();
        factoryAction?.Invoke(matchObjectAgeResult);

        return matchObjectAgeResult;
    }

    private Humidifier.S3.StorageLensGroupTypes.MatchObjectAge CreateMatchObjectAge()
    {
        var matchObjectAgeResult = new Humidifier.S3.StorageLensGroupTypes.MatchObjectAge();

        return matchObjectAgeResult;
    }

} // End Of Class

public static class InnerStorageLensGroupMatchObjectAgeFactoryExtensions
{
}
