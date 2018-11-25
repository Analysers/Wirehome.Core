﻿#pragma warning disable IDE1006 // Naming Styles
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global

using System;
using Wirehome.Core.Python;

namespace Wirehome.Core.Repository
{
    public class PackageManagerServicePythonProxy : IInjectedPythonProxy
    {
        private readonly PackageManagerService _packageManagerService;

        public PackageManagerServicePythonProxy(PackageManagerService packageManagerService)
        {
            _packageManagerService = packageManagerService ?? throw new ArgumentNullException(nameof(packageManagerService));
        }

        public string ModuleName { get; } = "package_manager";

        public string get_file_uri(string uid, string filename)
        {
            if (uid == null) throw new ArgumentNullException(nameof(uid));

            var packageUid = PackageUid.Parse(uid);
            return $"/packages/{packageUid.Id}/{packageUid.Version}/{filename}";
        }

        public void download_package(string uid)
        {
            if (uid == null) throw new ArgumentNullException(nameof(uid));

            var packageUid = PackageUid.Parse(uid);
            _packageManagerService.DownloadPackageAsync(packageUid).GetAwaiter().GetResult();
        }
    }
}