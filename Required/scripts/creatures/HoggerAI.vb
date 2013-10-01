'HOGGER.
'Comp% 25%
'Comments: not sure how to make NPCs cast yet. 
Namespace Scripts
    Public Class TestAI
        Inherits TBaseAI

        Public Creature As CreatureObject
        Public Sub New(ByRef ParentCreature As CreatureObject)
            Creature = ParentCreature
        End Sub
        Public Overrides Sub Dispose()
        End Sub
        Enum spells
            Spell_Knockdown = 18812
        End Enum 'Not sure if we need to add an enumerator or not, so let's see.
        Public Overrides Sub OnAttack(ByRef Attacker As BaseUnit)
            If TypeOf Attacker Is CharacterObject Then
                Creature.SendChatMessage("No hurt Hogger!", ChatMsg.CHAT_MSG_YELL, LANGUAGES.LANG_GLOBAL)
            End If
            If AIState.AI_DEAD Then
                Creature.SendChatMessage("Yipe! Help Hogger!", ChatMsg.CHAT_MSG_YELL, LANGUAGES.LANG_GLOBAL)

            End If
            ' Not sure on the cast yet.. so. Creature.CastSpell(18812, 
        End Sub

    End Class
End Namespace
