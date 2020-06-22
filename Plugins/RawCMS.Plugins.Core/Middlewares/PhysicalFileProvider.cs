﻿//******************************************************************************
// <copyright file="license.md" company="RawCMS project  (https://github.com/arduosoft/RawCMS)">
// Copyright (c) 2019 RawCMS project  (https://github.com/arduosoft/RawCMS)
// RawCMS project is released under GPL3 terms, see LICENSE file on repository root at  https://github.com/arduosoft/RawCMS .
// </copyright>
// <author>Daniele Fontani, Emanuele Bucarelli, Francesco Mina</author>
// <autogenerated>true</autogenerated>
//******************************************************************************
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.IO;

namespace RawCMS.Plugins.Core.Middlewares
{
    public class RawCmsPhysicalFileProvider : IFileProvider, IDisposable
    {
        private Dictionary<string, PhysicalFileProvider> providerMap = new Dictionary<string, PhysicalFileProvider>();

        public RawCmsPhysicalFileProvider()
        {
            var appRoot = Path.Combine(Directory.GetCurrentDirectory(), "Plugins/RawCMS.Plugins.Core/Assets");

            //providerMap.Add("/", new PhysicalFileProvider());
        }

        public IFileInfo GetFileInfo(string subpath)
        {
            return null;
        }

        public IDirectoryContents GetDirectoryContents(string subpath)
        {
            return null;
        }

        public IChangeToken Watch(string filter)
        {
            return null;
        }

        public void Dispose()
        {
        }
    }
}