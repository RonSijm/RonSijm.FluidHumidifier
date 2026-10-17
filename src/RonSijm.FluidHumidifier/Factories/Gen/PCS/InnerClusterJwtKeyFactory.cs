// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCS;

public class InnerClusterJwtKeyFactory(Action<Humidifier.PCS.ClusterTypes.JwtKey> factoryAction = null) : SubResourceFactory<Humidifier.PCS.ClusterTypes.JwtKey>
{

    protected override Humidifier.PCS.ClusterTypes.JwtKey Create()
    {
        var jwtKeyResult = CreateJwtKey();
        factoryAction?.Invoke(jwtKeyResult);

        return jwtKeyResult;
    }

    private Humidifier.PCS.ClusterTypes.JwtKey CreateJwtKey()
    {
        var jwtKeyResult = new Humidifier.PCS.ClusterTypes.JwtKey();

        return jwtKeyResult;
    }

} // End Of Class

public static class InnerClusterJwtKeyFactoryExtensions
{
}
