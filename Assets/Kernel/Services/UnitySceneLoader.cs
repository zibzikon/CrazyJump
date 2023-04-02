using UnityEngine.SceneManagement;

namespace Foundation
{
    public class UnitySceneLoader : ISceneLoader
    {
        public void LoadScene(string sceneName) => SceneManager.LoadScene(sceneName);
    }
}