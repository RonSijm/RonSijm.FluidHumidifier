// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeCommit;

public class InnerRepositoryCodeFactory(Action<Humidifier.CodeCommit.RepositoryTypes.Code> factoryAction = null) : SubResourceFactory<Humidifier.CodeCommit.RepositoryTypes.Code>
{

    internal InnerRepositoryS3Factory S3Factory { get; set; }

    protected override Humidifier.CodeCommit.RepositoryTypes.Code Create()
    {
        var codeResult = CreateCode();
        factoryAction?.Invoke(codeResult);

        return codeResult;
    }

    private Humidifier.CodeCommit.RepositoryTypes.Code CreateCode()
    {
        var codeResult = new Humidifier.CodeCommit.RepositoryTypes.Code();

        return codeResult;
    }
    public override void CreateChildren(Humidifier.CodeCommit.RepositoryTypes.Code result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class InnerRepositoryCodeFactoryExtensions
{
    public static CombinedResult<InnerRepositoryCodeFactory, InnerRepositoryS3Factory> WithS3(this InnerRepositoryCodeFactory parentFactory, Action<Humidifier.CodeCommit.RepositoryTypes.S3> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerRepositoryS3Factory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerRepositoryCodeFactory, T1, InnerRepositoryS3Factory> WithS3<T1>(this CombinedResult<InnerRepositoryCodeFactory, T1> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRepositoryCodeFactory, InnerRepositoryS3Factory> WithS3<T1>(this CombinedResult<T1, InnerRepositoryCodeFactory> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRepositoryCodeFactory, T1, T2, InnerRepositoryS3Factory> WithS3<T1, T2>(this CombinedResult<InnerRepositoryCodeFactory, T1, T2> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRepositoryCodeFactory, T2, InnerRepositoryS3Factory> WithS3<T1, T2>(this CombinedResult<T1, InnerRepositoryCodeFactory, T2> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRepositoryCodeFactory, InnerRepositoryS3Factory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerRepositoryCodeFactory> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRepositoryCodeFactory, T1, T2, T3, InnerRepositoryS3Factory> WithS3<T1, T2, T3>(this CombinedResult<InnerRepositoryCodeFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRepositoryCodeFactory, T2, T3, InnerRepositoryS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerRepositoryCodeFactory, T2, T3> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRepositoryCodeFactory, T3, InnerRepositoryS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerRepositoryCodeFactory, T3> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRepositoryCodeFactory, InnerRepositoryS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRepositoryCodeFactory> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRepositoryCodeFactory, T1, T2, T3, T4, InnerRepositoryS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerRepositoryCodeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRepositoryCodeFactory, T2, T3, T4, InnerRepositoryS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerRepositoryCodeFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRepositoryCodeFactory, T3, T4, InnerRepositoryS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRepositoryCodeFactory, T3, T4> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRepositoryCodeFactory, T4, InnerRepositoryS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRepositoryCodeFactory, T4> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRepositoryCodeFactory, InnerRepositoryS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRepositoryCodeFactory> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction));
}
