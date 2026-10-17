// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class ModelInvocationJobFactory(string resourceName = null, Action<Humidifier.Bedrock.ModelInvocationJob> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.ModelInvocationJob>(resourceName)
{

    protected override Humidifier.Bedrock.ModelInvocationJob Create()
    {
        var modelInvocationJobResult = CreateModelInvocationJob();
        factoryAction?.Invoke(modelInvocationJobResult);

        return modelInvocationJobResult;
    }

    private Humidifier.Bedrock.ModelInvocationJob CreateModelInvocationJob()
    {
        var modelInvocationJobResult = new Humidifier.Bedrock.ModelInvocationJob
        {
            GivenName = InputResourceName,
        };

        return modelInvocationJobResult;
    }

} // End Of Class

public static class ModelInvocationJobFactoryExtensions
{
}
