using UnityEngine;
using System.Collections;

public class PreStartMgr : MonoBehaviour {

    private TweenPosition heroSelf;
    private TweenPosition heroAI;
    private TweenScale vsSprite;

    void Awake() { 
        heroSelf = this.transform.FindChild("heroSelf").GetComponent<TweenPosition>();
        heroAI = this.transform.FindChild("heroAI").GetComponent<TweenPosition>();
        vsSprite = this.transform.FindChild("vsSprite").GetComponent<TweenScale>();
    }

	// Use this for initialization
	void Start () {
        //Show("hero1", "hero4");
	}

    public void Show(string myHeroName, string aiHeroName) {
        BlackMask.Instance.Show();
        vsSprite.PlayForward();
        heroSelf.GetComponent<UISprite>().spriteName = myHeroName;
        heroSelf.PlayForward();
        heroAI.GetComponent<UISprite>().spriteName = aiHeroName;
        heroAI.PlayForward();

        StartCoroutine("enterNextScene");
    }

    private IEnumerator enterNextScene() {
        yield return new WaitForSeconds(2f);

        Application.LoadLevel(0);
    }
}
