Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls


<DefaultProperty("Text"), ToolboxData("<{0}:frmdashboard runat=server></{0}:frmdashboard>")> _
Public Class frmdashboard
    Inherits WebControl

    <Bindable(True), Category("Appearance"), DefaultValue(""), Localizable(True)> Property Text() As String
        Get
            Dim s As String = CStr(ViewStateMode("Text"))
            If s Is Nothing Then
                Return String.Empty
            Else
                Return s
            End If
        End Get

        Set(ByVal Value As String)
            ViewStateMode("Text") = Value
        End Set
    End Property

    Protected Overrides Sub RenderContents(ByVal writer As HtmlTextWriter)
        writer.Write(Text)
    End Sub

End Class
