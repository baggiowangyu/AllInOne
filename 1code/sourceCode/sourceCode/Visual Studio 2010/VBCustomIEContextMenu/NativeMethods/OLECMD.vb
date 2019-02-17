﻿'*************************** Module Header ******************************'
' Module Name:  OLECMD.vb
' Project:      VBCustomIEContextMenu
' Copyright (c) Microsoft Corporation.
' 
' The class OLECMD associates command flags from the OLECMDF enumeration with
' a command identifier through a call to IOleCommandTarget::QueryStatus.
' 
' 
' This source is subject to the Microsoft Public License.
' See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
' All other rights reserved.
' 
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
' EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
' WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
'*************************************************************************'

Imports System
Imports System.Runtime.InteropServices

Namespace NativeMethods
    <StructLayout(LayoutKind.Sequential)>
    Public Class OLECMD
        <MarshalAs(UnmanagedType.U4)>
        Public cmdID As Integer
        <MarshalAs(UnmanagedType.U4)>
        Public cmdf As Integer
    End Class
End Namespace

