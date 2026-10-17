namespace AppleStore.AWS.NimbusFactory.CLI.Features.AllAccounts.StacksForAllAccounts.GithubUserStack;

public class GithubUserStackConfig : IEnumerable<List<string>>
{
    public List<string> DeployPermissions { get; set; } = [];

    public void Add(List<string> permissions)
    {
        DeployPermissions.AddRange(permissions);
    }

    /// <summary>
    ///  Using 'Least Privilege' means that the permissions are restricted to only what is needed.
    /// This might seem like a good idea in principle, but fundamentally a false fallacy.
    /// The Github user is able to update its on permissions, so it can also always escalate its own permissions.
    /// So a malicious actor could just append extra permissions.
    /// </summary>
    public bool UseLeastPrivilege { get; set; }

    #region Random Stuff IEnumerable wants before I can have a Collection Initizer
    public IEnumerator<List<string>> GetEnumerator() => throw new NotImplementedException();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    #endregion
}