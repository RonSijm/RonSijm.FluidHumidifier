// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Macie;

public class InnerAllowListS3WordsListFactory(Action<Humidifier.Macie.AllowListTypes.S3WordsList> factoryAction = null) : SubResourceFactory<Humidifier.Macie.AllowListTypes.S3WordsList>
{

    protected override Humidifier.Macie.AllowListTypes.S3WordsList Create()
    {
        var s3WordsListResult = CreateS3WordsList();
        factoryAction?.Invoke(s3WordsListResult);

        return s3WordsListResult;
    }

    private Humidifier.Macie.AllowListTypes.S3WordsList CreateS3WordsList()
    {
        var s3WordsListResult = new Humidifier.Macie.AllowListTypes.S3WordsList();

        return s3WordsListResult;
    }

} // End Of Class

public static class InnerAllowListS3WordsListFactoryExtensions
{
}
