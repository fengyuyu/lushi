using UnityEngine;
using System.Collections;

public class BattleInitMgr : MonoBehaviour {

    private UISprite spHero1;
    private UISprite spHero2;

	// Use this for initialization
	void Start () {
	    spHero1 = this.transform.FindChild("hero1").GetComponent<UISprite>();
        spHero2 = this.transform.FindChild("hero2").GetComponent<UISprite>();

        string hero1Name = PlayerPrefs.GetString("hero1Name");
        string hero2Name = PlayerPrefs.GetString("hero2Name");

        spHero1.spriteName = hero1Name;
        spHero2.spriteName = hero2Name;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
