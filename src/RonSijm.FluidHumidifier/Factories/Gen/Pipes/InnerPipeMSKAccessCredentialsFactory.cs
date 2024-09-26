// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipeMSKAccessCredentialsFactory(Action<Humidifier.Pipes.PipeTypes.MSKAccessCredentials> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.MSKAccessCredentials>
{

    protected override Humidifier.Pipes.PipeTypes.MSKAccessCredentials Create()
    {
        var mSKAccessCredentialsResult = CreateMSKAccessCredentials();
        factoryAction?.Invoke(mSKAccessCredentialsResult);

        return mSKAccessCredentialsResult;
    }

    private Humidifier.Pipes.PipeTypes.MSKAccessCredentials CreateMSKAccessCredentials()
    {
        var mSKAccessCredentialsResult = new Humidifier.Pipes.PipeTypes.MSKAccessCredentials();

        return mSKAccessCredentialsResult;
    }

} // End Of Class

public static class InnerPipeMSKAccessCredentialsFactoryExtensions
{
}
