using UnityEngine;
using System.Collections;

public class BlackMask : MonoBehaviour {

    /*private static BlackMask instance;

    public static BlackMask Instance {
        get {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<BlackMask>();
            }
            return instance;
        }
    }*/
    public static BlackMask Instance;

    void Awake() {
        Instance = this;
        this.gameObject.SetActive(false);
    }

    void Start() {
        //this.gameObject.SetActive(false);
    }

    public void Show() {
        this.gameObject.SetActive(true);
    }

    public void Hide() {
        this.gameObject.SetActive(false);
    }
}
