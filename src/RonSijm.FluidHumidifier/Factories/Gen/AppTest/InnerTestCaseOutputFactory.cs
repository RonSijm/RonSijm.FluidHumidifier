// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseOutputFactory(Action<Humidifier.AppTest.TestCaseTypes.Output> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.Output>
{

    internal InnerTestCaseOutputFileFactory FileFactory { get; set; }

    protected override Humidifier.AppTest.TestCaseTypes.Output Create()
    {
        var outputResult = CreateOutput();
        factoryAction?.Invoke(outputResult);

        return outputResult;
    }

    private Humidifier.AppTest.TestCaseTypes.Output CreateOutput()
    {
        var outputResult = new Humidifier.AppTest.TestCaseTypes.Output();

        return outputResult;
    }
    public override void CreateChildren(Humidifier.AppTest.TestCaseTypes.Output result)
    {
        base.CreateChildren(result);

        result.File ??= FileFactory?.Build();
    }

} // End Of Class

public static class InnerTestCaseOutputFactoryExtensions
{
    public static CombinedResult<InnerTestCaseOutputFactory, InnerTestCaseOutputFileFactory> WithFile(this InnerTestCaseOutputFactory parentFactory, Action<Humidifier.AppTest.TestCaseTypes.OutputFile> subFactoryAction = null)
    {
        parentFactory.FileFactory = new InnerTestCaseOutputFileFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FileFactory);
    }

    public static CombinedResult<InnerTestCaseOutputFactory, T1, InnerTestCaseOutputFileFactory> WithFile<T1>(this CombinedResult<InnerTestCaseOutputFactory, T1> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.OutputFile> subFactoryAction = null) => new (combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseOutputFactory, InnerTestCaseOutputFileFactory> WithFile<T1>(this CombinedResult<T1, InnerTestCaseOutputFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.OutputFile> subFactoryAction = null) => new (combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTestCaseOutputFactory, T1, T2, InnerTestCaseOutputFileFactory> WithFile<T1, T2>(this CombinedResult<InnerTestCaseOutputFactory, T1, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.OutputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseOutputFactory, T2, InnerTestCaseOutputFileFactory> WithFile<T1, T2>(this CombinedResult<T1, InnerTestCaseOutputFactory, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.OutputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseOutputFactory, InnerTestCaseOutputFileFactory> WithFile<T1, T2>(this CombinedResult<T1, T2, InnerTestCaseOutputFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.OutputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTestCaseOutputFactory, T1, T2, T3, InnerTestCaseOutputFileFactory> WithFile<T1, T2, T3>(this CombinedResult<InnerTestCaseOutputFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.OutputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseOutputFactory, T2, T3, InnerTestCaseOutputFileFactory> WithFile<T1, T2, T3>(this CombinedResult<T1, InnerTestCaseOutputFactory, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.OutputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseOutputFactory, T3, InnerTestCaseOutputFileFactory> WithFile<T1, T2, T3>(this CombinedResult<T1, T2, InnerTestCaseOutputFactory, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.OutputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseOutputFactory, InnerTestCaseOutputFileFactory> WithFile<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTestCaseOutputFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.OutputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTestCaseOutputFactory, T1, T2, T3, T4, InnerTestCaseOutputFileFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<InnerTestCaseOutputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.OutputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseOutputFactory, T2, T3, T4, InnerTestCaseOutputFileFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, InnerTestCaseOutputFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.OutputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseOutputFactory, T3, T4, InnerTestCaseOutputFileFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTestCaseOutputFactory, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.OutputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseOutputFactory, T4, InnerTestCaseOutputFileFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTestCaseOutputFactory, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.OutputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTestCaseOutputFactory, InnerTestCaseOutputFileFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTestCaseOutputFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.OutputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T5, subFactoryAction));
}
