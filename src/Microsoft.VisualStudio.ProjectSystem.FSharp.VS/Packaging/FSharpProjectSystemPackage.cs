﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Packaging;
using Microsoft.VisualStudio.ProjectSystem.VS;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.ProjectSystem;

// We register ourselves as a new CPS "project type"
[assembly: ProjectTypeRegistration(projectTypeGuid: FSharpProjectSystemPackage.ProjectTypeGuid, displayName: "#1", displayProjectFileExtensions: "#2", defaultProjectExtension: "fsproj", language: "FSharp", resourcePackageGuid: FSharpProjectSystemPackage.PackageGuid, Capabilities = ManagedProjectSystemPackage.DefaultCapabilities + "; " + ProjectCapability.FSharp, DisableAsynchronousProjectTreeLoad = true)]

namespace Microsoft.VisualStudio.Packaging
{
    [Guid(PackageGuid)]
    [PackageRegistration(AllowsBackgroundLoading = true, RegisterUsing = RegistrationMethod.CodeBase, UseManagedResourcesOnly = true)]
    [DplOptOutRegistration(ProjectTypeGuid, true)]
    internal class FSharpProjectSystemPackage : AsyncPackage
    {
        public const string ProjectTypeGuid = "6EC3EE1D-3C4E-46DD-8F32-0CC8E7565705";
        public const string LegacyProjectTypeGuid = "F2A71F9B-5D33-465A-A702-920D77279786";
        public const string PackageGuid = "a724c878-e8fd-4feb-b537-60baba7eda83";
        private const string ProjectTypeGuidFormatted = "{" + ProjectTypeGuid + "}";

        public FSharpProjectSystemPackage()
        {
        }
    }
}
