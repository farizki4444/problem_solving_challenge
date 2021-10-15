using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    // Rigidbody 2D bola
    private Rigidbody2D rigidBody2D;

    // Besarnya gaya awal yang diberikan untuk mendorong bola
    public float xInitialForce;
    public float yInitialForce;

    //menggerakkan objek ke atas menggunakan kode
    public KeyCode ButtonUp = KeyCode.W;
    //menggerakkan objek ke bawah menggunakan kode
    public KeyCode ButtonDown  = KeyCode.S;
    //menggerakkan objek ke kanan menggunakan kode
    public KeyCode ButtonRight  = KeyCode.D;
    //menggerakkan objek ke kiri menggunakan kode
    public KeyCode ButtonLeft  = KeyCode.A;

    //kecepatan bola
    public float SpeedBall = 9f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();

        // Mulai game
        RestartGame();

    }


    void Update(){
    //dapatkan kecepatan bola
        Vector2 velocity = rigidBody2D.velocity;

        // controller
        if(Input.GetKey(ButtonUp))
        {
            velocity.y = SpeedBall;
        }
        
        else if (Input.GetKey(ButtonDown))
        {
            velocity.y = - SpeedBall;
        }
        
         else if (Input.GetKey(ButtonRight))
        {
            velocity.x = SpeedBall;
        }
        else if (Input.GetKey(ButtonLeft))
        {
            velocity.x = -SpeedBall;
        }

        else 
        {
            velocity.y = 0f;
            velocity.x = 0f;
        }
        //masukkan kembali kecepatan ke rigid body
        rigidBody2D.velocity = velocity;
    }

    void ResetBall()
    {

        //reset posisi menjadi (0,0)
        transform.position = Vector2.zero;
        //reset kecepatan menjadi (0,0)
        rigidBody2D.velocity = Vector2.zero;
    }

    void PushBall()
    {
        // Tentukan nilai komponen y dari gaya dorong antara -yInitialForce dan yInitialForce
        float yRandomInitialForce = Random.Range(-yInitialForce, yInitialForce);

        // Tentukan nilai acak antara 0 (inklusif) dan 2 (eksklusif)
        float randomDirection = Random.Range(0, 2);

        // Jika nilainya di bawah 1, bola bergerak ke kiri. 
        // Jika tidak, bola bergerak ke kanan.
        if (randomDirection < 1.0f)
        {
            // Gunakan gaya untuk menggerakkan bola ini.
            rigidBody2D.AddForce(new Vector2(-xInitialForce, yInitialForce));
        }
        else
        {
            rigidBody2D.AddForce(new Vector2(xInitialForce, yInitialForce));
        }
    }
    void RestartGame()
    {
        // Kembalikan bola ke posisi semula
        ResetBall();

        // Setelah 2 detik, berikan gaya ke bola
        Invoke("PushBall", 2);
    }






}
