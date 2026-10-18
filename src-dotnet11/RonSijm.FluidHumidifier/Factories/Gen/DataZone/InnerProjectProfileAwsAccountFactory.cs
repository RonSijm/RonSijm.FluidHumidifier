// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerProjectProfileAwsAccountFactory(Action<Humidifier.DataZone.ProjectProfileTypes.AwsAccount> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ProjectProfileTypes.AwsAccount>
{

    protected override Humidifier.DataZone.ProjectProfileTypes.AwsAccount Create()
    {
        var awsAccountResult = CreateAwsAccount();
        factoryAction?.Invoke(awsAccountResult);

        return awsAccountResult;
    }

    private Humidifier.DataZone.ProjectProfileTypes.AwsAccount CreateAwsAccount()
    {
        var awsAccountResult = new Humidifier.DataZone.ProjectProfileTypes.AwsAccount();

        return awsAccountResult;
    }

} // End Of Class

public static class InnerProjectProfileAwsAccountFactoryExtensions
{
}
