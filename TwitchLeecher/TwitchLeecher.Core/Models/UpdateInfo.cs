﻿using System;

namespace TwitchLeecher.Core.Models
{
    public class UpdateInfo
    {
        #region Constructors

        public UpdateInfo(Version newVersion, DateTime releaseDate, string downloadUrl, string releaseNotes)
        {
            if (string.IsNullOrWhiteSpace(downloadUrl))
            {
                throw new ArgumentNullException(nameof(downloadUrl));
            }

            if (string.IsNullOrWhiteSpace(releaseNotes))
            {
                throw new ArgumentNullException(nameof(releaseNotes));
            }

            NewVersion = newVersion ?? throw new ArgumentNullException(nameof(newVersion));
            ReleaseDate = releaseDate.ToString("yyyy년 MM월 dd일");
            DownloadUrl = downloadUrl;
            ReleaseNotes = releaseNotes;
        }

        #endregion Constructors

        #region Properties

        public Version NewVersion { get; }

        public String ReleaseDate { get; }

        public string DownloadUrl { get; }

        public string ReleaseNotes { get; }

        #endregion Properties
    }
}