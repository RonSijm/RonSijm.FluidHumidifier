// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Tables;

public class InnerTableBucketUnreferencedFileRemovalFactory(Action<Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval> factoryAction = null) : SubResourceFactory<Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval>
{

    protected override Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval Create()
    {
        var unreferencedFileRemovalResult = CreateUnreferencedFileRemoval();
        factoryAction?.Invoke(unreferencedFileRemovalResult);

        return unreferencedFileRemovalResult;
    }

    private Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval CreateUnreferencedFileRemoval()
    {
        var unreferencedFileRemovalResult = new Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval();

        return unreferencedFileRemovalResult;
    }

} // End Of Class

public static class InnerTableBucketUnreferencedFileRemovalFactoryExtensions
{
}
