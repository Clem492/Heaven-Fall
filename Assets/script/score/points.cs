using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    //je vais ajouter une variable pour compter le score du joueur 
    float score_joueur;
    float score_joueur_temporaire;
    [SerializeField] GameObject player;
    [SerializeField] TMPro.TextMeshProUGUI score;
    //je dois maintenant faire des variables pour le système de record
    float record_joueur;
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

    private void OnCollisionEnter(Collision collision)
    {
        score_joueur_temporaire = score_joueur;
        Debug.Log("il y a bien une colision");

    }
    //je dois maintenant faire une méthode pour mon système de record
    void Record_joueur()
    {
        if (score_joueur_temporaire > record_joueur)
        {
            record.text = "record : " + record_joueur;
        }
    }
    void Start()
    {
        score_joueur = 0;
        record_joueur = 0;
    }


    void Update()
    {
        Systeme_point();
        Record_joueur();
    }
}
