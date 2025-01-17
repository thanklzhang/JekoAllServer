﻿using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UserMgr
{
    private static UserMgr instance;

    public static UserMgr Instance
    {
        get
        {
            if (null == instance)
            {
                instance = new UserMgr();
            }

            return instance;
        }
    }


    Dictionary<string, User> accountUserDic = new Dictionary<string, User>();
    //Dictionary<int, User> idUserDic = new Dictionary<int, User>();
    //Dictionary<int, string> idTokenDic = new Dictionary<int, string>();

    public void UserOnline(User u)
    {
        accountUserDic.Add(u.account, u);
        // idUserDic.Add(u.id, u);
    }

    public void UserExit(string account)
    {
        if (accountUserDic.ContainsKey(account))
        {
            accountUserDic.Remove(account);
        }

    }

    public User GetUser(string account)
    {
        if (accountUserDic.ContainsKey(account))
        {
            return accountUserDic[account];
        }
        return null;
    }

    //public void UserExit(int id)
    //{
    //    if (idUserDic.ContainsKey(id))
    //    {
    //        idUserDic.Remove(id);
    //    }

    //}
}

