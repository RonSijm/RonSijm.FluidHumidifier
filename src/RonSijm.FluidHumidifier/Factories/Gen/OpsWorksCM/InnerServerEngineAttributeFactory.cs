// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorksCM;

public class InnerServerEngineAttributeFactory(Action<Humidifier.OpsWorksCM.ServerTypes.EngineAttribute> factoryAction = null) : SubResourceFactory<Humidifier.OpsWorksCM.ServerTypes.EngineAttribute>
{

    protected override Humidifier.OpsWorksCM.ServerTypes.EngineAttribute Create()
    {
        var engineAttributeResult = CreateEngineAttribute();
        factoryAction?.Invoke(engineAttributeResult);

        return engineAttributeResult;
    }

    private Humidifier.OpsWorksCM.ServerTypes.EngineAttribute CreateEngineAttribute()
    {
        var engineAttributeResult = new Humidifier.OpsWorksCM.ServerTypes.EngineAttribute();

        return engineAttributeResult;
    }

} // End Of Class

public static class InnerServerEngineAttributeFactoryExtensions
{
}
