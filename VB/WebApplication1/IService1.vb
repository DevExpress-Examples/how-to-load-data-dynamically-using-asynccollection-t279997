Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.ServiceModel
Imports System.Text

Namespace WebApplication1
    ' NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    <ServiceContract> _
    Public Interface IService1
        <OperationContract, ServiceKnownType(GetType(Item))> _
        Function GetData(ByVal skipCount As Integer, ByVal takeCount As Integer) As IEnumerable
        <OperationContract> _
        Function Count() As Integer
    End Interface
    Public Interface IItem
        Property Id() As Integer
        Property Name() As String
    End Interface
End Namespace