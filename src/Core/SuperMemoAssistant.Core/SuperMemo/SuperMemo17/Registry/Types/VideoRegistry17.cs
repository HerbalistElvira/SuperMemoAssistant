﻿#region License & Metadata

// The MIT License (MIT)
// 
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the 
// Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// 
// 
// Created On:   2019/08/07 14:44
// Modified On:  2019/08/07 14:54
// Modified By:  Alexis

#endregion




using System;
using System.Threading.Tasks;
using SuperMemoAssistant.Interop.SuperMemo.Registry.Members;
using SuperMemoAssistant.Interop.SuperMemo.Registry.Types;
using SuperMemoAssistant.SMA;
using SuperMemoAssistant.SuperMemo.Common.Registry;
using SuperMemoAssistant.SuperMemo.Common.Registry.Files;
using SuperMemoAssistant.SuperMemo.SuperMemo17.Registry.Members;

namespace SuperMemoAssistant.SuperMemo.SuperMemo17.Registry.Types
{
  public class VideoRegistry17 : RegistryBase<Video, IVideo>, IVideoRegistry
  {
    #region Properties & Fields - Non-Public

    /// <inheritdoc />
    protected override IRegistryFileDescriptor FileDesc { get; } = new VideoFileDescriptor();
    /// <inheritdoc />
    protected override IRegistryUpdater Updater { get; }

    protected override IntPtr RegistryPtr =>
      new IntPtr(SM17Natives.TRegistry17.VideoRegistryInstance.Read<int>(Core.SMA.SMProcess.Memory));

    #endregion




    #region Constructors

    /// <inheritdoc />
    public VideoRegistry17()
    {
      Updater = new RegistryUpdater17<Video, IVideo>(this, OnMemberAddedOrUpdated);
    }

    #endregion




    #region Methods Impl

    public override Video CreateInternal(int id)
    {
      return Members[id] = new Video(id);
    }

    public Task<IVideo> AddAsync(string videoName, string videoPath)
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}
