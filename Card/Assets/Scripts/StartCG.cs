using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCG : MonoBehaviour
{

    public MovieTexture mMovieTexture;
    private bool isPlaying = true;
    private bool isShowMessage = false;

    public TweenScale logoTweenScale;
    // Use this for initialization
    void Start()
    {
        mMovieTexture.loop = false;
        mMovieTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying)
        {
            if (Input.GetMouseButtonDown(0) && !isShowMessage)
            {
                isShowMessage = true;
            }
            else if (Input.GetMouseButtonDown(0) && isShowMessage)
            {
                StopMovie();
            }
        }

        if (isPlaying != mMovieTexture.isPlaying)
        {
            StopMovie();
        }
    }

    private void OnGUI()
    {
        if (isPlaying)
        {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), mMovieTexture);
            if (isShowMessage)
            {
                GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2, 200, 40), "再点击一次屏退出动画的播放");
            }
        }
    }

    private void StopMovie()
    {
        mMovieTexture.Stop();
        isPlaying = false;
        logoTweenScale.PlayForward();
    }
}
