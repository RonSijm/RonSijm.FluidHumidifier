// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseDatabaseCDCFactory(Action<Humidifier.AppTest.TestCaseTypes.DatabaseCDC> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.DatabaseCDC>
{

    internal InnerTestCaseSourceDatabaseMetadataFactory SourceMetadataFactory { get; set; }

    internal InnerTestCaseTargetDatabaseMetadataFactory TargetMetadataFactory { get; set; }

    protected override Humidifier.AppTest.TestCaseTypes.DatabaseCDC Create()
    {
        var databaseCDCResult = CreateDatabaseCDC();
        factoryAction?.Invoke(databaseCDCResult);

        return databaseCDCResult;
    }

    private Humidifier.AppTest.TestCaseTypes.DatabaseCDC CreateDatabaseCDC()
    {
        var databaseCDCResult = new Humidifier.AppTest.TestCaseTypes.DatabaseCDC();

        return databaseCDCResult;
    }
    public override void CreateChildren(Humidifier.AppTest.TestCaseTypes.DatabaseCDC result)
    {
        base.CreateChildren(result);

        result.SourceMetadata ??= SourceMetadataFactory?.Build();
        result.TargetMetadata ??= TargetMetadataFactory?.Build();
    }

} // End Of Class

public static class InnerTestCaseDatabaseCDCFactoryExtensions
{
    public static CombinedResult<InnerTestCaseDatabaseCDCFactory, InnerTestCaseSourceDatabaseMetadataFactory> WithSourceMetadata(this InnerTestCaseDatabaseCDCFactory parentFactory, Action<Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata> subFactoryAction = null)
    {
        parentFactory.SourceMetadataFactory = new InnerTestCaseSourceDatabaseMetadataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceMetadataFactory);
    }

    public static CombinedResult<InnerTestCaseDatabaseCDCFactory, InnerTestCaseTargetDatabaseMetadataFactory> WithTargetMetadata(this InnerTestCaseDatabaseCDCFactory parentFactory, Action<Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata> subFactoryAction = null)
    {
        parentFactory.TargetMetadataFactory = new InnerTestCaseTargetDatabaseMetadataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetMetadataFactory);
    }

    public static CombinedResult<InnerTestCaseDatabaseCDCFactory, T1, InnerTestCaseSourceDatabaseMetadataFactory> WithSourceMetadata<T1>(this CombinedResult<InnerTestCaseDatabaseCDCFactory, T1> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseDatabaseCDCFactory, InnerTestCaseSourceDatabaseMetadataFactory> WithSourceMetadata<T1>(this CombinedResult<T1, InnerTestCaseDatabaseCDCFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTestCaseDatabaseCDCFactory, T1, T2, InnerTestCaseSourceDatabaseMetadataFactory> WithSourceMetadata<T1, T2>(this CombinedResult<InnerTestCaseDatabaseCDCFactory, T1, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseDatabaseCDCFactory, T2, InnerTestCaseSourceDatabaseMetadataFactory> WithSourceMetadata<T1, T2>(this CombinedResult<T1, InnerTestCaseDatabaseCDCFactory, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseDatabaseCDCFactory, InnerTestCaseSourceDatabaseMetadataFactory> WithSourceMetadata<T1, T2>(this CombinedResult<T1, T2, InnerTestCaseDatabaseCDCFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTestCaseDatabaseCDCFactory, T1, T2, T3, InnerTestCaseSourceDatabaseMetadataFactory> WithSourceMetadata<T1, T2, T3>(this CombinedResult<InnerTestCaseDatabaseCDCFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseDatabaseCDCFactory, T2, T3, InnerTestCaseSourceDatabaseMetadataFactory> WithSourceMetadata<T1, T2, T3>(this CombinedResult<T1, InnerTestCaseDatabaseCDCFactory, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseDatabaseCDCFactory, T3, InnerTestCaseSourceDatabaseMetadataFactory> WithSourceMetadata<T1, T2, T3>(this CombinedResult<T1, T2, InnerTestCaseDatabaseCDCFactory, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseDatabaseCDCFactory, InnerTestCaseSourceDatabaseMetadataFactory> WithSourceMetadata<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTestCaseDatabaseCDCFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceMetadata(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTestCaseDatabaseCDCFactory, T1, T2, T3, T4, InnerTestCaseSourceDatabaseMetadataFactory> WithSourceMetadata<T1, T2, T3, T4>(this CombinedResult<InnerTestCaseDatabaseCDCFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseDatabaseCDCFactory, T2, T3, T4, InnerTestCaseSourceDatabaseMetadataFactory> WithSourceMetadata<T1, T2, T3, T4>(this CombinedResult<T1, InnerTestCaseDatabaseCDCFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseDatabaseCDCFactory, T3, T4, InnerTestCaseSourceDatabaseMetadataFactory> WithSourceMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTestCaseDatabaseCDCFactory, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseDatabaseCDCFactory, T4, InnerTestCaseSourceDatabaseMetadataFactory> WithSourceMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTestCaseDatabaseCDCFactory, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceMetadata(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTestCaseDatabaseCDCFactory, InnerTestCaseSourceDatabaseMetadataFactory> WithSourceMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTestCaseDatabaseCDCFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceMetadata(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerTestCaseDatabaseCDCFactory, T1, InnerTestCaseTargetDatabaseMetadataFactory> WithTargetMetadata<T1>(this CombinedResult<InnerTestCaseDatabaseCDCFactory, T1> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseDatabaseCDCFactory, InnerTestCaseTargetDatabaseMetadataFactory> WithTargetMetadata<T1>(this CombinedResult<T1, InnerTestCaseDatabaseCDCFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTestCaseDatabaseCDCFactory, T1, T2, InnerTestCaseTargetDatabaseMetadataFactory> WithTargetMetadata<T1, T2>(this CombinedResult<InnerTestCaseDatabaseCDCFactory, T1, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseDatabaseCDCFactory, T2, InnerTestCaseTargetDatabaseMetadataFactory> WithTargetMetadata<T1, T2>(this CombinedResult<T1, InnerTestCaseDatabaseCDCFactory, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseDatabaseCDCFactory, InnerTestCaseTargetDatabaseMetadataFactory> WithTargetMetadata<T1, T2>(this CombinedResult<T1, T2, InnerTestCaseDatabaseCDCFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTestCaseDatabaseCDCFactory, T1, T2, T3, InnerTestCaseTargetDatabaseMetadataFactory> WithTargetMetadata<T1, T2, T3>(this CombinedResult<InnerTestCaseDatabaseCDCFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseDatabaseCDCFactory, T2, T3, InnerTestCaseTargetDatabaseMetadataFactory> WithTargetMetadata<T1, T2, T3>(this CombinedResult<T1, InnerTestCaseDatabaseCDCFactory, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseDatabaseCDCFactory, T3, InnerTestCaseTargetDatabaseMetadataFactory> WithTargetMetadata<T1, T2, T3>(this CombinedResult<T1, T2, InnerTestCaseDatabaseCDCFactory, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseDatabaseCDCFactory, InnerTestCaseTargetDatabaseMetadataFactory> WithTargetMetadata<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTestCaseDatabaseCDCFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetMetadata(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTestCaseDatabaseCDCFactory, T1, T2, T3, T4, InnerTestCaseTargetDatabaseMetadataFactory> WithTargetMetadata<T1, T2, T3, T4>(this CombinedResult<InnerTestCaseDatabaseCDCFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseDatabaseCDCFactory, T2, T3, T4, InnerTestCaseTargetDatabaseMetadataFactory> WithTargetMetadata<T1, T2, T3, T4>(this CombinedResult<T1, InnerTestCaseDatabaseCDCFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseDatabaseCDCFactory, T3, T4, InnerTestCaseTargetDatabaseMetadataFactory> WithTargetMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTestCaseDatabaseCDCFactory, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseDatabaseCDCFactory, T4, InnerTestCaseTargetDatabaseMetadataFactory> WithTargetMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTestCaseDatabaseCDCFactory, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetMetadata(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTestCaseDatabaseCDCFactory, InnerTestCaseTargetDatabaseMetadataFactory> WithTargetMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTestCaseDatabaseCDCFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetMetadata(combinedResult.T5, subFactoryAction));
}
