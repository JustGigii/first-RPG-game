using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
    public GameObject FollowTarget;
    private Vector3 TargetPos;
    public float movespeed;
    private static bool CameraExsist;
	// Use this for initialization
	void Start () {
        if (!CameraExsist)
        {
            CameraExsist = true;
            DontDestroyOnLoad(transform.gameObject);//אחרי על מעבר מפה
        }
        else
        {
      Destroy(gameObject);//אחרי על מעבר מפה
        }
      

    }

    // Update is called once per frame
    void Update () {
        TargetPos = new Vector3(FollowTarget.transform.position.x, FollowTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, TargetPos, movespeed* Time.deltaTime);
	}
}
