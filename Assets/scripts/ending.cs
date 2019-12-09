
using UnityEngine;

public class ending : MonoBehaviour
{
    public game_manager gamemanager;


    // Start is called before the first frame update
    void OnTriggerEnter() {
         { gamemanager.completelevel(); }
    }
}

