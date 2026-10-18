// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Macie2;

public class InnerClassificationJobS3JobDefinitionFactory(Action<Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition> factoryAction = null) : SubResourceFactory<Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition>
{

    protected override Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition Create()
    {
        var s3JobDefinitionResult = CreateS3JobDefinition();
        factoryAction?.Invoke(s3JobDefinitionResult);

        return s3JobDefinitionResult;
    }

    private Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition CreateS3JobDefinition()
    {
        var s3JobDefinitionResult = new Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition();

        return s3JobDefinitionResult;
    }

} // End Of Class

public static class InnerClassificationJobS3JobDefinitionFactoryExtensions
{
}
