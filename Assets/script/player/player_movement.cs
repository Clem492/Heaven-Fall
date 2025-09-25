using UnityEngine;

public class player_movement : MonoBehaviour
{
    //je vais ajouter des variables pour pouvoir choisir des touches dans l'�diteur
    [SerializeField] string input_front;
    [SerializeField] string input_back;
    [SerializeField] string input_left;
    [SerializeField] string input_right;

    //je vais ajouter une variable pour adapter la vitesse de mon personnage
    [SerializeField]
    float player_speed;
    //je vais ajouter une variable gameobject pour la camera
    [SerializeField] GameObject player_camera;
    [SerializeField] GameObject player;
    [SerializeField] int cam_speed;


    //je vais cr�er une m�thode pour d�lacer le personnage
    void move()
    {
        if (Input.GetKey(input_front))
        {
            transform.Translate(0, 0, player_speed * Time.deltaTime);
        }
        if (Input.GetKey(input_back))
        {
            transform.Translate(0, 0, -(player_speed) * Time.deltaTime);
        }
        if (Input.GetKey(input_left))
        {
            transform.Translate(-(player_speed) * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(input_right))
        {
            transform.Translate(player_speed * Time.deltaTime, 0, 0);
        }
    }

    //je vais cr�er une m�thode pour pouvoir d�placer la souris
    void camera()
    {
        float mouse_x = Input.GetAxisRaw("Mouse X");
        float mouse_y = Input.GetAxisRaw("Mouse Y");
        Vector3 cam_position_x = new Vector3(0, mouse_x, 0) * cam_speed * Time.deltaTime;
        player.transform.Rotate(cam_position_x);

        Vector3 cam_position_y = new Vector3(-mouse_y, 0, 0) * cam_speed * Time.deltaTime;
        player_camera.transform.Rotate(cam_position_y);
    }

    
    //je vais faire un syst�me pour que la souris se bloque sur le centre de l'�cran
    void souris_bloquer()
    {
        Cursor.lockState = CursorLockMode.Locked;
       
    }


    private void Start()
    {
        souris_bloquer();
    }

    private void Update()
    {
        move();
        camera();
        
    }

    


}
