﻿namespace VgcApis.Models.Interfaces.Lua
{
    public interface ILuaMisc
    {
        string ReadLocalStorage(string key);
        void WriteLocalStorage(string key, string value);

        #region encode decode
        string AddV2cfgPrefix(string b64Str);
        string AddVeePrefix(string b64Str);
        string AddVmessPrefix(string b64Str);

        string Base64Encode(string text);
        string Base64Decode(string b64Str);

        string Config2V2cfg(string config);
        string Config2VeeLink(string config);
        string Config2VmessLink(string config);

        string ShareLink2ConfigString(string shareLink);
        int ImportLinks(string links, string mark);
        #endregion

        string GetAppDir();
        string GetLinkBody(string link);
        string PredefinedFunctions();
        void Print(params object[] contents);
        string ScanQrcode();
        void Sleep(int milliseconds);
    }
}
