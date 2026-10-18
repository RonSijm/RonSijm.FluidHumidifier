// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Translate;

public class InnerParallelDataParallelDataConfigFactory(Action<Humidifier.Translate.ParallelDataTypes.ParallelDataConfig> factoryAction = null) : SubResourceFactory<Humidifier.Translate.ParallelDataTypes.ParallelDataConfig>
{

    protected override Humidifier.Translate.ParallelDataTypes.ParallelDataConfig Create()
    {
        var parallelDataConfigResult = CreateParallelDataConfig();
        factoryAction?.Invoke(parallelDataConfigResult);

        return parallelDataConfigResult;
    }

    private Humidifier.Translate.ParallelDataTypes.ParallelDataConfig CreateParallelDataConfig()
    {
        var parallelDataConfigResult = new Humidifier.Translate.ParallelDataTypes.ParallelDataConfig();

        return parallelDataConfigResult;
    }

} // End Of Class

public static class InnerParallelDataParallelDataConfigFactoryExtensions
{
}
