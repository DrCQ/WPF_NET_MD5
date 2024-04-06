﻿Imports Microsoft.Extensions.DependencyInjection
Imports WPF_NET_MD5.Services

Namespace ViewModel

    Public NotInheritable Class ViewModelLocator

#Region "Private variables"

        Private _mainVM As MainWindowViewModel = Nothing
        Private _statusBarVM As StatusBarViewModel = Nothing

#End Region

#Region "Properties: AppDataService, MainWindowVM, StatusBarVM"

        ReadOnly Property AppDataService As IAppDataService
            Get
                Return ViewModelService.GetService(Of IAppDataService)
            End Get
        End Property

        ReadOnly Property MainWindowVM As MainWindowViewModel
            Get
                If _mainVM Is Nothing Then _mainVM = ViewModelService.GetService(Of MainWindowViewModel)
                Return _mainVM
            End Get
        End Property

        ReadOnly Property StatusBarVM As StatusBarViewModel
            Get
                If _statusBarVM Is Nothing Then _statusBarVM = ViewModelService.GetService(Of StatusBarViewModel)
                Return _statusBarVM
            End Get
        End Property

#End Region

#Region "Private shared property: ViewModelService"

        Private Shared Property ViewModelService As IServiceProvider = Nothing

#End Region

#Region "Methods: New"

        Sub New()

            If ViewModelService Is Nothing Then

                Dim service As New ServiceCollection

                With service
                    'register service classes
                    .AddSingleton(Of IAppDataService, ApplicationDataService)
                    'register ViewModel classes
                    .AddTransient(Of MainWindowViewModel)
                    .AddTransient(Of StatusBarViewModel)

                End With

                ViewModelService = service.BuildServiceProvider

            End If

        End Sub

#End Region




    End Class


End Namespace

