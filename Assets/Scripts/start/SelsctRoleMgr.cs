using UnityEngine;
using System.Collections;

public class SelsctRoleMgr : MonoBehaviour {

    public PreStartMgr preStartScript;

    private string[] HeroName = {
        "法师", "猎人", "圣骑士", 
        "战士", "德鲁伊", "术士", 
        "萨满", "牧师", "盗贼"
    };

    private UISprite spSelectedHeroHead;
    private UILabel laHeroName;

    void Awake() {
        spSelectedHeroHead = this.transform.FindChild("NowSelectHero").GetComponent<UISprite>();
        laHeroName = this.transform.FindChild("heroName").GetComponent<UILabel>();
    }

    public void HeroHeadClick(string heroName) {
        spSelectedHeroHead.spriteName = heroName;
        int heroNameIndex = heroName[heroName.Length - 1] - '1';
        laHeroName.text = HeroName[heroNameIndex];
    }

    public void OnStartBtnClick() {
        preStartScript.Show(spSelectedHeroHead.spriteName, "hero" + Random.Range(1, 10));
    }
}
