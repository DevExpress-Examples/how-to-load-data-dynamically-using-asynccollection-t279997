Imports DevExpress.Core
Imports T279997_VB.ServiceReference1

Public NotInheritable Class MainPage
    Inherits Page
    Private Service1 As New Service1Client()
    Public Property Items() As AsyncCollection(Of Item)
    Public Sub New()
        Me.InitializeComponent()

        Items = New AsyncCollection(Of Item)(Async Function() Await Service1.CountAsync(), Async Function(skipCount As Integer, takeCount As Integer) Await Service1.GetDataAsync(skipCount, takeCount))
        grid.ItemsSource = Items
    End Sub
End Class
