// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerResourceDataSyncAwsOrganizationsSourceFactory(Action<Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource> factoryAction = null) : SubResourceFactory<Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource>
{

    protected override Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource Create()
    {
        var awsOrganizationsSourceResult = CreateAwsOrganizationsSource();
        factoryAction?.Invoke(awsOrganizationsSourceResult);

        return awsOrganizationsSourceResult;
    }

    private Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource CreateAwsOrganizationsSource()
    {
        var awsOrganizationsSourceResult = new Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource();

        return awsOrganizationsSourceResult;
    }

} // End Of Class

public static class InnerResourceDataSyncAwsOrganizationsSourceFactoryExtensions
{
}
