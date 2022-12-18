using UnityEngine;
using System.Collections;

public class playercotroler : MonoBehaviour {
    public float movespeed;
    private Animator anim;
    private bool playermove;
    public Vector2 lastmove;
    private Rigidbody2D MyRigidbody;
    private static bool PlayerExists;//פקודה לקיומו של שחן כפול מונע משחקן כפול
    // Use this for initialization
    void Start () {
        // GetComponent אומר זה לבקש אפשרות מי פונקציה במנוע שאחרי הלדבים מסיויימים
        anim = GetComponent<Animator>();//אחרי על לתזוזה
        MyRigidbody = GetComponent<Rigidbody2D>();//אחרי על תקעית הבלוקים 
        if (!PlayerExists)//אומר בעצם אם אין שחקן בתוך המפה צור מפה
            {
                PlayerExists = true;
            DontDestroyOnLoad(transform.gameObject);//אחרי על מעבר מפות
        }
        else
        {
            Destroy(gameObject); //הורס את השחקן 
        }
	}
	// Update is called once per frame
	void Update () {
        playermove = false;
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * movespeed * Time.deltaTime, 0f, 0f));
            MyRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal")* movespeed, MyRigidbody.velocity.y);
            playermove = true;
            lastmove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") <-0.5f)
        {
            //transform.Translate(new Vector3(0f,Input.GetAxisRaw("Vertical") * movespeed * Time.deltaTime, 0f));
            MyRigidbody.velocity = new Vector2(MyRigidbody.velocity.x,Input.GetAxisRaw("Vertical")*movespeed);
            playermove = true;
            lastmove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }
        if(Input.GetAxisRaw("Horizontal")<0.5f && Input.GetAxisRaw("Horizontal")>-0.5f)
        {
            MyRigidbody.velocity = new Vector2(0f, MyRigidbody.velocity.y);
        }
        if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
        {
            MyRigidbody.velocity = new Vector2( MyRigidbody.velocity.x,0f);
        }

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("playermoving", playermove);
        anim.SetFloat("lastmovex", lastmove.x);
        anim.SetFloat("lastmovey", lastmove.y);
    }
}
