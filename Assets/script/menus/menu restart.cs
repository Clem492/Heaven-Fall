using UnityEngine;
using UnityEngine.UI;

public class menurestart : MonoBehaviour
{
    [SerializeField] Image restart;
    [SerializeField] Image score;
    // fonction pour que le bouton restart fonctionne
    //ce fonction me permet de metre la variable restart menu à faut ce qui empechera mon perso de se déplacer et de deplacer ça cam
    //il permet aussi de re régéner le monde a chaque fois 
    //de débloquer la souris 
    // de détruire les anciens relièf
    public void restart_to_game()
    {
        GameObject player = GameObject.Find("player");
        player.GetComponent<player_collision>().restart_menu = false;
        GameObject platforme = GameObject.Find("platform");
        platforme.GetComponent<Murs>().plan();
        restart.gameObject.SetActive(false);
        score.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Destroy(platforme.GetComponent<Murs>().parent_obstacle);
        
    }



}
