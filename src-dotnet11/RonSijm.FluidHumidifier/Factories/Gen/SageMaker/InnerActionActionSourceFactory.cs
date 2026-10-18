// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerActionActionSourceFactory(Action<Humidifier.SageMaker.ActionTypes.ActionSource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ActionTypes.ActionSource>
{

    protected override Humidifier.SageMaker.ActionTypes.ActionSource Create()
    {
        var actionSourceResult = CreateActionSource();
        factoryAction?.Invoke(actionSourceResult);

        return actionSourceResult;
    }

    private Humidifier.SageMaker.ActionTypes.ActionSource CreateActionSource()
    {
        var actionSourceResult = new Humidifier.SageMaker.ActionTypes.ActionSource();

        return actionSourceResult;
    }

} // End Of Class

public static class InnerActionActionSourceFactoryExtensions
{
}
