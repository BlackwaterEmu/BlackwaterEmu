' 
' Copyright (C) 2013-2014 Blackwater <No website yet.>
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
'

Imports System
Imports System.IO
Imports Spurious.Common
Imports Spurious.Common.BaseWriter


Public Module WS_DBCLoad

    Public Sub InitializeInternalDatabase()

        InitializeLoadDBCs()


        Try
            'Set all characters offline
            Database.Update("UPDATE characters SET char_online = 0;")

        Catch e As Exception
            Log.WriteLine(LogType.FAILED, "Internal database initialization failed! [{0}]{1}{2}", e.Message, vbNewLine, e.ToString)
        End Try
    End Sub

    Public Sub InitializeLoadDBCs()
        InitializeMaps()
        InitializeChatChannels()
        InitializeBattlegrounds()
        InitializeWorldSafeLocs()
        InitializeCharRaces()
        InitializeCharClasses()
    End Sub


End Module
