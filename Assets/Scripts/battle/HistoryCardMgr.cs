using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HistoryCardMgr : MonoBehaviour {

    public GameObject preCard;
    public GameObject card1;
    public GameObject card2;

    //历史卡牌容量
    public const int CARD_NUM = 6;

    private float offsetY;
    private GameObject inCard;
    private GameObject outCard;

    private List<GameObject> historyCard;

    void Start() {
        inCard = this.transform.Find("inCard").gameObject;
        outCard = this.transform.Find("outCard").gameObject;

        historyCard = new List<GameObject>();

        offsetY = Mathf.Abs(card1.transform.position.y - card2.transform.position.y);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.LeftControl)) {
            //StartCoroutine(AddCard());
            AddCard();
            //inCard.AddComponent<iTween>();
        }
    }

    public void AddCard() {
        GameObject go =  NGUITools.AddChild(this.gameObject, preCard);
        go.transform.position = inCard.transform.position;
        
        iTween.MoveTo(go, card1.transform.position, 0.5f);
        historyCard.Add(go);

        if (historyCard.Count == CARD_NUM + 1)
        { 
            iTween.MoveTo(historyCard[0], outCard.transform.position, 1f);
            Destroy(historyCard[0], 2f);
            historyCard.RemoveAt(0);
        }

        for (int i = 0; i < historyCard.Count - 1; i++) {
            iTween.MoveTo(historyCard[i], historyCard[i].transform.position - new Vector3(0f, offsetY, 0f), 0.5f);
        }
    }
}
