Imports System.Windows.Threading.DispatcherTimer
Public Class ytsplash

    Private Sub splash_Loaded(sender As Object, e As RoutedEventArgs) Handles splash.Loaded
        Dim t As New System.Windows.Threading.DispatcherTimer
        AddHandler t.Tick, AddressOf dispatcherTimer_Tick
        t.Interval = TimeSpan.FromSeconds(5)
        t.Start()

    End Sub
    Private Sub dispatcherTimer_Tick(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class
