using BinDI;
using UniRx;
using UnityEngine;
using VContainer;
using UnityEngine.SceneManagement;

public sealed class BinDiStarter : MonoBehaviour
{
    void Start()
    {
        var builder = new ContainerBuilder();
        var binDiOptions = new BinDiOptions()
        {
            CollectAssemblyLogEnabled = true,
            DomainRegistrationLogEnabled = true,
            PubSubConnectionLogEnabled = true,
        };
        var assemblyWhiteListFilter = new AssemblyWhiteListFilter("Assembly-CSharp");
        builder.RegisterBinDi(binDiOptions, assemblyWhiteListFilter);
        builder.RegisterBuildCallback(resolver =>
        {
            foreach (var rootGameObject in SceneManager.GetActiveScene().GetRootGameObjects())
            {
                resolver.BuildGameObjectScope(rootGameObject);
            }
        });
        builder.Build().AddTo(this);
    }
}
