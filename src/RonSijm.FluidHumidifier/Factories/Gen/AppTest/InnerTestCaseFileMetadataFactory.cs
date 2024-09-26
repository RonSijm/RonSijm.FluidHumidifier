// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseFileMetadataFactory(Action<Humidifier.AppTest.TestCaseTypes.FileMetadata> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.FileMetadata>
{

    internal InnerTestCaseDatabaseCDCFactory DatabaseCDCFactory { get; set; }

    protected override Humidifier.AppTest.TestCaseTypes.FileMetadata Create()
    {
        var fileMetadataResult = CreateFileMetadata();
        factoryAction?.Invoke(fileMetadataResult);

        return fileMetadataResult;
    }

    private Humidifier.AppTest.TestCaseTypes.FileMetadata CreateFileMetadata()
    {
        var fileMetadataResult = new Humidifier.AppTest.TestCaseTypes.FileMetadata();

        return fileMetadataResult;
    }
    public override void CreateChildren(Humidifier.AppTest.TestCaseTypes.FileMetadata result)
    {
        base.CreateChildren(result);

        result.DatabaseCDC ??= DatabaseCDCFactory?.Build();
    }

} // End Of Class

public static class InnerTestCaseFileMetadataFactoryExtensions
{
    public static CombinedResult<InnerTestCaseFileMetadataFactory, InnerTestCaseDatabaseCDCFactory> WithDatabaseCDC(this InnerTestCaseFileMetadataFactory parentFactory, Action<Humidifier.AppTest.TestCaseTypes.DatabaseCDC> subFactoryAction = null)
    {
        parentFactory.DatabaseCDCFactory = new InnerTestCaseDatabaseCDCFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DatabaseCDCFactory);
    }

    public static CombinedResult<InnerTestCaseFileMetadataFactory, T1, InnerTestCaseDatabaseCDCFactory> WithDatabaseCDC<T1>(this CombinedResult<InnerTestCaseFileMetadataFactory, T1> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.DatabaseCDC> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatabaseCDC(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseFileMetadataFactory, InnerTestCaseDatabaseCDCFactory> WithDatabaseCDC<T1>(this CombinedResult<T1, InnerTestCaseFileMetadataFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.DatabaseCDC> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatabaseCDC(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTestCaseFileMetadataFactory, T1, T2, InnerTestCaseDatabaseCDCFactory> WithDatabaseCDC<T1, T2>(this CombinedResult<InnerTestCaseFileMetadataFactory, T1, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.DatabaseCDC> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatabaseCDC(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseFileMetadataFactory, T2, InnerTestCaseDatabaseCDCFactory> WithDatabaseCDC<T1, T2>(this CombinedResult<T1, InnerTestCaseFileMetadataFactory, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.DatabaseCDC> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatabaseCDC(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseFileMetadataFactory, InnerTestCaseDatabaseCDCFactory> WithDatabaseCDC<T1, T2>(this CombinedResult<T1, T2, InnerTestCaseFileMetadataFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.DatabaseCDC> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatabaseCDC(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTestCaseFileMetadataFactory, T1, T2, T3, InnerTestCaseDatabaseCDCFactory> WithDatabaseCDC<T1, T2, T3>(this CombinedResult<InnerTestCaseFileMetadataFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.DatabaseCDC> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseCDC(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseFileMetadataFactory, T2, T3, InnerTestCaseDatabaseCDCFactory> WithDatabaseCDC<T1, T2, T3>(this CombinedResult<T1, InnerTestCaseFileMetadataFactory, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.DatabaseCDC> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseCDC(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseFileMetadataFactory, T3, InnerTestCaseDatabaseCDCFactory> WithDatabaseCDC<T1, T2, T3>(this CombinedResult<T1, T2, InnerTestCaseFileMetadataFactory, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.DatabaseCDC> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseCDC(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseFileMetadataFactory, InnerTestCaseDatabaseCDCFactory> WithDatabaseCDC<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTestCaseFileMetadataFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.DatabaseCDC> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseCDC(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTestCaseFileMetadataFactory, T1, T2, T3, T4, InnerTestCaseDatabaseCDCFactory> WithDatabaseCDC<T1, T2, T3, T4>(this CombinedResult<InnerTestCaseFileMetadataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.DatabaseCDC> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseCDC(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseFileMetadataFactory, T2, T3, T4, InnerTestCaseDatabaseCDCFactory> WithDatabaseCDC<T1, T2, T3, T4>(this CombinedResult<T1, InnerTestCaseFileMetadataFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.DatabaseCDC> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseCDC(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseFileMetadataFactory, T3, T4, InnerTestCaseDatabaseCDCFactory> WithDatabaseCDC<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTestCaseFileMetadataFactory, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.DatabaseCDC> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseCDC(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseFileMetadataFactory, T4, InnerTestCaseDatabaseCDCFactory> WithDatabaseCDC<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTestCaseFileMetadataFactory, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.DatabaseCDC> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseCDC(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTestCaseFileMetadataFactory, InnerTestCaseDatabaseCDCFactory> WithDatabaseCDC<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTestCaseFileMetadataFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.DatabaseCDC> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseCDC(combinedResult.T5, subFactoryAction));
}
