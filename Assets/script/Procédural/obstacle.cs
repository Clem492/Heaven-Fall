using UnityEngine;
using UnityEngine.UIElements;

public class Murs : MonoBehaviour
{   //j'importe mon prefabs pour la génération procédural
    [SerializeField] private GameObject obstacle;
    [SerializeField] GameObject player;
    //je dois creer un plan sur lequel il manque des cubes 
    //je vais faire une méthode pour créer des cubes sur un plan
    //Ensuite je vais faire en sorte qu'il y en as qui spawn sur y
    void plan()
    {
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                for (int k = 0; k < 5000; k++)
                {
                    int position_x;
                    position_x = Random.Range(1, 100);
                    if (position_x == 1)
                    {
                        Vector3 position = new Vector3((-10) + i, (-10) - k, (-10) + j);
                         Instantiate(obstacle, position, Quaternion.identity);
                         obstacle.transform.localScale = new Vector3(Random.Range(0.1f, 1), Random.Range(0.1f, 1), Random.Range(0.1f, 1));
                    }
                  
                }

            }
        }
    }
    //j'ai fait un système qui me permettait d'avoir plus ou moins de bube 
    //maintenant je vais faire en sorte que c'est en foncion des y du joueur qu'il y a de plus en plus d'obstacle
    void obstacle_y()
    {
       
    }


    private void Start()
    {
        plan();
    }
    private void Update()
    {

    }
}