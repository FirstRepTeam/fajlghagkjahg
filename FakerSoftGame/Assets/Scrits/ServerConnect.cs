
using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.user;


public class ServerConnect: MonoBehaviour {
    public Text _inputLogin, _inputPassword, _inputMail;

    UserService userService = App42API.BuildUserService();

    string userName, pwd,emailId;

    public void Registr() {

         userName = _inputLogin.text;   //= "GameLeadMmrBank";
         pwd = _inputPassword.text; //= "ujlfytrhvkz111";
         emailId = _inputMail.text; //= "bogdanlikhoglyad@gmail.com";

    }

    public void ServerWorking()
    {
        
        App42API.Initialize("c53587259f23dd894259dfa9b7ac90e7dca48a3b9e2345f372bd6bd3b826e2d0","0029c09894c20fe1d28bade219995e1204f24a4cbd407e725eb4271a5e29e122");
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
