// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterProviderFactory(Action<Humidifier.EKS.ClusterTypes.Provider> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.Provider>
{

    protected override Humidifier.EKS.ClusterTypes.Provider Create()
    {
        var providerResult = CreateProvider();
        factoryAction?.Invoke(providerResult);

        return providerResult;
    }

    private Humidifier.EKS.ClusterTypes.Provider CreateProvider()
    {
        var providerResult = new Humidifier.EKS.ClusterTypes.Provider();

        return providerResult;
    }

} // End Of Class

public static class InnerClusterProviderFactoryExtensions
{
}
