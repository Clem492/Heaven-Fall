using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    //je vais ajouter une variable pour compter le score du joueur 
    float score_joueur;
 
    [SerializeField] GameObject player;
    [SerializeField] TMPro.TextMeshProUGUI score;
    //je dois maintenant faire des variables pour le syst�me de record
    float record_joueur;
    float score_sauvegarder;
    [SerializeField] TMPro.TextMeshProUGUI record;
    //je dois creer une m�thode pour compter les points du joueur
    void Systeme_point()
    {
        if (player.transform.position.y >0)
            score_joueur = 0;
        else
            score_joueur = (player.transform.position.y) * -1;
        score.text = "score : "+score_joueur;
        
    }
    //j'ai utiliser une m�thode pour d�tecter les collision et adapter en fonction le score et le record du joueur 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle" && score_joueur > record_joueur)
        {
            record_joueur = score_joueur;
            record.text = "record :" + record_joueur;


        }
    }
    void Start()
    {
        record_joueur = 0;
        
    }


    void Update()
    {
        Systeme_point();
       
       
    }
}
