// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotReplicationFactory(Action<Humidifier.Lex.BotTypes.Replication> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.Replication>
{

    protected override Humidifier.Lex.BotTypes.Replication Create()
    {
        var replicationResult = CreateReplication();
        factoryAction?.Invoke(replicationResult);

        return replicationResult;
    }

    private Humidifier.Lex.BotTypes.Replication CreateReplication()
    {
        var replicationResult = new Humidifier.Lex.BotTypes.Replication();

        return replicationResult;
    }

} // End Of Class

public static class InnerBotReplicationFactoryExtensions
{
}
