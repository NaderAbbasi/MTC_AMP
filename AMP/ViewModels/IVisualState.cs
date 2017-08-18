﻿//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMP.ViewModels
{
    public class VisualStateEventArgs : EventArgs
    {
        public string NewState { get; set; }

        public VisualStateEventArgs()
        {

        }

        public VisualStateEventArgs(string newState)
        {
            NewState = newState;
        }
    }

    public interface IVisualState  
    {
        string CurrentVisualState { get; }
        event EventHandler<VisualStateEventArgs> VisualStateChanged;
    }
}
