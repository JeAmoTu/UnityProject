using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CryStal1 : MonoBehaviour {
    public int mUsableNum = 1;
    public int mTotalNum = 1;
    public int maxNum;
    public UISprite[] mCryStals;
    private UILabel mCryStalLabel;
    // Use this for initialization
    void Start () {
        mCryStalLabel = this.GetComponent<UILabel>();
    }
	
	// Update is called once per frame
	void Update () {
        UpdateShow();
	}

    private void Awake() {
        maxNum = mCryStals.Length;
    }

    private void UpdateShow() {
        for (int i = mTotalNum; i < maxNum; i++) {
            mCryStals[i].gameObject.SetActive(false);
        }
        for (int i = 0; i < mTotalNum; i++) {
            mCryStals[i].gameObject.SetActive(true);
        }


        for (int i = mUsableNum; i < mTotalNum; i++) {
            mCryStals[i].spriteName= "TextInlineImages_normal";
        }

        for (int i = 0; i < mUsableNum; i++) {
            if (i != 9) {
                mCryStals[i].spriteName = "TextInlineImages_0" + (i + 1);
            }
            else {
                mCryStals[i].spriteName = "TextInlineImages_10";
            }
        }
        mCryStalLabel.text = mUsableNum + "/" + mTotalNum;
    }
}
