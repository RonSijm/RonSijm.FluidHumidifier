// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCS;

public class InnerClusterAuthKeyFactory(Action<Humidifier.PCS.ClusterTypes.AuthKey> factoryAction = null) : SubResourceFactory<Humidifier.PCS.ClusterTypes.AuthKey>
{

    protected override Humidifier.PCS.ClusterTypes.AuthKey Create()
    {
        var authKeyResult = CreateAuthKey();
        factoryAction?.Invoke(authKeyResult);

        return authKeyResult;
    }

    private Humidifier.PCS.ClusterTypes.AuthKey CreateAuthKey()
    {
        var authKeyResult = new Humidifier.PCS.ClusterTypes.AuthKey();

        return authKeyResult;
    }

} // End Of Class

public static class InnerClusterAuthKeyFactoryExtensions
{
}
