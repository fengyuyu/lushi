using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using CommonStruct;

public class CardLibMgr : MonoBehaviour {

    private static CardLibMgr _instance;

    public static CardLibMgr GetInstance() {
        if(_instance == null) {
            _instance = GameObject.FindObjectOfType<CardLibMgr>();
        }
        return _instance;
    }

    private Dictionary<int, string> dicCardIndexName;
    private Dictionary<string, CardInfo> dicCardNameInfo;

	// Use this for initialization
	void Start () {
        InitDic();
	}

    private void InitDic() { 
        //初始化字典数据
    }

    public string GetCardName(int index) {
        return dicCardIndexName[index];
    }

    public CardInfo GetCardInfo(int index) {
        return dicCardNameInfo[dicCardIndexName[index]];
    }

    //overload
    public CardInfo GetCardInfo(string name)
    {
        return dicCardNameInfo[name];
    }
}
