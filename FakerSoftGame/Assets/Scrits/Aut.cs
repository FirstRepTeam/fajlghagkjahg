using System;
using com.shephertz.app42.paas.sdk.csharp.user;
using com.shephertz.app42.paas.sdk.csharp;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class Aut : MonoBehaviour {

  
    public InputField _inputLoginAut, _inputPasswordAut;
    public String userNameAut;
    public String pwdAut;
    UserService userService = App42API.BuildUserService();

    public void aut()
    {
        userNameAut = _inputLoginAut.text;
           pwdAut = _inputPasswordAut.text;  
        userService.Authenticate(userNameAut, pwdAut, new UnityCallBack());

    }
    public class UnityCallBack : App42CallBack
    {
        public void OnSuccess(object response)
        {
            User user = (User)response;
            App42Log.Console("userName is " + user.GetUserName());
            App42Log.Console("sessionId is " + user.GetSessionId());
            Debug.Log("+++++");
            Debug.Log(user.GetUserName());
        }
        public void OnException(Exception e)
        {
            App42Log.Console("Exception : " + e);
            Debug.Log("-----");

        }
    }

}
