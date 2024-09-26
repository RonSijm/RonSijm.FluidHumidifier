// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensGroupMatchObjectSizeFactory(Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize>
{

    protected override Humidifier.S3.StorageLensGroupTypes.MatchObjectSize Create()
    {
        var matchObjectSizeResult = CreateMatchObjectSize();
        factoryAction?.Invoke(matchObjectSizeResult);

        return matchObjectSizeResult;
    }

    private Humidifier.S3.StorageLensGroupTypes.MatchObjectSize CreateMatchObjectSize()
    {
        var matchObjectSizeResult = new Humidifier.S3.StorageLensGroupTypes.MatchObjectSize();

        return matchObjectSizeResult;
    }

} // End Of Class

public static class InnerStorageLensGroupMatchObjectSizeFactoryExtensions
{
}
