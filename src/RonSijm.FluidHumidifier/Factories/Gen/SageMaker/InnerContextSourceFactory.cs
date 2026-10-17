// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerContextSourceFactory(Action<Humidifier.SageMaker.ContextTypes.Source> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ContextTypes.Source>
{

    protected override Humidifier.SageMaker.ContextTypes.Source Create()
    {
        var sourceResult = CreateSource();
        factoryAction?.Invoke(sourceResult);

        return sourceResult;
    }

    private Humidifier.SageMaker.ContextTypes.Source CreateSource()
    {
        var sourceResult = new Humidifier.SageMaker.ContextTypes.Source();

        return sourceResult;
    }

} // End Of Class

public static class InnerContextSourceFactoryExtensions
{
}
