using UnityEngine;
using UnityEngine.UIElements;

public class Murs : MonoBehaviour
{   //j'importe mon prefabs pour la génération procédural
    [SerializeField] private GameObject obstacle;
    [SerializeField] GameObject origin;
    [SerializeField] GameObject fin;
    [SerializeField] GameObject repère1;
    [SerializeField] GameObject repère2;

    //je vis faire des variable pour la hauteur en y et pour modifier la profondeur en x et z
    int hauteur = 5000;
    int largeur = 20;
    int longueur = 20;

    //je vais creer une variable pour la probabiliter qu'un cube apparait
    float spawner_cube;
    int position_y;
   
    float distance_debut_r1;
    float distance_r1_r2;
    float distance_r2_fin;
   

    //je dois creer un plan sur lequel il manque des cubes 
    //je vais faire une méthode pour créer des cubes sur un plan
    //Ensuite je vais faire en sorte qu'il y en as qui spawn sur y
    void plan()
    {
        for (int i = 0; i < longueur; i++)
        {
            for (int j = 0; j < largeur; j++)
            {
                for (int k = 0; k < hauteur; k++)
                {
                    spawner_y( i, j, k);
                  
                }

            }
        }
    }
   
   //je creer une mtehode qui va me permettre d'avoir uen plus grande densiter en fonction du y de l'origine
   //plus la distance y entre l'origine et mes couches sont élever et plus il doit y avoir de cube
   void spawner_y(int i, int j, int k)
    {    
       if (distance_debut_r1 == 1666)
       {
            int position_x;
            position_x = Random.Range(1, 1500);
            if (position_x == 1)
            {

                Vector3 position = new Vector3((-10) + i, (-10) - k, (-10) + j);
                Instantiate(obstacle, position, Quaternion.identity);
                obstacle.transform.localScale = new Vector3(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));

            }
       }
       if (distance_r1_r2 == 1674)
       {
            int position_x;
            position_x = Random.Range(1, 1000);
            if (position_x == 1)
            {

                Vector3 position = new Vector3((-10) + i, (-1666) - k, (-10) + j);
                Instantiate(obstacle, position, Quaternion.identity);
                obstacle.transform.localScale = new Vector3(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));

            }
        }
       if (distance_r2_fin == 1660)
        {
            int position_x;
            position_x = Random.Range(1, 500);
            if (position_x == 1)
            {

                Vector3 position = new Vector3((-10) + i, (-3340) - k, (-10) + j);
                Instantiate(obstacle, position, Quaternion.identity);
                obstacle.transform.localScale = new Vector3(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));

            }
        }
 
        
    }
  

    private void Start()
    {


    
        distance_debut_r1 = Vector3.Distance(origin.transform.position, repère1.transform.position);
        distance_r1_r2 = Vector3.Distance(repère1.transform.position, repère2.transform.position);
        distance_r2_fin = Vector3.Distance(repère2.transform.position, fin.transform.position);

    
        Debug.Log("" + distance_debut_r1);
        Debug.Log("" + distance_r1_r2);
        Debug.Log("" + distance_r2_fin);

        plan();
        
    }
    
  

}