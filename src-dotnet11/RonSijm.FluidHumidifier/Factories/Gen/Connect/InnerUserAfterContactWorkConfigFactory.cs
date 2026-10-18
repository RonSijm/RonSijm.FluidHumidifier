// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerUserAfterContactWorkConfigFactory(Action<Humidifier.Connect.UserTypes.AfterContactWorkConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.UserTypes.AfterContactWorkConfig>
{

    protected override Humidifier.Connect.UserTypes.AfterContactWorkConfig Create()
    {
        var afterContactWorkConfigResult = CreateAfterContactWorkConfig();
        factoryAction?.Invoke(afterContactWorkConfigResult);

        return afterContactWorkConfigResult;
    }

    private Humidifier.Connect.UserTypes.AfterContactWorkConfig CreateAfterContactWorkConfig()
    {
        var afterContactWorkConfigResult = new Humidifier.Connect.UserTypes.AfterContactWorkConfig();

        return afterContactWorkConfigResult;
    }

} // End Of Class

public static class InnerUserAfterContactWorkConfigFactoryExtensions
{
}
