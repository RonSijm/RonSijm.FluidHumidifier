// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterPublicAccessFactory(Action<Humidifier.MSK.ClusterTypes.PublicAccess> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.PublicAccess>
{

    protected override Humidifier.MSK.ClusterTypes.PublicAccess Create()
    {
        var publicAccessResult = CreatePublicAccess();
        factoryAction?.Invoke(publicAccessResult);

        return publicAccessResult;
    }

    private Humidifier.MSK.ClusterTypes.PublicAccess CreatePublicAccess()
    {
        var publicAccessResult = new Humidifier.MSK.ClusterTypes.PublicAccess();

        return publicAccessResult;
    }

} // End Of Class

public static class InnerClusterPublicAccessFactoryExtensions
{
}
