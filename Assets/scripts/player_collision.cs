
using UnityEngine;

public class player_collision : MonoBehaviour {
    // Start is called before the first frame update
    public player_movement movement;
    // Update is called once per frame
    private bool isdead=false;
    private CharacterController controller;
    private void OnCollisionEnter(Collision collisioninfo) {

        if(collisioninfo.collider.tag == "obstacle") {
            movement.enabled = false;
            FindObjectOfType<game_manager>().endgame();
        }
    }
    private void OnControllerColliderHit(ControllerColliderHit h)
    {
        if (h.point.z > transform.position.z + controller.radius)
        {
            movement.enabled = false;
            Death();
        }
    }
    private void Death()
{
    isdead=true;
    FindObjectOfType<score>().onDeath();
}
void update()
{
if (isdead)
    return;
}
}
