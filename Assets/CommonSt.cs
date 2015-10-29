
namespace CommonStruct{

    enum CardSkill { 
        NoSkill, //无技能
        Mock, //嘲讽
        Charge, //冲锋
    }

    //卡片信息
    public struct CardInfo {
        string m_name;  //名字
        string m_attack; //攻击
        string m_blood; //血量
        CardSkill[] m_skill; //技能
        int m_crystalNum; //水晶数 
    }

}

