using UnityEngine;

public class player_collision : MonoBehaviour
{
    

    //je vais faire en sorte que si mon joueur touche un obstacle portant le tag obstacle alors il est t�l�porter au spawn
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            gameObject.transform.position = new Vector3(0, 2, 0);
        }
    }
}
