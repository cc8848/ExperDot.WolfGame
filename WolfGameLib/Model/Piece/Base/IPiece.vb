﻿Imports System.Numerics
''' <summary>
''' 棋子接口
''' </summary>
Public Interface IPiece
    ''' <summary>
    ''' 阵营
    ''' </summary>
    ReadOnly Property Camp As Camp
    ''' <summary>
    ''' 位置
    ''' </summary>
    Property Location As Vector2
    ''' <summary>
    ''' 是否可移动
    ''' </summary>
    Function Moveable(map As Map, loc As Vector2) As Boolean
End Interface