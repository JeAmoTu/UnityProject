using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSelect : MonoBehaviour {
    private UISprite mSelectHeroImage;
    private UILabel mSelectHeroName;

    private string[] HeroNames = {
        "法师：吉安娜",
        "猎人：雷克萨",
        "圣骑士：乌瑟尔",
        "战士：加尔鲁什.地狱咆哮",
        "德鲁伊：玛法里奥",
        "术士：古尔丹",
        "萨满：萨尔",
        "牧师：安度因",
        "潜行者：瓦莉拉"
    };

    private void Awake() {
        mSelectHeroImage = this.transform.parent.Find("Hero0").GetComponent<UISprite>();
        mSelectHeroName = this.transform.parent.Find("HeroName").GetComponent<UILabel>();
    }

    void OnClick() {
        string mHeroName = this.gameObject.name;
        mSelectHeroImage.spriteName = mHeroName;
        char mHeroNameIndexChar = mHeroName[mHeroName.Length  - 1];
        int mHeroNameIndex = mHeroNameIndexChar - '0';
        mSelectHeroName.text = HeroNames[mHeroNameIndex - 1];
    }
}
