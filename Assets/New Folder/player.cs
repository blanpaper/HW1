using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //private Animator ani;

    private Transform tra;
    //  private float hor =  0.0f;
    //   private float ver = 0.0f;

    public float moving_speed = 5.0f;
    public float rot_speed = 10.0f;

    public GameObject obj;

   private void player_Moving_Control()
    {

        float keyHorizontal = Input.GetAxis("Horizontal");
        float keyVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * this.moving_speed * Time.smoothDeltaTime * keyHorizontal, Space.World);

        transform.Translate(Vector3.forward * this.moving_speed * Time.smoothDeltaTime * keyVertical, Space.World);


    }
    // Start is called before the first frame update
    void Ro()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Debug.Log(0);

        h = h * this.rot_speed * Time.deltaTime;
        v = v * this.rot_speed * Time.deltaTime;


        transform.Rotate(Vector3.back * h);
        transform.Rotate(Vector3.right * v);

    }

    void shot()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        Instantiate(obj, new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z),
        Quaternion.identity);

    }
    void Start()
    {
        tra = GetComponent<Transform>();
       // ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        player_Moving_Control();
        Ro();
        shot();
    }
}
