// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalytics;

public class InnerApplicationInputParallelismFactory(Action<Humidifier.KinesisAnalytics.ApplicationTypes.InputParallelism> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalytics.ApplicationTypes.InputParallelism>
{

    protected override Humidifier.KinesisAnalytics.ApplicationTypes.InputParallelism Create()
    {
        var inputParallelismResult = CreateInputParallelism();
        factoryAction?.Invoke(inputParallelismResult);

        return inputParallelismResult;
    }

    private Humidifier.KinesisAnalytics.ApplicationTypes.InputParallelism CreateInputParallelism()
    {
        var inputParallelismResult = new Humidifier.KinesisAnalytics.ApplicationTypes.InputParallelism();

        return inputParallelismResult;
    }

} // End Of Class

public static class InnerApplicationInputParallelismFactoryExtensions
{
}
