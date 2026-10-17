// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerImportSnapshotTaskUserBucketFactory(Action<Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket> factoryAction = null) : SubResourceFactory<Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket>
{

    protected override Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket Create()
    {
        var userBucketResult = CreateUserBucket();
        factoryAction?.Invoke(userBucketResult);

        return userBucketResult;
    }

    private Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket CreateUserBucket()
    {
        var userBucketResult = new Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket();

        return userBucketResult;
    }

} // End Of Class

public static class InnerImportSnapshotTaskUserBucketFactoryExtensions
{
}
