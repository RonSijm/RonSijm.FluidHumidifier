// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseOutputFileFactory(Action<Humidifier.AppTest.TestCaseTypes.OutputFile> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.OutputFile>
{

    protected override Humidifier.AppTest.TestCaseTypes.OutputFile Create()
    {
        var outputFileResult = CreateOutputFile();
        factoryAction?.Invoke(outputFileResult);

        return outputFileResult;
    }

    private Humidifier.AppTest.TestCaseTypes.OutputFile CreateOutputFile()
    {
        var outputFileResult = new Humidifier.AppTest.TestCaseTypes.OutputFile();

        return outputFileResult;
    }

} // End Of Class

public static class InnerTestCaseOutputFileFactoryExtensions
{
}
