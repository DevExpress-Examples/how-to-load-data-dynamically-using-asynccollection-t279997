Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.ServiceModel
Imports System.Text
Imports System.Threading

Namespace WebApplication1
    <KnownType(GetType(Item))> _
    Public Class Service1
        Implements IService1
        Public Function GetData(ByVal skipCount As Integer, ByVal takeCount As Integer) As IEnumerable Implements IService1.GetData
            Dim endIndex As Integer = skipCount + takeCount
            Debug.WriteLine(String.Format("skipCount={0}, takeCount={1}", skipCount, takeCount))
            Dim items As New List(Of Item)()
            For i As Integer = skipCount To endIndex - 1
                items.Add(New Item With {.Id = i, .Name = "Name" + i.ToString()})
            Next i
            Return items
        End Function
        Public Function Count() As Integer Implements IService1.Count
            Return 1000
        End Function
    End Class
    Public Class Item
        Implements IItem

        <DataMember> _
        Public Property Id() As Integer Implements IItem.Id
        <DataMember> _
        Public Property Name() As String Implements IItem.Name
    End Class
End Namespace