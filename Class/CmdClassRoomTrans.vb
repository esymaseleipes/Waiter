'Imports DevExpress.Data.Filtering



'Imports DevExpress.Xpo
'Imports WindowsApplication1.Cmp300

'Public Class CmdClassRoomTrans
'    Public Sub New()

'    End Sub






'End Class

'Namespace Cmp300
'    Partial Class RoomTrans

'        <NonPersistent>
'        Public ReadOnly Property GetRoomRemain() As Double
'            Get
'                Return GetOrderRoomTransRemain()
'            End Get
'        End Property

'        <NonPersistent>
'        Public ReadOnly Property GetOpenRoomRemain() As Double
'            Get
'                'Return 0
'                Return GetOpenOrderRoomTransRemain()
'            End Get
'        End Property



'        Private Function GetOrderRoomTransRemain() As Double
'            'Me.PosOrders
'            'Dim ses As Session = Me.Session
'            'Dim RoomOrders As XPCollection(Of PosOrder) = New XPCollection(Of PosOrder)(ses)

'            'Dim RoomOrders1 As XPCollection(Of PosOrder) = New XPCollection(Of PosOrder)(ses,
'            '                                                                            New BinaryOperator("RoomTrans", oRoomTrans) And
'            '                                                                            New BinaryOperator("OrderPayType", EnOrderPayType.EnPayTypeRoomCharge) And
'            '                                                                            New BinaryOperator("Status", EnOrderStatus.EnOrderClosed))


'            'Return RoomOrders.Where(Function(a) a.RoomTrans Is Me).Where(Function(b) b.OrderPayType = EnOrderPayType.EnPayTypeRoomCharge).Where(Function(c) c.Status = EnOrderStatus.EnOrderClosed).Sum(Function(s) s.OrderValue)
'            Return Me.PosOrders.Where(Function(a) a.OrderPayType = EnOrderPayType.EnPayTypeRoomCharge).Where(Function(b) b.Status = EnOrderStatus.EnOrderClosed).Sum(Function(s) s.OrderValue)
'        End Function

'        Private Function GetOpenOrderRoomTransRemain() As Double
'            Dim ses As Session = Me.Session
'            Dim RoomOrders As XPCollection(Of PosOrder) = New XPCollection(Of PosOrder)(ses)

'            Return RoomOrders.Where(Function(a) a.RoomTrans Is Me).Where(Function(c) c.Status = EnOrderStatus.EnOrderOpen).Sum(Function(s) s.OrderValue)

'        End Function

'    End Class
'End Namespace