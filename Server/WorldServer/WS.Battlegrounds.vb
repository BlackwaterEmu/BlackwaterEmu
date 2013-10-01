﻿' 
' Copyright (C) Spurious Emu 2008 and Blackwater Emulator 2013-2014.
'
' This program is free software; you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation; either version 2 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with this program; if not, write to the Free Software
' Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

Imports Spurious.Common.BaseWriter

'Public Enumerations
'   BG_WSG  =   1
'   BG_AB   =   2
'End Enumerations

Public Module WS_Battlegrounds

    Public BATTLEFIELDs As New Dictionary(Of Integer, Battlefield)

    Public Class Battlefield
        Implements IDisposable

        Public MembersTeam1 As New List(Of CharacterObject)
        Public MembersTeam2 As New List(Of CharacterObject)

        Public ID As Integer
        Public Map As UInteger
        Public MapType As BattlefieldMapType

        Public Sub New(ByVal rMapType As BattlefieldMapType, ByVal rMap As UInteger)
            BATTLEFIELDs.Add(ID, Me)
        End Sub
        Public Sub Dispose() Implements System.IDisposable.Dispose
            BATTLEFIELDs.Remove(ID)
        End Sub
        Public Sub Update(ByVal State As Object)
        End Sub

        Public Sub Broadcast(ByVal p As PacketClass)
            BroadcastTeam1(p)
            BroadcastTeam2(p)
        End Sub
        Public Sub BroadcastTeam1(ByVal p As PacketClass)
            For Each c As CharacterObject In MembersTeam1.ToArray
                c.Client.SendMultiplyPackets(p)
            Next
        End Sub
        Public Sub BroadcastTeam2(ByVal p As PacketClass)
            For Each c As CharacterObject In MembersTeam2.ToArray
                c.Client.SendMultiplyPackets(p)
            Next
        End Sub

    End Class



End Module
