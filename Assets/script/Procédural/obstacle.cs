using UnityEngine;
using UnityEngine.UIElements;

public class Murs : MonoBehaviour
{   //j'importe mon prefabs pour la g�n�ration proc�dural
    [SerializeField] private GameObject obstacle;
    GameObject obstacle_instant;
    [SerializeField] GameObject parent_obstacle_prefab;
    public GameObject parent_obstacle;
    [SerializeField] GameObject origin;
    [SerializeField] GameObject fin;
    [SerializeField] GameObject rep�re1;
    [SerializeField] GameObject rep�re2;

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

    //je vais creer des variable pour que les cube ont le choix entre 3 couleur le bleu, jaune, rouge
    [SerializeField] Material Bleu;
    [SerializeField] Material jaune;
    [SerializeField] Material rouge;
    [SerializeField] Material vert;
    int random_colors;
    //je dois creer un plan sur lequel il manque des cubes 
    //je vais faire une m�thode pour cr�er des cubes sur un plan
    //Ensuite je vais faire en sorte qu'il y en as qui spawn sur y
   public void plan()
    {   
       parent_obstacle = Instantiate(parent_obstacle_prefab);
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
   //plus la distance y entre l'origine et mes couches sont �lever et plus il doit y avoir de cube
   void spawner_y(int i, int j, int k)
    {
        random_colors = Random.Range(0, 4);
        if (distance_debut_r1 == 1666)
       {
            if (random_colors == 0)
            {
                int position_x;
                position_x = Random.Range(1, 2000);
                if (position_x == 1)
                {

                    Vector3 position = new Vector3((-10) + i, (-10) - k, (-10) + j);
                    obstacle_instant = Instantiate(obstacle, position, Quaternion.identity);
                    obstacle_instant.transform.localScale = new Vector3(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
                    obstacle_instant.GetComponent<Renderer>().material = Bleu;
                    obstacle_instant.transform.parent = parent_obstacle.transform;
                }
            }
            if (random_colors == 1)
            {
                int position_x;
                position_x = Random.Range(1, 2000);
                if (position_x == 1)
                {

                    Vector3 position = new Vector3((-10) + i, (-10) - k, (-10) + j);
                    obstacle_instant = Instantiate(obstacle, position, Quaternion.identity);
                    obstacle_instant.transform.localScale = new Vector3(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
                    obstacle_instant.GetComponent<Renderer>().material = jaune;
                    obstacle_instant.transform.parent = parent_obstacle.transform;
                }

            }
            if (random_colors == 2)
            {
                int position_x;
                position_x = Random.Range(1, 2000);
                if (position_x == 1)
                {

                    Vector3 position = new Vector3((-10) + i, (-10) - k, (-10) + j);
                    obstacle_instant = Instantiate(obstacle, position, Quaternion.identity);
                    obstacle_instant.transform.localScale = new Vector3(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
                    obstacle_instant.GetComponent<Renderer>().material = rouge;
                    obstacle_instant.transform.parent = parent_obstacle.transform;
                }
            }
            if (random_colors == 3)
            {
                int position_x;
                position_x = Random.Range(1, 2000);
                if (position_x == 1)
                {

                    Vector3 position = new Vector3((-10) + i, (-10) - k, (-10) + j);
                    obstacle_instant = Instantiate(obstacle, position, Quaternion.identity);
                    obstacle_instant.transform.localScale = new Vector3(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
                    obstacle_instant.GetComponent<Renderer>().material = vert;
                    obstacle_instant.transform.parent = parent_obstacle.transform;

                }
            }
        }
        if (distance_r1_r2 == 1674)
        {
            if (random_colors == 0)
            {
                int position_x;
                position_x = Random.Range(1, 2000);
                if (position_x == 1)
                {

                    Vector3 position = new Vector3((-1666) + i, (-10) - k, (-10) + j);
                    obstacle_instant = Instantiate(obstacle, position, Quaternion.identity);
                    obstacle_instant.transform.localScale = new Vector3(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
                    obstacle_instant.GetComponent<Renderer>().material = Bleu;
                    obstacle_instant.transform.parent = parent_obstacle.transform;
                }
            }
            if (random_colors == 1)
            {
                int position_x;
                position_x = Random.Range(1, 2000);
                if (position_x == 1)
                {

                    Vector3 position = new Vector3((-10) + i, (-1666) - k, (-10) + j);
                    obstacle_instant = Instantiate(obstacle, position, Quaternion.identity);
                    obstacle_instant.transform.localScale = new Vector3(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
                    obstacle_instant.GetComponent<Renderer>().material = jaune;
                    obstacle_instant.transform.parent = parent_obstacle.transform;
                }

            }
            if (random_colors == 2)
            {
                int position_x;
                position_x = Random.Range(1, 2000);
                if (position_x == 1)
                {

                    Vector3 position = new Vector3((-10) + i, (-1666) - k, (-10) + j);
                    obstacle_instant = Instantiate(obstacle, position, Quaternion.identity);
                    obstacle_instant.transform.localScale = new Vector3(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
                    obstacle_instant.GetComponent<Renderer>().material = rouge;
                    obstacle_instant.transform.parent = parent_obstacle.transform;
                }
            }
            if (random_colors == 3)
            {
                int position_x;
                position_x = Random.Range(1, 2000);
                if (position_x == 1)
                {

                    Vector3 position = new Vector3((-10) + i, (-1666) - k, (-10) + j);
                    obstacle_instant = Instantiate(obstacle, position, Quaternion.identity);
                    obstacle_instant.transform.localScale = new Vector3(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
                    obstacle_instant.GetComponent<Renderer>().material = vert;
                    obstacle_instant.transform.parent = parent_obstacle.transform;

                }
            }
            if (distance_r2_fin == 1660)
            {
                if (random_colors == 0)
                {
                    int position_x;
                    position_x = Random.Range(1, 2000);
                    if (position_x == 1)
                    {

                        Vector3 position = new Vector3((-10) + i, (-3340) - k, (-10) + j);
                        obstacle_instant = Instantiate(obstacle, position, Quaternion.identity);
                        obstacle_instant.transform.localScale = new Vector3(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
                        obstacle_instant.GetComponent<Renderer>().material = Bleu;
                        obstacle_instant.transform.parent = parent_obstacle.transform;
                    }
                }
                if (random_colors == 1)
                {
                    int position_x;
                    position_x = Random.Range(1, 2000);
                    if (position_x == 1)
                    {

                        Vector3 position = new Vector3((-10) + i, (-3340) - k, (-10) + j);
                        obstacle_instant = Instantiate(obstacle, position, Quaternion.identity);
                        obstacle_instant.transform.localScale = new Vector3(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
                        obstacle_instant.GetComponent<Renderer>().material = jaune;
                        obstacle_instant.transform.parent = parent_obstacle.transform;
                    }

                }
                if (random_colors == 2)
                {
                    int position_x;
                    position_x = Random.Range(1, 2000);
                    if (position_x == 1)
                    {

                        Vector3 position = new Vector3((-10) + i, (-3340) - k, (-10) + j);
                        obstacle_instant = Instantiate(obstacle, position, Quaternion.identity);
                        obstacle_instant.transform.localScale = new Vector3(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
                        obstacle_instant.GetComponent<Renderer>().material = rouge;
                        obstacle_instant.transform.parent = parent_obstacle.transform;
                    }
                }
                if (random_colors == 3)
                {
                    int position_x;
                    position_x = Random.Range(1, 2000);
                    if (position_x == 1)
                    {

                        Vector3 position = new Vector3((-10) + i, (-3340) - k, (-10) + j);
                        obstacle_instant = Instantiate(obstacle, position, Quaternion.identity);
                        obstacle_instant.transform.localScale = new Vector3(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
                        obstacle_instant.GetComponent<Renderer>().material = vert;
                        obstacle_instant.transform.parent = parent_obstacle.transform;

                    }
                }
                
            }
            

        }   
    }
  

    private void Start()
    {

        //je calcule la distance pour que la densiter augemente en fonction de la pronfondeur
    
        distance_debut_r1 = Vector3.Distance(origin.transform.position, rep�re1.transform.position);
        distance_r1_r2 = Vector3.Distance(rep�re1.transform.position, rep�re2.transform.position);
        distance_r2_fin = Vector3.Distance(rep�re2.transform.position, fin.transform.position);

    
      

        plan();
        
    }

    private void Update()
    {

        




    }

}