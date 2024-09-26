// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NimbleStudio;

public class InnerStudioComponentScriptParameterKeyValueFactory(Action<Humidifier.NimbleStudio.StudioComponentTypes.ScriptParameterKeyValue> factoryAction = null) : SubResourceFactory<Humidifier.NimbleStudio.StudioComponentTypes.ScriptParameterKeyValue>
{

    protected override Humidifier.NimbleStudio.StudioComponentTypes.ScriptParameterKeyValue Create()
    {
        var scriptParameterKeyValueResult = CreateScriptParameterKeyValue();
        factoryAction?.Invoke(scriptParameterKeyValueResult);

        return scriptParameterKeyValueResult;
    }

    private Humidifier.NimbleStudio.StudioComponentTypes.ScriptParameterKeyValue CreateScriptParameterKeyValue()
    {
        var scriptParameterKeyValueResult = new Humidifier.NimbleStudio.StudioComponentTypes.ScriptParameterKeyValue();

        return scriptParameterKeyValueResult;
    }

} // End Of Class

public static class InnerStudioComponentScriptParameterKeyValueFactoryExtensions
{
}
