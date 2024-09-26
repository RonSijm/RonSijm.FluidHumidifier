// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterEncryptionInTransitFactory(Action<Humidifier.MSK.ClusterTypes.EncryptionInTransit> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.EncryptionInTransit>
{

    protected override Humidifier.MSK.ClusterTypes.EncryptionInTransit Create()
    {
        var encryptionInTransitResult = CreateEncryptionInTransit();
        factoryAction?.Invoke(encryptionInTransitResult);

        return encryptionInTransitResult;
    }

    private Humidifier.MSK.ClusterTypes.EncryptionInTransit CreateEncryptionInTransit()
    {
        var encryptionInTransitResult = new Humidifier.MSK.ClusterTypes.EncryptionInTransit();

        return encryptionInTransitResult;
    }

} // End Of Class

public static class InnerClusterEncryptionInTransitFactoryExtensions
{
}
