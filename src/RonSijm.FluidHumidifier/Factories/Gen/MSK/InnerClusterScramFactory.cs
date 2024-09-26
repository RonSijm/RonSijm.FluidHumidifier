// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterScramFactory(Action<Humidifier.MSK.ClusterTypes.Scram> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.Scram>
{

    protected override Humidifier.MSK.ClusterTypes.Scram Create()
    {
        var scramResult = CreateScram();
        factoryAction?.Invoke(scramResult);

        return scramResult;
    }

    private Humidifier.MSK.ClusterTypes.Scram CreateScram()
    {
        var scramResult = new Humidifier.MSK.ClusterTypes.Scram();

        return scramResult;
    }

} // End Of Class

public static class InnerClusterScramFactoryExtensions
{
}
