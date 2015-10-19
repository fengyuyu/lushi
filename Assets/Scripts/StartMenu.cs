using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {

    public TweenPosition selectFrame;
    public MovieTexture startMovie;
    public TweenScale logoTween;

    private bool isDrawMovie;
    private bool isShowTip;
    private bool isCanShowSelectFrame;

	// Use this for initialization
	void Start () {
        startMovie.loop = false;
        startMovie.Play();

        isDrawMovie = true;
        isShowTip = false;
        isCanShowSelectFrame = false;

        logoTween.AddOnFinished(logoTweenFinishCallBack);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) == true && isShowTip == false) {
            isShowTip = true;
        }else if (Input.GetMouseButtonDown(0) == true && isShowTip == true) {
            StopMovie();
        }

        if (isDrawMovie != startMovie.isPlaying) {
            StopMovie();
        }

        if (isCanShowSelectFrame == true && Input.GetMouseButtonDown(0)) {
            Debug.Log("sss11");
            selectFrame.PlayForward();
            isCanShowSelectFrame = false;
        }
	}

    void OnGUI() {
        if (isDrawMovie) {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), startMovie);

            if (isShowTip) {
                GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 20, 200, 40), "再点击一次跳过动画");
            }
        }
    }

    private void StopMovie() {
        isDrawMovie = false;
        startMovie.Stop();

        logoTween.PlayForward();
    }

    private void logoTweenFinishCallBack() {
        isCanShowSelectFrame = true;
        Debug.Log("asd");
    }
}
