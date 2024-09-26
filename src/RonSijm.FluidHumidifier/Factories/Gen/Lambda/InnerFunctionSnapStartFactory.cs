// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerFunctionSnapStartFactory(Action<Humidifier.Lambda.FunctionTypes.SnapStart> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.FunctionTypes.SnapStart>
{

    protected override Humidifier.Lambda.FunctionTypes.SnapStart Create()
    {
        var snapStartResult = CreateSnapStart();
        factoryAction?.Invoke(snapStartResult);

        return snapStartResult;
    }

    private Humidifier.Lambda.FunctionTypes.SnapStart CreateSnapStart()
    {
        var snapStartResult = new Humidifier.Lambda.FunctionTypes.SnapStart();

        return snapStartResult;
    }

} // End Of Class

public static class InnerFunctionSnapStartFactoryExtensions
{
}
