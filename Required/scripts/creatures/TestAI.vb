'Basic AI Testing Agent.
Namespace Scripts
    Public Class TestAI
        Inherits TBaseAI

        Public Craeture As CreatureObject
        Public Sub New(ByRef ParentCreature As CreatureObject)
            Creature = ParentCreature
        End Sub
        Public Overrides Sub Dispose()
        End Sub

        Public Overrides Sub OnAttack(ByRef Attacker As BaseUnit)
            If TypeOf Attacker Is CharacterObject Then
                Creature.SendChatMessage("Test Agent onAttack successful!", ChatMsg.CHAT_MSG_MONSTER_SAY, LANGUAGES.LANG_UNIVERSAL)

            End If
        End Sub

    End Class
End Namespace