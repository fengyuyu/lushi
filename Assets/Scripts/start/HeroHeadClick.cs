using UnityEngine;
using System.Collections;

public class HeroHeadClick : MonoBehaviour {
    void OnClick() {
        this.transform.parent.GetComponent<SelsctRoleMgr>().HeroHeadClick(this.name);
    }
}
