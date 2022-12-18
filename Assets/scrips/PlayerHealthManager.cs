using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {
    public int PlayerMaxHealth;
    public int PlayerCurrentHealth;
	// Use this for initialization
	void Start () {
        PlayerCurrentHealth = PlayerMaxHealth;
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerCurrentHealth<=0)
        {
            gameObject.SetActive(false);
        }
	}
    public void HurtPlayer(int DamegeToGive)
    {
        PlayerCurrentHealth -= DamegeToGive;
    }
    public void SetMaxHealth()
    {
        PlayerCurrentHealth = PlayerMaxHealth;
    }
}
