/********************************************************************************
 *	文件名：	PlayerData.cs
 *	全路径：	\Script\Player\UserData\PlayerData.cs
 *	创建人：	李嘉
 *	创建时间：2013-12-30
 *
 *	功能说明：主角游戏全程需要保留数据
 *	修改记录：
*********************************************************************************/

using System;
using System.Collections.Generic;

using UnityEngine;
using System.Collections;


public enum MONEYTYPE
{
    MONEYTYPE_INVALID = -1,
    MONEYTYPE_COIN = 0,     //金币
    MONEYTYPE_YUANBAO = 1,  //元宝
    MONEYTYPE_YUANBAO_BIND = 2,  //绑定元宝
    MONEYTYPE_TYPECOUNT,
}

public enum Consume_Type
{
    YUANBAO = 1,
    COIN = 2,
    CURRENCY = 3,
    EXP = 4,
    ITEM = 5,
}

public enum Consume_SubType
{
    YUANBAO_NORMAL = 1,
    YUANBAO_BIND = 2,
    COIN = 1,
}

//服务器标志、枚举同步
public enum SERVER_FLAGS_ENUM
{
    FLAG_START = 0,         //开始标记
    FLAG_VIP = FLAG_START,  //VIP开关
    FLAG_SNS,               //分享功能
    FLAG_ACTIVATION,        //激活界面
    FLAG_PAYACT,            //充值活动开关
    FLAG_TIMEFASHION,       //限时时装
	FLAG_MOUNTTAB = FLAG_START,          //元宝商店坐骑分页
    FLAG_FASHIONTAB,        //人物界面时装分页
    FLAG_CYFANS,            //畅游老玩家回馈奖励开关
    FLAG_WISHING,           //许愿池开关
    FLAG_LIGHTSKILL,        //轻功开关
    FLAG_DAILYLUCKYDRAW,    //每日幸运抽奖
    FLAG_NUM,               //当前使用数量
    FLAG_MAX = 30,          //最大使用数量
};

public class PlayerData
{
    public PlayerData()
    {
        CleanUp();
    }

    public void CleanUp()
    {
        //伙伴
        m_FellowContainer = new FellowContainer();
        m_FellowPlayerEffect = false;
        m_ActiveFellowSkill = new List<int>();
        m_FellowGainCount_Free = 0;
        m_FellowGainCount_Coin = 0;
        m_FellowGainCount_YuanBao = 0;
        m_FellowGainCD_Coin = 0;
    }


    //伙伴数据
    private FellowContainer m_FellowContainer;
    public FellowContainer FellowContainer
    {
        get { return m_FellowContainer; }
        set { m_FellowContainer = value; }
    }
    //伙伴特效
    private bool m_FellowPlayerEffect;
    public bool FellowPlayerEffect
    {
        get { return m_FellowPlayerEffect; }
        set { m_FellowPlayerEffect = value; }
    }
    //已经激活的伙伴技能
    private List<int> m_ActiveFellowSkill;
    public List<int> ActiveFellowSkill
    {
        get { return m_ActiveFellowSkill; }
        set { m_ActiveFellowSkill = value; }
    }
    //当天抽取伙伴次数
    private int m_FellowGainCount_Free;
    public int FellowGainCount_Free
    {
        get { return m_FellowGainCount_Free; }
        set { m_FellowGainCount_Free = value; }
    }
    private int m_FellowGainCount_Coin;
    public int FellowGainCount_Coin
    {
        get { return m_FellowGainCount_Coin; }
        set { m_FellowGainCount_Coin = value; }
    }
    private int m_FellowGainCount_YuanBao;
    public int FellowGainCount_YuanBao
    {
        get { return m_FellowGainCount_YuanBao; }
        set { m_FellowGainCount_YuanBao = value; }
    }
    //伙伴抽取CD
    private int m_FellowGainCD_Coin;
    public int FellowGainCD_Coin
    {
        get { return m_FellowGainCD_Coin; }
        set { m_FellowGainCD_Coin = value; }
    }
  

}