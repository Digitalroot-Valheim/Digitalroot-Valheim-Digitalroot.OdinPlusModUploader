﻿using Digitalroot.OdinPlusModUploader.Models;

namespace Digitalroot.OdinPlusModUploader.Provider.NexusMods.Models;

internal class CookieRequestModel : AbstractRequestModel
{
  internal string CookieNexusId { get; }
  internal string CookieSidDevelop { get; }

  internal CookieRequestModel(string cookieNexusId, string cookieSidDevelop)
  {
    CookieNexusId = cookieNexusId;
    CookieSidDevelop = cookieSidDevelop;
  }
}
