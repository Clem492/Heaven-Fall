using UnityEngine;

public class player_movement : MonoBehaviour
{
    //je vais ajouter des variables pour pouvoir choisir des touches dans l'éditeur
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


    //je vais créer une méthode pour délacer le personnage
    void move()
    {
        if (gameObject.GetComponent<player_collision>().restart_menu == false)
        {
            float position_x = Input.GetAxis("Vertical");
            float position_y = Input.GetAxis("Horizontal");
            Vector3 new_position = new Vector3(position_y * Time.deltaTime * player_speed, 0, position_x * Time.deltaTime * player_speed);
            player.transform.Translate(new_position);
        }
      



    }

    //je vais créer une méthode pour pouvoir déplacer la camera
    void _camera()
    {
        if (gameObject.GetComponent<player_collision>().restart_menu == false)
        {
            float mouse_x = Input.GetAxisRaw("Mouse X");
            float mouse_y = Input.GetAxisRaw("Mouse Y");
            Vector3 cam_position_x = new Vector3(0, mouse_x, 0) * cam_speed * Time.deltaTime;
            player.transform.Rotate(cam_position_x);

            Vector3 cam_position_y = new Vector3(-mouse_y, 0, 0) * cam_speed * Time.deltaTime;
            player_camera.transform.Rotate(cam_position_y);
        }
      
    }

    
    //je vais faire un système pour que la souris se bloque sur le centre de l'écran
    void souris_bloquer()
    {
        Cursor.lockState = CursorLockMode.Locked;
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
       
    }


    private void Start()
    {
        souris_bloquer();
    }

    private void Update()
    {
        move();
        _camera();
        
    }

    
    

}
