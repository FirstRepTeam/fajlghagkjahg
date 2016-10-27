using System;
using com.shephertz.app42.paas.sdk.csharp.user;
using com.shephertz.app42.paas.sdk.csharp;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using  UnityEngine.UI;
namespace AssemblyCSharp
{ 
public class UserResponce : MonoBehaviour
{
        public InputField _inputLogin, _inputPassword, _inputEnailId;
        String userName ;
        String pwd ;
        String emailId ;

        public void SrtvrtWork ()
        {
            userName = _inputLogin.text;
            emailId = _inputEnailId.text;
            pwd = _inputPassword.text;
            ServiceAPI api = new ServiceAPI("5bff0ea5a179de0a573a0550b66ee7b310558968438973df420a20d276adb042", "47dd42cd8ff5935647bfbab517f684f9931adb29dd36db6dfdddc16d8f958834");
            UserService userService = api.BuildUserService();
            userService.CreateUser(userName, pwd, emailId, new UnityCallBack());
        }
        

        
        
        public class UnityCallBack : App42CallBack
        {
            public void OnSuccess(object response)
            {
                User user = (User)response;
                /* This will create user in App42 cloud and will return User object */
                App42Log.Console("userName is " + user.GetUserName());
                App42Log.Console("emailId is " + user.GetEmail());
            }
            public void OnException(Exception e)
            {
                App42Log.Console("Exception : " + e);
            }
        }

        private string result = "";
    public void OnSuccess(object user)
    {
        try
        {
            if (user is User)
            {
                User userObj = (User)user;
                result = userObj.ToString();
                Debug.Log("UserName : " + userObj.GetUserName());
                Debug.Log("EmailId : " + userObj.GetEmail());
                User.Profile profileObj = (User.Profile)userObj.GetProfile();
                if (profileObj != null)
                {
                    Debug.Log("FIRST NAME" + profileObj.GetFirstName());
                    Debug.Log("SEX" + profileObj.GetSex());
                    Debug.Log("LAST NAME" + profileObj.GetLastName());
                }
            }
            else
            {
                IList<User> userList = (IList<User>)user;
                result = userList[0].ToString();
                Debug.Log("UserName : " + userList[0].GetUserName());
                Debug.Log("EmailId : " + userList[0].GetEmail());

            }
        }
        catch (App42Exception e)
        {
            result = e.ToString();
            Debug.Log("App42Exception : " + e);
        }
    }

    public void OnException(Exception e)
    {
        result = e.ToString();
        Debug.Log("Exception : " + e);
    }

    public string getResult()
    {
        return result;
    }
}
}

