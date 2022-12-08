﻿using System;

namespace Digitalroot.OdinPlusModUploader.Provider.NexusMods.Models;

internal class UploadChunkExistsRequestModel : UploadFileMetaDataRequestModel
{
  /// <inheritdoc />
  // ReSharper disable once MemberCanBePrivate.Global
  internal UploadChunkExistsRequestModel(string cookieNexusId
                                        , string cookiesid_develop
                                        , string resumableFilename
                                        , ulong resumableTotalSize
                                        , uint resumableChunkNumber
                                        , uint resumableCurrentChunkSize
                                        , uint resumableTotalChunks)
    : base(cookieNexusId
           , cookiesid_develop
           , resumableFilename
           , resumableTotalSize
           , resumableChunkNumber
           , resumableCurrentChunkSize
           , resumableTotalChunks) { }

  internal UploadChunkExistsRequestModel(string cookieNexusId
                                        , string cookieCookiesid
                                        , string resumableFilename
                                        , long resumableTotalSize
                                        , uint resumableChunkNumber
                                        , uint resumableCurrentChunkSize
                                        , uint resumableTotalChunks)
    : this(cookieNexusId
           , cookieCookiesid
           , resumableFilename
           , Convert.ToUInt64(resumableTotalSize)
           , resumableChunkNumber
           , resumableCurrentChunkSize
           , resumableTotalChunks) { }
}
