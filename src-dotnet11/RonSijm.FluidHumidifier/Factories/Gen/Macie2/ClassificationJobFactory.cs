// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Macie2;

public class ClassificationJobFactory(string resourceName = null, Action<Humidifier.Macie2.ClassificationJob> factoryAction = null) : ResourceFactory<Humidifier.Macie2.ClassificationJob>(resourceName)
{

    internal InnerClassificationJobS3JobDefinitionFactory S3JobDefinitionFactory { get; set; }

    internal InnerClassificationJobJobScheduleFrequencyFactory ScheduleFrequencyFactory { get; set; }

    protected override Humidifier.Macie2.ClassificationJob Create()
    {
        var classificationJobResult = CreateClassificationJob();
        factoryAction?.Invoke(classificationJobResult);

        return classificationJobResult;
    }

    private Humidifier.Macie2.ClassificationJob CreateClassificationJob()
    {
        var classificationJobResult = new Humidifier.Macie2.ClassificationJob
        {
            GivenName = InputResourceName,
        };

        return classificationJobResult;
    }
    public override void CreateChildren(Humidifier.Macie2.ClassificationJob result)
    {
        base.CreateChildren(result);

        result.S3JobDefinition ??= S3JobDefinitionFactory?.Build();
        result.ScheduleFrequency ??= ScheduleFrequencyFactory?.Build();
    }

} // End Of Class

public static class ClassificationJobFactoryExtensions
{
    public static CombinedResult<ClassificationJobFactory, InnerClassificationJobS3JobDefinitionFactory> WithS3JobDefinition(this ClassificationJobFactory parentFactory, Action<Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition> subFactoryAction = null)
    {
        parentFactory.S3JobDefinitionFactory = new InnerClassificationJobS3JobDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3JobDefinitionFactory);
    }

    public static CombinedResult<ClassificationJobFactory, InnerClassificationJobJobScheduleFrequencyFactory> WithScheduleFrequency(this ClassificationJobFactory parentFactory, Action<Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency> subFactoryAction = null)
    {
        parentFactory.ScheduleFrequencyFactory = new InnerClassificationJobJobScheduleFrequencyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScheduleFrequencyFactory);
    }

    public static CombinedResult<ClassificationJobFactory, T1, InnerClassificationJobS3JobDefinitionFactory> WithS3JobDefinition<T1>(this CombinedResult<ClassificationJobFactory, T1> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3JobDefinition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClassificationJobFactory, InnerClassificationJobS3JobDefinitionFactory> WithS3JobDefinition<T1>(this CombinedResult<T1, ClassificationJobFactory> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3JobDefinition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ClassificationJobFactory, T1, T2, InnerClassificationJobS3JobDefinitionFactory> WithS3JobDefinition<T1, T2>(this CombinedResult<ClassificationJobFactory, T1, T2> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3JobDefinition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClassificationJobFactory, T2, InnerClassificationJobS3JobDefinitionFactory> WithS3JobDefinition<T1, T2>(this CombinedResult<T1, ClassificationJobFactory, T2> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3JobDefinition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ClassificationJobFactory, InnerClassificationJobS3JobDefinitionFactory> WithS3JobDefinition<T1, T2>(this CombinedResult<T1, T2, ClassificationJobFactory> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3JobDefinition(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ClassificationJobFactory, T1, T2, T3, InnerClassificationJobS3JobDefinitionFactory> WithS3JobDefinition<T1, T2, T3>(this CombinedResult<ClassificationJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3JobDefinition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClassificationJobFactory, T2, T3, InnerClassificationJobS3JobDefinitionFactory> WithS3JobDefinition<T1, T2, T3>(this CombinedResult<T1, ClassificationJobFactory, T2, T3> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3JobDefinition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ClassificationJobFactory, T3, InnerClassificationJobS3JobDefinitionFactory> WithS3JobDefinition<T1, T2, T3>(this CombinedResult<T1, T2, ClassificationJobFactory, T3> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3JobDefinition(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ClassificationJobFactory, InnerClassificationJobS3JobDefinitionFactory> WithS3JobDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClassificationJobFactory> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3JobDefinition(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ClassificationJobFactory, T1, T2, T3, T4, InnerClassificationJobS3JobDefinitionFactory> WithS3JobDefinition<T1, T2, T3, T4>(this CombinedResult<ClassificationJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3JobDefinition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClassificationJobFactory, T2, T3, T4, InnerClassificationJobS3JobDefinitionFactory> WithS3JobDefinition<T1, T2, T3, T4>(this CombinedResult<T1, ClassificationJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3JobDefinition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ClassificationJobFactory, T3, T4, InnerClassificationJobS3JobDefinitionFactory> WithS3JobDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClassificationJobFactory, T3, T4> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3JobDefinition(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ClassificationJobFactory, T4, InnerClassificationJobS3JobDefinitionFactory> WithS3JobDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClassificationJobFactory, T4> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3JobDefinition(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ClassificationJobFactory, InnerClassificationJobS3JobDefinitionFactory> WithS3JobDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClassificationJobFactory> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.S3JobDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3JobDefinition(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ClassificationJobFactory, T1, InnerClassificationJobJobScheduleFrequencyFactory> WithScheduleFrequency<T1>(this CombinedResult<ClassificationJobFactory, T1> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClassificationJobFactory, InnerClassificationJobJobScheduleFrequencyFactory> WithScheduleFrequency<T1>(this CombinedResult<T1, ClassificationJobFactory> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ClassificationJobFactory, T1, T2, InnerClassificationJobJobScheduleFrequencyFactory> WithScheduleFrequency<T1, T2>(this CombinedResult<ClassificationJobFactory, T1, T2> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClassificationJobFactory, T2, InnerClassificationJobJobScheduleFrequencyFactory> WithScheduleFrequency<T1, T2>(this CombinedResult<T1, ClassificationJobFactory, T2> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ClassificationJobFactory, InnerClassificationJobJobScheduleFrequencyFactory> WithScheduleFrequency<T1, T2>(this CombinedResult<T1, T2, ClassificationJobFactory> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ClassificationJobFactory, T1, T2, T3, InnerClassificationJobJobScheduleFrequencyFactory> WithScheduleFrequency<T1, T2, T3>(this CombinedResult<ClassificationJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClassificationJobFactory, T2, T3, InnerClassificationJobJobScheduleFrequencyFactory> WithScheduleFrequency<T1, T2, T3>(this CombinedResult<T1, ClassificationJobFactory, T2, T3> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ClassificationJobFactory, T3, InnerClassificationJobJobScheduleFrequencyFactory> WithScheduleFrequency<T1, T2, T3>(this CombinedResult<T1, T2, ClassificationJobFactory, T3> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ClassificationJobFactory, InnerClassificationJobJobScheduleFrequencyFactory> WithScheduleFrequency<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClassificationJobFactory> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ClassificationJobFactory, T1, T2, T3, T4, InnerClassificationJobJobScheduleFrequencyFactory> WithScheduleFrequency<T1, T2, T3, T4>(this CombinedResult<ClassificationJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClassificationJobFactory, T2, T3, T4, InnerClassificationJobJobScheduleFrequencyFactory> WithScheduleFrequency<T1, T2, T3, T4>(this CombinedResult<T1, ClassificationJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ClassificationJobFactory, T3, T4, InnerClassificationJobJobScheduleFrequencyFactory> WithScheduleFrequency<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClassificationJobFactory, T3, T4> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ClassificationJobFactory, T4, InnerClassificationJobJobScheduleFrequencyFactory> WithScheduleFrequency<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClassificationJobFactory, T4> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ClassificationJobFactory, InnerClassificationJobJobScheduleFrequencyFactory> WithScheduleFrequency<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClassificationJobFactory> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T5, subFactoryAction).T2);
}
