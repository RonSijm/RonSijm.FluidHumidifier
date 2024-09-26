// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseInputFactory(Action<Humidifier.AppTest.TestCaseTypes.Input> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.Input>
{

    internal InnerTestCaseInputFileFactory FileFactory { get; set; }

    protected override Humidifier.AppTest.TestCaseTypes.Input Create()
    {
        var inputResult = CreateInput();
        factoryAction?.Invoke(inputResult);

        return inputResult;
    }

    private Humidifier.AppTest.TestCaseTypes.Input CreateInput()
    {
        var inputResult = new Humidifier.AppTest.TestCaseTypes.Input();

        return inputResult;
    }
    public override void CreateChildren(Humidifier.AppTest.TestCaseTypes.Input result)
    {
        base.CreateChildren(result);

        result.File ??= FileFactory?.Build();
    }

} // End Of Class

public static class InnerTestCaseInputFactoryExtensions
{
    public static CombinedResult<InnerTestCaseInputFactory, InnerTestCaseInputFileFactory> WithFile(this InnerTestCaseInputFactory parentFactory, Action<Humidifier.AppTest.TestCaseTypes.InputFile> subFactoryAction = null)
    {
        parentFactory.FileFactory = new InnerTestCaseInputFileFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FileFactory);
    }

    public static CombinedResult<InnerTestCaseInputFactory, T1, InnerTestCaseInputFileFactory> WithFile<T1>(this CombinedResult<InnerTestCaseInputFactory, T1> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.InputFile> subFactoryAction = null) => new (combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseInputFactory, InnerTestCaseInputFileFactory> WithFile<T1>(this CombinedResult<T1, InnerTestCaseInputFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.InputFile> subFactoryAction = null) => new (combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTestCaseInputFactory, T1, T2, InnerTestCaseInputFileFactory> WithFile<T1, T2>(this CombinedResult<InnerTestCaseInputFactory, T1, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.InputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseInputFactory, T2, InnerTestCaseInputFileFactory> WithFile<T1, T2>(this CombinedResult<T1, InnerTestCaseInputFactory, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.InputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseInputFactory, InnerTestCaseInputFileFactory> WithFile<T1, T2>(this CombinedResult<T1, T2, InnerTestCaseInputFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.InputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTestCaseInputFactory, T1, T2, T3, InnerTestCaseInputFileFactory> WithFile<T1, T2, T3>(this CombinedResult<InnerTestCaseInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.InputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseInputFactory, T2, T3, InnerTestCaseInputFileFactory> WithFile<T1, T2, T3>(this CombinedResult<T1, InnerTestCaseInputFactory, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.InputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseInputFactory, T3, InnerTestCaseInputFileFactory> WithFile<T1, T2, T3>(this CombinedResult<T1, T2, InnerTestCaseInputFactory, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.InputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseInputFactory, InnerTestCaseInputFileFactory> WithFile<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTestCaseInputFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.InputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTestCaseInputFactory, T1, T2, T3, T4, InnerTestCaseInputFileFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<InnerTestCaseInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.InputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseInputFactory, T2, T3, T4, InnerTestCaseInputFileFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, InnerTestCaseInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.InputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseInputFactory, T3, T4, InnerTestCaseInputFileFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTestCaseInputFactory, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.InputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseInputFactory, T4, InnerTestCaseInputFileFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTestCaseInputFactory, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.InputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTestCaseInputFactory, InnerTestCaseInputFileFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTestCaseInputFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.InputFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T5, subFactoryAction));
}
