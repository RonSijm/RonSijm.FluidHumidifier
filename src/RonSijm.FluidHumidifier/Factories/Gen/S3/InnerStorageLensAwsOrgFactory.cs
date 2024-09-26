// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensAwsOrgFactory(Action<Humidifier.S3.StorageLensTypes.AwsOrg> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensTypes.AwsOrg>
{

    protected override Humidifier.S3.StorageLensTypes.AwsOrg Create()
    {
        var awsOrgResult = CreateAwsOrg();
        factoryAction?.Invoke(awsOrgResult);

        return awsOrgResult;
    }

    private Humidifier.S3.StorageLensTypes.AwsOrg CreateAwsOrg()
    {
        var awsOrgResult = new Humidifier.S3.StorageLensTypes.AwsOrg();

        return awsOrgResult;
    }

} // End Of Class

public static class InnerStorageLensAwsOrgFactoryExtensions
{
}
