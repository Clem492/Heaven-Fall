using UnityEngine;
using UnityEngine.UI;

public class menurestart : MonoBehaviour
{
    [SerializeField] Image restart;
    [SerializeField] Image score;
    // fonction pour que le bouton restart fonctionne
    //ce fonction me permet de metre la variable restart menu � faut ce qui empechera mon perso de se d�placer et de deplacer �a cam
    //il permet aussi de re r�g�ner le monde a chaque fois 
    //de d�bloquer la souris 
    // de d�truire les anciens reli�f
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
