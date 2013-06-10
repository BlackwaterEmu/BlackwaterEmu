' Here are listed sctipted area triggers, called on packet recv.
' All not scripted triggers are supposed to be teleport trigers,
' handled by the core.
'
'Last  update: 06/10/2013

Imports System
Imports Microsoft.VisualBasic
Imports Spurious.WorldServer

Namespace Scripts
    Public Module AreaTriggers

        'Area-52 Neuralyzer
        Public Sub HandleAreaTrigger_4422(ByVal GUID As ULong)
            If CHARACTERs(GUID).HaveAura(34400) = False Then CHARACTERs(GUID).CastOnSelf(34400)
        End Sub
        Public Sub HandleAreaTrigger_4466(ByVal GUID As ULong)
            If CHARACTERs(GUID).HaveAura(34400) = False Then CHARACTERs(GUID).CastOnSelf(34400)
        End Sub
        Public Sub HandleAreaTrigger_4471(ByVal GUID As ULong)
            If CHARACTERs(GUID).HaveAura(34400) = False Then CHARACTERs(GUID).CastOnSelf(34400)
        End Sub
        Public Sub HandleAreaTrigger_4472(ByVal GUID As ULong)
            If CHARACTERs(GUID).HaveAura(34400) = False Then CHARACTERs(GUID).CastOnSelf(34400)
        End Sub

        'Stormwind Stockades
        Public Sub HandleAreaTrigger_107(ByVal GUID As ULong)
            If CHARACTERs(GUID).HaveAura(81) = True Then CHARACTERs(GUID).Teleport(-1, 52, -27, 1, 35)
        End Sub
        ' Ghostlands
        Public Sub HandleAreaTrigger_4409(ByVal GUID As ULong)
            If CHARACTERs(GUID).HaveAura(34400) = False Then CHARACTERs(GUID).CastOnSelf(34400)
            If CHARACTERs(GUID).HaveAura(34400) = True Then CHARACTERs(GUID).Teleport(7880, -6193, 21, 42, 530)

        End Sub


        Public Sub HandleAreaTrigger_4386(ByVal GUID As ULong)
            If CHARACTERs(GUID).HaveAura(34400) = False Then CHARACTERs(GUID).CastOnSelf(34400)
            If CHARACTERs(GUID).HaveAura(34400) = True Then CHARACTERs(GUID).Teleport(3468.457, -4482.249, 137.3152, 2.135496, 0)

        End Sub
    End Module
End Namespace
