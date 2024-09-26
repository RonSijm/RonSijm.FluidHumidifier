// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseInputFileFactory(Action<Humidifier.AppTest.TestCaseTypes.InputFile> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.InputFile>
{

    internal InnerTestCaseFileMetadataFactory FileMetadataFactory { get; set; }

    protected override Humidifier.AppTest.TestCaseTypes.InputFile Create()
    {
        var inputFileResult = CreateInputFile();
        factoryAction?.Invoke(inputFileResult);

        return inputFileResult;
    }

    private Humidifier.AppTest.TestCaseTypes.InputFile CreateInputFile()
    {
        var inputFileResult = new Humidifier.AppTest.TestCaseTypes.InputFile();

        return inputFileResult;
    }
    public override void CreateChildren(Humidifier.AppTest.TestCaseTypes.InputFile result)
    {
        base.CreateChildren(result);

        result.FileMetadata ??= FileMetadataFactory?.Build();
    }

} // End Of Class

public static class InnerTestCaseInputFileFactoryExtensions
{
    public static CombinedResult<InnerTestCaseInputFileFactory, InnerTestCaseFileMetadataFactory> WithFileMetadata(this InnerTestCaseInputFileFactory parentFactory, Action<Humidifier.AppTest.TestCaseTypes.FileMetadata> subFactoryAction = null)
    {
        parentFactory.FileMetadataFactory = new InnerTestCaseFileMetadataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FileMetadataFactory);
    }

    public static CombinedResult<InnerTestCaseInputFileFactory, T1, InnerTestCaseFileMetadataFactory> WithFileMetadata<T1>(this CombinedResult<InnerTestCaseInputFileFactory, T1> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.FileMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithFileMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseInputFileFactory, InnerTestCaseFileMetadataFactory> WithFileMetadata<T1>(this CombinedResult<T1, InnerTestCaseInputFileFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.FileMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithFileMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTestCaseInputFileFactory, T1, T2, InnerTestCaseFileMetadataFactory> WithFileMetadata<T1, T2>(this CombinedResult<InnerTestCaseInputFileFactory, T1, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.FileMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseInputFileFactory, T2, InnerTestCaseFileMetadataFactory> WithFileMetadata<T1, T2>(this CombinedResult<T1, InnerTestCaseInputFileFactory, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.FileMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseInputFileFactory, InnerTestCaseFileMetadataFactory> WithFileMetadata<T1, T2>(this CombinedResult<T1, T2, InnerTestCaseInputFileFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.FileMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTestCaseInputFileFactory, T1, T2, T3, InnerTestCaseFileMetadataFactory> WithFileMetadata<T1, T2, T3>(this CombinedResult<InnerTestCaseInputFileFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.FileMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseInputFileFactory, T2, T3, InnerTestCaseFileMetadataFactory> WithFileMetadata<T1, T2, T3>(this CombinedResult<T1, InnerTestCaseInputFileFactory, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.FileMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseInputFileFactory, T3, InnerTestCaseFileMetadataFactory> WithFileMetadata<T1, T2, T3>(this CombinedResult<T1, T2, InnerTestCaseInputFileFactory, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.FileMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseInputFileFactory, InnerTestCaseFileMetadataFactory> WithFileMetadata<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTestCaseInputFileFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.FileMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileMetadata(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTestCaseInputFileFactory, T1, T2, T3, T4, InnerTestCaseFileMetadataFactory> WithFileMetadata<T1, T2, T3, T4>(this CombinedResult<InnerTestCaseInputFileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.FileMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseInputFileFactory, T2, T3, T4, InnerTestCaseFileMetadataFactory> WithFileMetadata<T1, T2, T3, T4>(this CombinedResult<T1, InnerTestCaseInputFileFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.FileMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseInputFileFactory, T3, T4, InnerTestCaseFileMetadataFactory> WithFileMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTestCaseInputFileFactory, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.FileMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseInputFileFactory, T4, InnerTestCaseFileMetadataFactory> WithFileMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTestCaseInputFileFactory, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.FileMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileMetadata(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTestCaseInputFileFactory, InnerTestCaseFileMetadataFactory> WithFileMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTestCaseInputFileFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.FileMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileMetadata(combinedResult.T5, subFactoryAction));
}
