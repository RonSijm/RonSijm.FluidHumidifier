// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class InnerServiceSourceCodeVersionFactory(Action<Humidifier.AppRunner.ServiceTypes.SourceCodeVersion> factoryAction = null) : SubResourceFactory<Humidifier.AppRunner.ServiceTypes.SourceCodeVersion>
{

    protected override Humidifier.AppRunner.ServiceTypes.SourceCodeVersion Create()
    {
        var sourceCodeVersionResult = CreateSourceCodeVersion();
        factoryAction?.Invoke(sourceCodeVersionResult);

        return sourceCodeVersionResult;
    }

    private Humidifier.AppRunner.ServiceTypes.SourceCodeVersion CreateSourceCodeVersion()
    {
        var sourceCodeVersionResult = new Humidifier.AppRunner.ServiceTypes.SourceCodeVersion();

        return sourceCodeVersionResult;
    }

} // End Of Class

public static class InnerServiceSourceCodeVersionFactoryExtensions
{
}
