
using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.user;


public class ServerConnect : MonoBehaviour
{
    public InputField _inputLogin, _inputPassword, _inputMail;

    UserService userService = App42API.BuildUserService();

    string userName, pwd, emailId;



    public void ServerWorking()
    {
        userName = _inputLogin.text;
        pwd = _inputPassword.text;
        emailId = _inputMail.text;

        App42API.Initialize("5bff0ea5a179de0a573a0550b66ee7b310558968438973df420a20d276adb042", "47dd42cd8ff5935647bfbab517f684f9931adb29dd36db6dfdddc16d8f958834");
        userService.CreateUser(userName, pwd, emailId, new UnityCallBack());
    }

}
public class UnityCallBack : App42CallBack
{
    public void OnSuccess(object response)
    {
        User user = (User)response;
        Debug.Log("userName is " + user.GetUserName());
        Debug.Log("emailId is " + user.GetEmail());
    }
    public void OnException(Exception e)
    {
        Debug.Log("Exception : " + e);

    }
}
