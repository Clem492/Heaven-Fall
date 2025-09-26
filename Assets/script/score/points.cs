using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    //je doit créer des variable pour pouvoir synchroniser mes valeurs au restart
    [SerializeField] TMPro.TextMeshProUGUI record_restart;
    [SerializeField] TMPro.TextMeshProUGUI score_restart;
    float score_temporaire;

    //je vais ajouter une variable pour compter le score du joueur 
    float score_joueur;
 
    [SerializeField] GameObject player;
    [SerializeField] TMPro.TextMeshProUGUI score;
    //je dois maintenant faire des variables pour le système de record
    float record_joueur;
    float score_sauvegarder;
    [SerializeField] TMPro.TextMeshProUGUI record;
    //je dois creer une méthode pour compter les points du joueur
    void Systeme_point()
    {
        if (player.transform.position.y >0)
            score_joueur = 0;
        else
            score_joueur = (player.transform.position.y) * -1;
        score.text = "score : "+score_joueur;
       
    }
    //j'ai utiliser une méthode pour détecter les collision et adapter en fonction le score et le record du joueur 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle" && score_joueur > record_joueur)
        {
            record_joueur = score_joueur;
            record.text = "record :" + record_joueur;


        }
        if (collision.gameObject.tag == "obstacle")
        {
            score_temporaire = score_joueur;
        }
    }

    //je vais faire une fonction pour que les valeur de mon score et record soit synchroniser avec celle du menu restart
    void score_restart_menu()
    {
        if (gameObject.GetComponent<player_collision>().restart_menu == true)
        {
            record_restart.text = "recod : " + record_joueur;
            score_restart.text = "score : " + score_temporaire;
            
        }
    }

    void Start()
    {
        record_joueur = 0;
        
    }


    void Update()
    {
        Systeme_point();
        score_restart_menu();
       
    }
}
