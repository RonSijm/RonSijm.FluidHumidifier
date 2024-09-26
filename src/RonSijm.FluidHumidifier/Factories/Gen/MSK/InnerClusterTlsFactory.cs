// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterTlsFactory(Action<Humidifier.MSK.ClusterTypes.Tls> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.Tls>
{

    protected override Humidifier.MSK.ClusterTypes.Tls Create()
    {
        var tlsResult = CreateTls();
        factoryAction?.Invoke(tlsResult);

        return tlsResult;
    }

    private Humidifier.MSK.ClusterTypes.Tls CreateTls()
    {
        var tlsResult = new Humidifier.MSK.ClusterTypes.Tls();

        return tlsResult;
    }

} // End Of Class

public static class InnerClusterTlsFactoryExtensions
{
}
