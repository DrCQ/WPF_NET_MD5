Imports CommunityToolkit.Mvvm.Messaging.Messages
Imports WPF_NET_MD5.Helper

Namespace Messages

    Friend Class NotificationMessage
        Inherits ValueChangedMessage(Of AppNotification)

        Sub New(arg As AppNotification)
            MyBase.New(arg)
        End Sub

    End Class

End Namespace

