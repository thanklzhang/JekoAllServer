﻿using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


public class DBMgr
{
    static SqlConnectPool connectPool;

   //public static List<DBEntityMgr<DBEntity>> dataMgrs;

    public static UserDataMgr<UserData> userDataMgr;
    public static HeroDataMgr<HeroData> heroDataMgr;

    public static void Init()
    {
        connectPool = new SqlConnectPool();
        connectPool.AddConnect(new MysqlConnect());

        //dataMgrs = new List<DBEntityMgr<DBEntity>>();

        
        userDataMgr = CreateDataMgr<UserData, UserDataMgr<UserData>>();
        heroDataMgr = CreateDataMgr<HeroData, HeroDataMgr<HeroData>>();
        //userDataMgr = CreateDataMgr<UserData, UserDataMgr<UserData>>();

        Thread t = new Thread(() =>
        {
            DBHeartBeat hb = new DBHeartBeat();
            hb.Start(() =>
            {
                SaveAll();
            }, 18);
        });
        t.Start();
    }
    
    public static void SaveAll()
    {
        userDataMgr.SaveAll();
        heroDataMgr.SaveAll();
    }

    public static K CreateDataMgr<T, K>() where T : DBEntity, new() where K : DBEntityMgr<T>, new()
    {
        var dataMgr = new K();
        var op = new MysqlOperator<T>();
        op.SetConnectPool(connectPool);
        dataMgr.SetOperator(op);
        return dataMgr;
    }
}

