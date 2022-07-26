using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectServerFirst
{
    /// <summary>
    /// socket连接服务器
    /// </summary>
    /// <param name="ip">ip地址</param>
    /// <param name="port">端口号，如不知知道请赋值0，会调用默认端口</param>
    public void StartConnect(string ip, int port)
    {
        if (port == 0)
        {
            NetManager.Instance().ConnectToServer("192.168.43.128", 4399, OnConect);
        }
        else
        {
            NetManager.Instance().ConnectToServer(ip, port, OnConect);
        }
    }

    private void OnConect(bool bSuccess, string result)
    {
        if (bSuccess)
        {
            LoginData.accountData.CleanData();
            //登录
            NetManager.SendUserLogin(Onlogin, false);

            Debug.Log("Connect");
        }
        else
        {
            Debug.Log("ERROR");
        }
    }
    /// <summary>
    /// 登录回调
    /// </summary>
    /// <param name="result">结果</param>
    /// <param name="validateResult">回调方法</param>
    private void Onlogin(GC_LOGIN_RET.LOGINRESULT result, int validateResult)
    {
        Debug.Log(validateResult + "||||||||||||||||" + result);
        if (result == GC_LOGIN_RET.LOGINRESULT.SUCCESS)
        {
            //选择角色
            NetManager.SendChooseRole(RetSelectRoleFail);
        }
    }
    /// <summary>
    /// 连接失败
    /// </summary>
    /// <param name="result">结果</param>
    private void RetSelectRoleFail(GC_SELECTROLE_RET.SELECTROLE_RESULT result)
    {
        //打印结果
        Debug.Log("???" + result);
    }
}
