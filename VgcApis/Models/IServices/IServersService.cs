﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace VgcApis.Models.IServices
{
    public interface IServersService
    {
        event EventHandler OnCoreStart, OnCoreClosing;

        void RequireFormMainReload();
        void ResteIndexQuiet();
        void SortSelectedBySpeedTest();
        void SortSelectedBySummary();

        bool RunSpeedTestOnSelectedServers();

        string PackSelectedServersIntoV4Package(
            string orgUid, string pkgName);

        string PackServersIntoV4Package(
            List<Interfaces.ICoreServCtrl> servList,
            string orgServerUid,
            string packageName);

        int GetAvailableHttpProxyPort();
        string ReplaceOrAddNewServer(string orgUid, string newConfig);

        ReadOnlyCollection<Interfaces.ICoreServCtrl> GetTrackableServerList();
        ReadOnlyCollection<Interfaces.ICoreServCtrl> GetAllServersOrderByIndex();
    }
}
