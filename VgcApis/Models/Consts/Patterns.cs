﻿namespace VgcApis.Models.Consts
{
    public static class Patterns
    {
        public const string NonAlphabets = @"[^0-9a-zA-Z]";

        public const string Base64NonStandard = @"[A-Za-z0-9+/]+";

        public const string HttpUrl =
           @"(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_=]*)?";

        public const string Base64Standard =
            @"(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=|[A-Za-z0-9+/]{4})";

    }
}
