﻿Imports System.Web.SessionState
Imports Microsoft.WindowsAzure
Imports Microsoft.WindowsAzure.StorageClient
Imports WebRole.Entities
Imports Microsoft.WindowsAzure.ServiceRuntime

Public Class Global_asax
    Inherits System.Web.HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application is started

        ' This code sets up a handler to update CloudStorageAccount instances when their corresponding
        ' configuration settings change in the service configuration file.
        CloudStorageAccount.SetConfigurationSettingPublisher(AddressOf SetConfigurationSettingPublisher)

        ' Create the table and add some dummy data.
        Dim account = CloudStorageAccount.FromConfigurationSetting("DataConnectionString")
        Dim tableClient = New CloudTableClient(account.TableEndpoint.AbsoluteUri, account.Credentials)
        tableClient.CreateTableIfNotExist("Person")
        Dim ctx As New PersonTableStorageContext
        Dim person1 As New Person("DefaultPartition", "Row1")
        person1.Name = "Ared"
        person1.Age = 24
        Dim person2 As New Person("DefaultPartition", "Row2")
        person2.Name = "Lante"
        person2.Age = 24
        Dim person3 As New Person("DefaultPartition", "Row3")
        person3.Name = "Bright"
        person3.Age = 24
        Me.InsertEntityIfNotExist(ctx, person1)
        Me.InsertEntityIfNotExist(ctx, person2)
        Me.InsertEntityIfNotExist(ctx, person3)

    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session is started
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires at the beginning of each request
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires upon attempting to authenticate the use
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when an error occurs
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session ends
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application ends
    End Sub

    Private configName As String
    Private configSetter As Func(Of String, Boolean)

    Sub RoleEnvironmentChanged(ByVal anotherSender As Object, ByVal arg As RoleEnvironmentChangedEventArgs)
        If (arg.Changes.OfType(Of RoleEnvironmentConfigurationSettingChange)().Any(Function(change As RoleEnvironmentConfigurationSettingChange) change.ConfigurationSettingName = configName)) Then
            ' The corresponding configuration setting has changed, propagate the value
            If Not configSetter.Invoke(RoleEnvironment.GetConfigurationSettingValue(configName)) Then
                ' In this case, the change to the storage account credentials in the
                ' service configuration is significant enough that the role needs to be
                ' recycled in order to use the latest settings. (for example, the 
                ' endpoint has changed)
                RoleEnvironment.RequestRecycle()
            End If
        End If
    End Sub

    Private Sub SetConfigurationSettingPublisher(ByVal configName As String, ByVal configSetter As Func(Of String, Boolean))
        ' Provide the configSetter with the initial value
        configSetter.Invoke(RoleEnvironment.GetConfigurationSettingValue(configName))
        Me.configName = configName
        Me.configSetter = configSetter
        AddHandler RoleEnvironment.Changed, AddressOf RoleEnvironmentChanged
    End Sub

    ''' <summary>
    ''' Used to insert dummy data. Do not use in production code.
    ''' </summary>
    Private Sub InsertEntityIfNotExist(ByVal ctx As PersonTableStorageContext, ByVal entity As Person)
        ' If an entity already exists and the insertion fails, just catch the exception and go on...
        Try
            ctx.AddObject(PersonTableStorageContext.TableName, entity)
            ctx.SaveChanges()
        Catch
        End Try
    End Sub
End Class