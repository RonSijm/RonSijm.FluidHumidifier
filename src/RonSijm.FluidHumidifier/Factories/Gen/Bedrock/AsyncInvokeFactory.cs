// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class AsyncInvokeFactory(string resourceName = null, Action<Humidifier.Bedrock.AsyncInvoke> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.AsyncInvoke>(resourceName)
{

    protected override Humidifier.Bedrock.AsyncInvoke Create()
    {
        var asyncInvokeResult = CreateAsyncInvoke();
        factoryAction?.Invoke(asyncInvokeResult);

        return asyncInvokeResult;
    }

    private Humidifier.Bedrock.AsyncInvoke CreateAsyncInvoke()
    {
        var asyncInvokeResult = new Humidifier.Bedrock.AsyncInvoke
        {
            GivenName = InputResourceName,
        };

        return asyncInvokeResult;
    }

} // End Of Class

public static class AsyncInvokeFactoryExtensions
{
}
