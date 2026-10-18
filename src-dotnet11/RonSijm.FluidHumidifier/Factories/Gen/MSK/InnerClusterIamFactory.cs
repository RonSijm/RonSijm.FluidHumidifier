// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterIamFactory(Action<Humidifier.MSK.ClusterTypes.Iam> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.Iam>
{

    protected override Humidifier.MSK.ClusterTypes.Iam Create()
    {
        var iamResult = CreateIam();
        factoryAction?.Invoke(iamResult);

        return iamResult;
    }

    private Humidifier.MSK.ClusterTypes.Iam CreateIam()
    {
        var iamResult = new Humidifier.MSK.ClusterTypes.Iam();

        return iamResult;
    }

} // End Of Class

public static class InnerClusterIamFactoryExtensions
{
}
