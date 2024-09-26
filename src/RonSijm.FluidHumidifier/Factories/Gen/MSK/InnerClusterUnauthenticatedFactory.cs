// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterUnauthenticatedFactory(Action<Humidifier.MSK.ClusterTypes.Unauthenticated> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.Unauthenticated>
{

    protected override Humidifier.MSK.ClusterTypes.Unauthenticated Create()
    {
        var unauthenticatedResult = CreateUnauthenticated();
        factoryAction?.Invoke(unauthenticatedResult);

        return unauthenticatedResult;
    }

    private Humidifier.MSK.ClusterTypes.Unauthenticated CreateUnauthenticated()
    {
        var unauthenticatedResult = new Humidifier.MSK.ClusterTypes.Unauthenticated();

        return unauthenticatedResult;
    }

} // End Of Class

public static class InnerClusterUnauthenticatedFactoryExtensions
{
}
