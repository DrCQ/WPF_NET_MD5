﻿Imports CommunityToolkit.Mvvm.ComponentModel

Namespace Services

    Public Class ApplicationDataService
        Inherits ObservableObject
        Implements IAppDataService

#Region "Private variables"

        Private _fileName As String = "File Name"
        Private _isNotModal As Boolean = True

#End Region

        Property FileName As String Implements IAppDataService.FileName
            Get
                Return _fileName
            End Get
            Set(value As String)
                SetProperty(Of String)(_fileName, value)
            End Set
        End Property

        Property IsNotModal As Boolean Implements IAppDataService.IsNotModal
            Get
                Return _isNotModal
            End Get
            Friend Set(value As Boolean)
                SetProperty(Of Boolean)(_isNotModal, value)
            End Set
        End Property
    End Class

End Namespace

