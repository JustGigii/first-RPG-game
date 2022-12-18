using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNewArea : MonoBehaviour {
    public string LevelToload;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        //זה שאול אם הדמות נגדע בבלוק המסומן
        if (other.gameObject.name== "player")
        {
            //מעלה את המפה שכתוב בסוגריים
            Application.LoadLevel(LevelToload);
        }
    }
}
