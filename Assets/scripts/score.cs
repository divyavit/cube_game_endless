
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Transform player;
    public Text scoretext;
    private bool isdead=false;
    // Update is called once per frame
    void Update()
    {
        if (isdead)
            return;
        scoretext.text = player.position.z.ToString("0");
    }
    public void onDeath()
    {
        isdead = true;
    }

}
