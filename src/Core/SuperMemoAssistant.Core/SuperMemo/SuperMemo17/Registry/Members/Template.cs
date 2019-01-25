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
// Created On:   2018/05/19 19:42
// Modified On:  2019/01/24 13:50
// Modified By:  Alexis

#endregion




using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SuperMemoAssistant.Interop.SuperMemo.Content;
using SuperMemoAssistant.Interop.SuperMemo.Elements.Types;
using SuperMemoAssistant.Interop.SuperMemo.Registry.Members;
using SuperMemoAssistant.SuperMemo.SuperMemo17.Files;

namespace SuperMemoAssistant.SuperMemo.SuperMemo17.Registry.Members
{
  public class Template : RegistryMemberBase, ITemplate
  {
    #region Constructors

    public Template(int        id,
                    RegMemElem mem,
                    RegRtElem  rt)
      : base(id,
             mem,
             rt) { }

    #endregion




    #region Methods Impl

    public override string GetFilePath()
    {
      return null;
    }

    public Task<bool> DeleteAsync()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IElement> GetLinkedElements()
    {
      throw new NotImplementedException();
    }

    public Task<bool> NeuralAsync()
    {
      throw new NotImplementedException();
    }

    public Task<bool> RenameAsync(string newName)
    {
      throw new NotImplementedException();
    }

    public IComponentGroup GetComponentGroup()
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}
