// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipeFilterCriteriaFactory(Action<Humidifier.Pipes.PipeTypes.FilterCriteria> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.FilterCriteria>
{

    protected override Humidifier.Pipes.PipeTypes.FilterCriteria Create()
    {
        var filterCriteriaResult = CreateFilterCriteria();
        factoryAction?.Invoke(filterCriteriaResult);

        return filterCriteriaResult;
    }

    private Humidifier.Pipes.PipeTypes.FilterCriteria CreateFilterCriteria()
    {
        var filterCriteriaResult = new Humidifier.Pipes.PipeTypes.FilterCriteria();

        return filterCriteriaResult;
    }

} // End Of Class

public static class InnerPipeFilterCriteriaFactoryExtensions
{
}
