using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CrystalMgr : MonoBehaviour {
    //当前可用水晶数
    public int canUseCrystalNum;
    //当前总水晶数
    public int totalCrystalNum;
    //最多可显示的水晶数
    public int maxCrystalNum;
    //水晶物体list
    public List<GameObject> listCrystal;
    
    private UILabel crystalLabel;
	// Use this for initialization
	void Start () {
	    crystalLabel = this.transform.Find("crystalLabel").GetComponent<UILabel>();
	}
	
	// Update is called once per frame
	void Update () {
        ShowCrystal();
	}

    void ShowCrystal() {
        for (int i = totalCrystalNum; i < maxCrystalNum; i++) {
            listCrystal[i].SetActive(false);
        }

        string crystalSpName;
        for (int i = 0; i < totalCrystalNum; i++) {
            listCrystal[i].SetActive(true);

            //显示对应水晶
            if(i < canUseCrystalNum && i != 9) {
                crystalSpName = "TextInlineImages_0" + (i + 1);
            }else if(i < canUseCrystalNum && i == 9) {
                crystalSpName = "TextInlineImages_" + (i + 1);
            }else {
                crystalSpName = "TextInlineImages_normal";
            }

            listCrystal[i].GetComponent<UISprite>().spriteName = crystalSpName;
        }

        crystalLabel.text = canUseCrystalNum + "/" + totalCrystalNum;
    }
}
