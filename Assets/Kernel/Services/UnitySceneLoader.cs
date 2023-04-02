using UnityEngine.SceneManagement;

namespace Kernel.Services
{
    public class UnitySceneLoader : ISceneLoader
    {
        public void LoadScene(string sceneName) => SceneManager.LoadScene(sceneName);
    }
}