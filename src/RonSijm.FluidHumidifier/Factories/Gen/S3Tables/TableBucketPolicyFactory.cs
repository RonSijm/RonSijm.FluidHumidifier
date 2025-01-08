// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Tables;

public class TableBucketPolicyFactory(string resourceName = null, Action<Humidifier.S3Tables.TableBucketPolicy> factoryAction = null) : ResourceFactory<Humidifier.S3Tables.TableBucketPolicy>(resourceName)
{

    protected override Humidifier.S3Tables.TableBucketPolicy Create()
    {
        var tableBucketPolicyResult = CreateTableBucketPolicy();
        factoryAction?.Invoke(tableBucketPolicyResult);

        return tableBucketPolicyResult;
    }

    private Humidifier.S3Tables.TableBucketPolicy CreateTableBucketPolicy()
    {
        var tableBucketPolicyResult = new Humidifier.S3Tables.TableBucketPolicy
        {
            GivenName = InputResourceName,
        };

        return tableBucketPolicyResult;
    }

} // End Of Class

public static class TableBucketPolicyFactoryExtensions
{
}
