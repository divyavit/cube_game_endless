
using UnityEngine;
using UnityEngine.SceneManagement;
public class game_manager : MonoBehaviour
{
    bool gameended = false;
    public GameObject completelevelui;
    public float restartDelay = 1f;
    public void completelevel() {
        Debug.Log("LEVEL 1 WON :D");
        completelevelui.SetActive(true);
    } 
  
    public void endgame() {
        if(gameended == false) {
            gameended = true;
            Debug.Log("END GAME");
            Invoke("Restart", restartDelay);
        }
    } 
    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
