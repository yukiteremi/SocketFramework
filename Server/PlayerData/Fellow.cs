//********************************************************************
// 文件名: Fellow.cs
// 描述: 伙伴
// 作者: TangYi
// 创建时间: 2014-2-18
//
// 修改历史:
//********************************************************************
using UnityEngine;
using System.Collections.Generic;
using System;




    public enum FELLOWCLASS
    {
        ANIMAL = 1,     //动物型
        HUNMAN = 2,     //人型
    }

    enum FELLOWATTACK
    {
        PHYSCIS = 1,    //物理攻击
        MAGIC = 2,      //魔法攻击
    }

    enum FELLOWQUALITY
    {
        WHITE = 0,      //白色品质
        GREEN = 1,      //绿色品质
        BLUE = 2,       //蓝色品质
        PURPLE = 3,     //紫色品质
        ORANGE = 4,     //橙色品质
    }

    public class Fellow
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <returns></returns>
        public Fellow()
        {
            CleanUp();
        }

        /// <summary>
        /// 清空
        /// </summary>
        public void CleanUp()
        {
            m_nGuid = 0;
            m_nDataId = -1;
            m_szName = "";
            m_nExp = -1;
            m_nLevel = -1;
            m_nStarLevel = -1;
            m_nZzPoint = -1;
            m_nQuality = -1;
            m_bLocked = false;
            m_bCalled = false;
            m_fZizhi_Attack = 0.0f;
            m_fZizhi_Hit = 0.0f;
            m_fZizhi_Critical = 0.0f;
            m_fZizhi_Guard = 0.0f;
            m_fZizhi_Bless = 0.0f;
            for (int index = 0; index < FELLOW_MAXOWNSKILL; index++)
            {
                m_OwnSkillId[index] = -1;
            }
            m_CombatAttr_Attack = 0;
            m_CombatAttr_Hit = 0;
            m_CombatAttr_Critical = 0;
            m_CombatAttr_Guard = 0;
        }


    /// <summary>
    /// IsValid
    /// </summary>
    /// <returns></returns>
    public bool IsValid()
    {
        if (m_nDataId >= 0)
        {
            return true;
        }
        return false;
    }



    /// <summary>
    /// 伙伴Guid
    /// </summary>
    /// <returns></returns>
    private UInt64 m_nGuid;
        public System.UInt64 Guid
        {
            get { return m_nGuid; }
            set { m_nGuid = value; }
        }

        /// <summary>
        /// 伙伴ID 对应FellowAttr.txt里面的ID
        /// </summary>
        /// <returns></returns>
        private int m_nDataId;
        public int DataId
        {
            get { return m_nDataId; }
            set { m_nDataId = value; }
        }

        /// <summary>
        /// 名称
        /// </summary>
        /// <returns></returns>
        private string m_szName;
        public string Name
        {
            get { return m_szName; }
            set { m_szName = value; }
        }

        /// <summary>
        /// 经验值
        /// </summary>
        /// <returns></returns>
        private int m_nExp;
        public int Exp
        {
            get { return m_nExp; }
            set { m_nExp = value; }
        }

        /// <summary>
        /// 级别
        /// </summary>
        /// <returns></returns>
        private int m_nLevel;
        public int Level
        {
            get { return m_nLevel; }
            set { m_nLevel = value; }
        }

        /// <summary>
        /// 星级
        /// </summary>
        /// <returns></returns>
        private int m_nStarLevel;
        public int StarLevel
        {
            get { return m_nStarLevel; }
            set { m_nStarLevel = value; }
        }

        /// <summary>
        /// 资质点
        /// </summary>
        private int m_nZzPoint;
        public int ZzPoint
        {
            get { return m_nZzPoint; }
            set { m_nZzPoint = value; }
        }

        /// <summary>
        /// 品质
        /// </summary>
        private int m_nQuality;
        public int Quality
        {
            get { return m_nQuality; }
            set { m_nQuality = value; }
        }

        /// <summary>
        /// 加锁
        /// </summary>
        private bool m_bLocked;
        public bool Locked
        {
            get { return m_bLocked; }
            set { m_bLocked = value; }
        }

        /// <summary>
        /// 出战
        /// </summary>
        private bool m_bCalled;
        public bool Called
        {
            get { return m_bCalled; }
            set { m_bCalled = value; }
        }

        /// <summary>
        /// 攻击资质
        /// </summary>
        /// <returns></returns>
        private float m_fZizhi_Attack;
        public float Zizhi_Attack
        {
            get { return m_fZizhi_Attack; }
            set { m_fZizhi_Attack = value; }
        }


        /// <summary>
        /// 命中资质
        /// </summary>
        /// <returns></returns>
        private float m_fZizhi_Hit;
        public float Zizhi_Hit
        {
            get { return m_fZizhi_Hit; }
            set { m_fZizhi_Hit = value; }
        }

        /// <summary>
        /// 暴击资质
        /// </summary>
        /// <returns></returns>
        private float m_fZizhi_Critical;
        public float Zizhi_Critical
        {
            get { return m_fZizhi_Critical; }
            set { m_fZizhi_Critical = value; }
        }

        /// <summary>
        /// 守护资质
        /// </summary>
        /// <returns></returns>
        private float m_fZizhi_Guard;
        public float Zizhi_Guard
        {
            get { return m_fZizhi_Guard; }
            set { m_fZizhi_Guard = value; }
        }

        /// <summary>
        /// 加持资质
        /// </summary>
        /// <returns></returns>
        private float m_fZizhi_Bless;
        public float Zizhi_Bless
        {
            get { return m_fZizhi_Bless; }
            set { m_fZizhi_Bless = value; }
        }

        /// <summary>
        /// 攻击力
        /// </summary>
        private int m_CombatAttr_Attack;
        public int CombatAttr_Attack
        {
            get { return m_CombatAttr_Attack; }
            set { m_CombatAttr_Attack = value; }
        }
        /// <summary>
        /// 命中
        /// </summary>
        private int m_CombatAttr_Hit;
        public int CombatAttr_Hit
        {
            get { return m_CombatAttr_Hit; }
            set { m_CombatAttr_Hit = value; }
        }
        /// <summary>
        /// 暴击
        /// </summary>
        private int m_CombatAttr_Critical;
        public int CombatAttr_Critical
        {
            get { return m_CombatAttr_Critical; }
            set { m_CombatAttr_Critical = value; }
        }
        /// <summary>
        /// 守护
        /// </summary>
        private int m_CombatAttr_Guard;
        public int CombatAttr_Guard
        {
            get { return m_CombatAttr_Guard; }
            set { m_CombatAttr_Guard = value; }
        }
        /// <summary>
        /// 加持
        /// </summary>
        private int m_CombatAttr_Bless;
        public int CombatAttr_Bless
        {
            get { return m_CombatAttr_Bless; }
            set { m_CombatAttr_Bless = value; }
        }
        /// <summary>
        /// 伙伴拥有的技能
        /// </summary>
        public const int FELLOW_MAXOWNSKILL = 6; //伙伴最大拥有技能数量
        private int[] m_OwnSkillId = new int[FELLOW_MAXOWNSKILL];
        public int GetOwnSkillId(int index)
        {
            if (index >= 0 && index < FELLOW_MAXOWNSKILL)
            {
                return m_OwnSkillId[index];
            }
            return -1;
        }
        public void SetOwnSkillId(int skillId, int index)
        {
            if (index >= 0 && index < FELLOW_MAXOWNSKILL)
            {
                m_OwnSkillId[index] = skillId;
            }
        }
        public bool IsHaveSkillId(int skillId)
        {
            for (int index = 0; index < FELLOW_MAXOWNSKILL; index++)
            {
                if (m_OwnSkillId[index] == skillId)
                {
                    return true;
                }
            }
            return false;
        }


    }
