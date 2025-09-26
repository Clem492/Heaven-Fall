using UnityEngine;
using UnityEngine.UI;

public class menurestart : MonoBehaviour
{
    [SerializeField] Image restart;
    [SerializeField] Image score;
    // fonction pour que le bouton restart fonctionne
    public void restart_to_game()
    {
        GameObject player = GameObject.Find("player");
        player.GetComponent<player_collision>().restart_menu = false;
        GameObject platforme = GameObject.Find("platform");
        platforme.GetComponent<Murs>().plan();
        restart.gameObject.SetActive(false);
        score.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    }



}
