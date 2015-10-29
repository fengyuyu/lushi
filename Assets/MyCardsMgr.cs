using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MyCardsMgr : MonoBehaviour {

    public GameObject cardPrefab;

    private static float OFFSET_X = 20f;

    private List<GameObject> listMyCard;

    private Transform cardPos;

	// Use this for initialization
	void Start () {
        listMyCard = new List<GameObject>();
        cardPos = this.transform.Find("cardPos");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            AddCard("card_1_1_1_1");
        }
        if (Input.GetKeyDown(KeyCode.LeftControl)) {
            if (listMyCard.Count > 0) {
                RemoveCard(Random.Range(0, listMyCard.Count - 1));
            }
        }
	}

    public void AddCard(string cardName) { 
        GameObject go = NGUITools.AddChild(this.gameObject, cardPrefab);
        go.GetComponent<UISprite>().spriteName = cardName;

        listMyCard.Add(go);
        if (listMyCard.Count == 1)
        {
            go.transform.localPosition = cardPos.localPosition;
        }else {
            for (int i = 0; i < listMyCard.Count - 1; i++) {
                listMyCard[i].transform.localPosition = listMyCard[i].transform.localPosition - new Vector3(OFFSET_X, 0f, 0f);
            }
            go.transform.localPosition = listMyCard[listMyCard.Count - 2].transform.localPosition + new Vector3(2 * OFFSET_X, 0f, 0f);
        } 
    }

    public void RemoveCard(int index) {
        if (index < 0 || index >= listMyCard.Count) {
            return;
        }
        GameObject go = listMyCard[index];
        go.SetActive(false);
        Destroy(go, 2f);
        listMyCard.RemoveAt(index);

        for (int i = 0; i < index; i++) {
            listMyCard[i].transform.localPosition = listMyCard[i].transform.localPosition + new Vector3(OFFSET_X, 0f, 0f);
        }
        for (int i = index; i < listMyCard.Count; i++) {
            listMyCard[i].transform.localPosition = listMyCard[i].transform.localPosition -  new Vector3(OFFSET_X, 0f, 0f);
        }
    }
}
