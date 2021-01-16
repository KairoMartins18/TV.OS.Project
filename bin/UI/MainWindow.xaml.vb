

Imports VirtualKeyboard.Wpf
Imports System.Windows.Threading

Class MainWindow




    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        timer()
    End Sub
    Private dpTimer As DispatcherTimer

    Public Sub timer()
        dpTimer = New DispatcherTimer
        dpTimer.Interval = TimeSpan.FromMilliseconds(60)
        AddHandler dpTimer.Tick, AddressOf TickMe
        dpTimer.Start()
    End Sub
    Private Sub TickMe()
        Dim hour As System.DateTime = Now
        horas1.Content = hour.Hour
        minutos.Content = hour.Minute
    End Sub

    Private Sub config_Click(sender As Object, e As RoutedEventArgs) Handles config.Click
        Dim abt As Window = New about_tvmode
        abt.Show()
    End Sub

    Private Sub google_Click(sender As Object, e As RoutedEventArgs) Handles google.Click
        Dim exePath As String = My.Application.Info.DirectoryPath
        Process.Start(exePath + ".\com.tvproject.webbrowser\com.tvproject.webbrower.exe")


    End Sub

    Private Sub youtube_Click(sender As Object, e As RoutedEventArgs) Handles youtube.Click

        Dim exePath As String = My.Application.Info.DirectoryPath
        Process.Start(exePath + ".\yt\yttv.exe")

        Dim yt As Window = New ytsplash
        yt.Show()
    End Sub
End Class
