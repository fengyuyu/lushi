using UnityEngine;
using System.Collections;

public class EndRound : MonoBehaviour {

    private UILabel btnText;

	void Start () {
        btnText = this.gameObject.GetComponent<UILabel>();
	}

    void OnClick() {
        btnText.text = "对方回合";
    }
}
