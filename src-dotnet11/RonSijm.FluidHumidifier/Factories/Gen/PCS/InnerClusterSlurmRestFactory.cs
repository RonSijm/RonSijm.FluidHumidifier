// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCS;

public class InnerClusterSlurmRestFactory(Action<Humidifier.PCS.ClusterTypes.SlurmRest> factoryAction = null) : SubResourceFactory<Humidifier.PCS.ClusterTypes.SlurmRest>
{

    protected override Humidifier.PCS.ClusterTypes.SlurmRest Create()
    {
        var slurmRestResult = CreateSlurmRest();
        factoryAction?.Invoke(slurmRestResult);

        return slurmRestResult;
    }

    private Humidifier.PCS.ClusterTypes.SlurmRest CreateSlurmRest()
    {
        var slurmRestResult = new Humidifier.PCS.ClusterTypes.SlurmRest();

        return slurmRestResult;
    }

} // End Of Class

public static class InnerClusterSlurmRestFactoryExtensions
{
}
