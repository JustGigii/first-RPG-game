using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPoint : MonoBehaviour {
    private playercotroler Theplayer;
    private  CameraMove TheCamera;
    public Vector2 strartDirection; // משנה אצ כיוון הפנים אחרי הטעינה
	// Use this for initialization
	void Start () {
        Theplayer = FindObjectOfType<playercotroler>();//מעיבר את העריכים של playercontroler ל-ThePlayer
        Theplayer.transform.position= transform.position;//משווה בין איפה שנמתא הstartpoint לאיפה לthe player
        TheCamera = FindObjectOfType<CameraMove>();
        TheCamera.transform.position = new Vector3(transform.position.x, transform.position.y, TheCamera.transform.position.z);//Vector3 לא עושים את זה כמו הראשון בגלל שפה זה
        Theplayer.lastmove = strartDirection;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
