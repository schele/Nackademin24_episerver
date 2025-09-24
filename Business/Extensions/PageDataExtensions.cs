﻿using EPiServer.Web.Routing;

namespace nackademin24_episerver.Business.Extensions
{
    public static class PageDataExtensions
    {
        public static string GetExternalUrl(this IContent content)
        {
            var internalUrl = UrlResolver.Current.GetUrl(content.ContentLink);

            if (internalUrl != null)
            {
                var url = new UrlBuilder(internalUrl);
                var friendlyUrl = UriSupport.AbsoluteUrlBySettings(url.ToString());

                return friendlyUrl;
            }

            return null;
        }

        public static string Url(this string url)
        {
            return UrlResolver.Current.GetUrl(url);
        }
    }
}
