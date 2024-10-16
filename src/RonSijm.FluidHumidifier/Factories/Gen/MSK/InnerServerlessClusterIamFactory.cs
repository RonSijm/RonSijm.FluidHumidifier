// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerServerlessClusterIamFactory(Action<Humidifier.MSK.ServerlessClusterTypes.Iam> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ServerlessClusterTypes.Iam>
{

    protected override Humidifier.MSK.ServerlessClusterTypes.Iam Create()
    {
        var iamResult = CreateIam();
        factoryAction?.Invoke(iamResult);

        return iamResult;
    }

    private Humidifier.MSK.ServerlessClusterTypes.Iam CreateIam()
    {
        var iamResult = new Humidifier.MSK.ServerlessClusterTypes.Iam();

        return iamResult;
    }

} // End Of Class

public static class InnerServerlessClusterIamFactoryExtensions
{
}
