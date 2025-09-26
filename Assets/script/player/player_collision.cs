using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player_collision : MonoBehaviour
{
    [SerializeField] Image restart;
    [SerializeField] Image score;
    [SerializeField] GameObject cam;
    [SerializeField] GameObject fleche;
    public bool restart_menu;

    //je vais faire en sorte que si mon joueur touche un obstacle portant le tag obstacle alors il est téléporter au spawn
    //et il y a un écran de restart
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            gameObject.transform.position = new Vector3(0, 2, 0);
            gameObject.transform.rotation = Quaternion.identity;
            cam.transform.rotation = Quaternion.identity;
            gameObject.GetComponent<Rigidbody>().linearVelocity = new Vector3(0, 0, 0);
            Cursor.lockState = CursorLockMode.None;
            restart.gameObject.SetActive(true);
            score.gameObject.SetActive(false);
            restart_menu = true;
        }
    }
    private void Start()
    {
        restart_menu = false;
        
    }
    private void Update()
    {
        if (restart_menu == true)
        {
            fleche.gameObject.SetActive(false);
        }
        else
            fleche.gameObject.SetActive(true);
    }
}
