using UnityEngine;
using System.Collections;

public class SlimeController : MonoBehaviour
{
    public float MoveSpeed;
    private Rigidbody2D MyRigidbody;
    private bool Moving;
    public float TimeBetweenMove;
    private float TimeBetweenMoveCounter;
    public float TimeToMove;
    private float TimeToMoveCounter;
    private Vector3 MoveDirection;
    public float waitToReload;
    private bool reloading;
    private GameObject Theplayer;
    // Use this for initialization
    void Start()
    {
        MyRigidbody = GetComponent<Rigidbody2D>();
        //TimeBetweenMoveCounter = TimeBetweenMove;
        //TimeToMoveCounter = TimeToMove;
        TimeBetweenMove = Random.Range(TimeBetweenMove * 0.75f, TimeBetweenMove * 1.25f);
        TimeToMoveCounter = Random.Range(TimeToMove * 0.75f, TimeToMove * 1.25f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Moving)
        {
            TimeToMoveCounter -= Time.deltaTime;
            MyRigidbody.velocity = MoveDirection;
            if (TimeToMoveCounter < 0f)
            {
                //TimeBetweenMoveCounter = TimeBetweenMove;
                TimeBetweenMove = Random.Range(TimeBetweenMove * 0.75f, TimeBetweenMove * 1.25f);
                Moving = false;

            }

        }
        else
        {
            TimeBetweenMoveCounter -= Time.deltaTime;
            MyRigidbody.velocity = Vector2.zero;
            if (TimeBetweenMoveCounter < 0f)
            {
                //TimeToMoveCounter = TimeToMove;
                TimeToMoveCounter = Random.Range(TimeToMove * 0.75f, TimeToMove * 1.25f);
                MoveDirection = new Vector3(Random.Range(-1f, 1f) * MoveSpeed, Random.Range(-1f, 1f) * MoveSpeed, 0f);
                Moving = true; 
            }
        }
        if (reloading)
        {
            waitToReload -= Time.deltaTime;
            if (waitToReload<0f)
            {
                Application.LoadLevel(Application.loadedLevel);
                Theplayer.SetActive(true);
            }
        }
    }
    
}