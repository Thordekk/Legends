﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legends.Core.Protocol
{
    public enum PacketCmd : short
    {
        PKT_KeyCheck = 0x0,
        PKT_S2C_RestrictCameraMovement = 0x6,
        PKT_S2C_UpdateGoldRedirectTarget = 0x7,
        PKT_C2S_HeartBeat = 0x8,
        PKT_C2S_SellItem = 0x9,
        PKT_UnpauseGame = 0xA,
        PKT_S2C_RemoveItem = 0xB,
        PKT_S2C_NextAutoAttack = 0xC,
        PKT_S2C_EditMessageBoxTop = 0xD,
        PKT_S2C_UnlockCamera = 0xE,
        PKT_S2C_AddXP = 0x10,
        PKT_S2C_EndSpawn = 0x11,
        PKT_S2C_GameSpeed = 0x12,
        PKT_S2C_BotAI = 0x13,
        PKT_C2S_QueryStatusReq = 0x14,
        PKT_S2C_SkillUp = 0x15,
        PKT_C2S_Ping_Load_Info = 0x16,
        PKT_S2C_ChangeSpell = 0x17,
        PKT_S2C_FloatingText = 0x18,
        PKT_S2C_FloatingTextWithValue = 0x19,
        PKT_S2C_UpdateBuffCount = 0x1C,
        PKT_C2S_SwapItems = 0x20,
        PKT_S2C_BeginAutoAttack = 0x1A,
        PKT_S2C_ForceDie = 0x1B,
        PKT_S2C_EditBuff = 0x1C,
        PKT_S2C_SetAutoCast = 0x1F,
        PKT_S2C_Die_EventHistory = 0x21,
        PKT_S2C_AddGold = 0x22,
        PKT_S2C_FogUpdate2 = 0x23,
        PKT_S2C_MoveCamera = 0x25,
        PKT_S2C_LineMissileHitList = 0x26,
        PKT_S2C_SoundSettings = 0x27,
        PKT_S2C_StopAnimation = 0x29,
        PKT_S2C_AvatarInfo = 0x2A,
        PKT_S2C_InhibitorState = 0x2B,
        PKT_S2C_ViewAns = 0x2C,
        PKT_C2S_ViewReq = 0x2E,
        PKT_S2C_ChampionRespawnAlive = 0x2F,
        PKT_S2C_ReplaceBuff = 0x30,
        PKT_S2C_SetFadeOut_Pop = 0x32,
        PKT_S2C_AddUnitFOW = 0x33,
        PKT_S2C_InstantStopAutoAttack = 0x34,
        PKT_S2C_DeleteObject = 0x35, // not sure what this is, happens when turret leaves vision
        PKT_S2C_MessageBoxTop = 0x36,
        PKT_S2C_DestroyObject2 = 0x38,
        PKT_C2S_SkillUp = 0x39,
        PKT_C2S_UseObject = 0x3A,
        PKT_S2C_SpawnProjectile = 0x3B,
        PKT_S2C_SwapItems = 0x3E,
        PKT_S2C_LevelUp = 0x3F,
        PKT_S2C_AttentionPing = 0x40,
        PKT_S2C_Emotion = 0x42,
        PKT_S2C_PlaySound = 0x43,
        PKT_S2C_PlayVOCommand = 0x44,
        PKT_S2C_Announce = 0x45,
        PKT_S2C_HeroStats = 0x46,
        PKT_C2S_AutoAttackOption = 0x47,
        PKT_C2S_Emotion = 0x48,
        PKT_S2C_HeroRespawn = 0x4A,
        PKT_S2C_HeroSpawn = 0x4C,
        PKT_S2C_FaceDirection = 0x50,
        PKT_S2C_LeaveVision = 0x51,
        PKT_C2S_StartGame = 0x52,
        PKT_S2C_SetItem = 0x53,
        PKT_S2C_SynchVersion = 0x54,
        PKT_S2C_BlueTipUpdate = 0x55,
        PKT_C2S_Scoreboard = 0x56,
        PKT_C2S_AttentionPing = 0x57,
        PKT_S2C_HighlightUnit = 0x59,
        PKT_S2C_DestroyProjectile = 0x5A,
        PKT_S2C_SetSpellLevel = 0x5B,
        PKT_S2C_StartGame = 0x5C,
        PKT_S2C_ChampionDie = 0x5E,
        PKT_S2C_MoveAns = 0x61,
        PKT_S2C_StartSpawn = 0x62,
        PKT_S2C_Dash = 0x64, PKT_C2S_ClientReady = 0x64,
        PKT_S2C_DamageDone = 0x65, PKT_S2C_LoadHero = 0x65,
        PKT_S2C_LoadName = 0x66, PKT_S2C_ModifyShield = 0x66,
        PKT_S2C_LoadScreenInfo = 0x67,
        PKT_ChatBoxMessage = 0x68,
        PKT_S2C_AITargetSelection = 0x69,
        PKT_S2C_SetTarget = 0x6A,
        PKT_S2C_SetAnimation = 0x6B,
        PKT_S2C_ChainMissileSync = 0x6C,
        PKT_C2S_BlueTipClicked = 0x6D,
        PKT_S2C_ForceCreateProjectile = 0x6E,
        PKT_S2C_BuyItemAns = 0x6F,
        PKT_S2C_FreezeUnitAnimation = 0x71,
        PKT_C2S_MoveReq = 0x72,
        PKT_S2C_SetCameraPosition = 0x73,
        PKT_C2S_MoveConfirm = 0x77,
        PKT_S2C_RemoveBuff = 0x7B,
        PKT_C2S_LockCamera = 0x81,
        PKT_C2S_BuyItemReq = 0x82,
        PKT_S2C_WaypointListHeroWithSpeed = 0x83,
        PKT_S2C_ToggleInputLockingFlag = 0x84,
        PKT_S2C_SetCooldown = 0x85,
        PKT_S2C_CancelTargetingReticle = 0x86,
        PKT_S2C_SpawnParticle = 0x87,
        PKT_S2C_QueryStatusAns = 0x88,
        PKT_S2C_BuildingDie = 0x89,
        PKT_S2C_Quest = 0x8C,
        PKT_C2S_Exit = 0x8F,
        PKT_C2S_World_SendGameNumber = 0x92, // <-- At least one of these is probably wrong
        PKT_S2C_World_SendGameNumber = 0x92, // <--
        PKT_S2C_SetPARState = 0x93,
        PKT_S2C_Ping_Load_Info = 0x95,
        PKT_S2C_ChangeCharacterVoice = 0x96,
        PKT_S2C_ChangeCharacterData = 0x97,
        PKT_S2C_DisconnectedAnnouncement = 0x98,
        PKT_C2S_CastSpell = 0x9A,
        PKT_S2C_TurretSpawn = 0x9D,
        PKT_S2C_BroadcastDeath = 0x9E,
        PKT_S2C_SetItemStacks = 0x9F,
        PKT_S2C_MessageBoxRight = 0xA0,
        PKT_PauseGame = 0xA1,
        PKT_S2C_RemoveMessageBoxTop = 0xA2,
        PKT_S2C_Announce2 = 0xA3, // ? idk
        PKT_C2S_Surrender = 0xA4,
        PKT_S2C_SurrenderResult = 0xA5,
        PKT_S2C_RemoveMessageBoxRight = 0xA7,
        PKT_C2S_StatsConfirm = 0xA8,
        PKT_S2C_SetGrayscaleEnabledWhenDead = 0xA9,
        PKT_S2C_AIState = 0xAA,
        PKT_S2C_EnableFOW = 0xAB,
        PKT_S2C_SetHealth = 0xAE,
        PKT_C2S_Click = 0xAF,
        PKT_S2C_SpellAnimation = 0xB0,
        PKT_S2C_EditMessageBoxRight = 0xB1,
        PKT_S2C_SetFadeOut_Push = 0xB2,
        PKT_S2C_BasicTutorialMessageWindow = 0xB3,
        PKT_S2C_RemoveHighlightUnit = 0xB4,
        PKT_S2C_CastSpellAns = 0xB5,
        PKT_S2C_AddBuff = 0xB7,
        PKT_S2C_AFKWarningWindow = 0xB8,
        PKT_S2C_WaypointList = 0xB9,
        PKT_S2C_ObjectSpawn = 0xBA,
        PKT_S2C_HideUi = 0xBC,
        PKT_C2S_SynchVersion = 0xBD,
        PKT_C2S_CharLoaded = 0xBE,
        PKT_S2C_SetTargetChampion = 0xC0,
        // Packet 0xC0 format is [Net ID 1] [Net ID 2], purpose still unknown
        PKT_S2C_GameTimer = 0xC1,
        PKT_S2C_GameTimerUpdate = 0xC2,
        PKT_S2C_CharStats = 0xC4,
        PKT_S2C_GameEnd = 0xC6,
        PKT_S2C_PopAllCharacterData = 0xC8,
        PKT_S2C_Surrender = 0xC9,
        PKT_C2S_QuestClicked = 0xCD,
        PKT_S2C_ShowHPAndName = 0xCE,
        PKT_S2C_LevelPropSpawn = 0xD0,
        PKT_S2C_LevelPropAnimation = 0xD1,
        PKT_S2C_SetCapturePoint = 0xD3,
        PKT_S2C_ChangeCrystalScarNexusHP = 0xD4,
        PKT_S2C_SetTeam = 0xD7,
        PKT_S2C_AttachMinimapIcon = 0xD8,
        PKT_S2C_DominionPoints = 0xD9,
        PKT_S2C_SetScreenTint = 0xDB,
        PKT_S2C_InteractiveMusicCommand = 0xDC,
        PKT_S2C_OnEnterTeamVision = 0xE0,
        PKT_S2C_OnExitTeamVision = 0xE1,
        PKT_S2C_CloseGame = 0xE5,
        PKT_C2S_CursorPositionOnWorld = 0xE6,
        PKT_S2C_ChangeMissileTarget = 0xEE,
        PKT_S2C_SetShopEnabled = 0xF0,
        PKT_S2C_CreateFollowerObject = 0xF1,
        PKT_S2C_ReattachFollowerObject = 0xF2,
        PKT_S2C_PlayContextualEmote = 0xF3,
        PKT_S2C_SetHoverIndicatorTarget = 0xF5,
        PKT_S2C_SetHoverIndicatorEnabled = 0xF6,
        PKT_S2C_DebugMessage = 0xF7,
        PKT_S2C_MessagesAvailable = 0xF9,
        PKT_S2C_SetItemStacks2 = 0xFD,
        PKT_S2C_Extended = 0xFE,
        PKT_S2C_Batch = 0xFF,

        PKT_S2C_AnimationUpdateTimeStep = 0x103,
        PKT_S2C_UnitSetDrawPathMode = 0x105,
        PKT_S2C_AmmoUpdate = 0x107,
        PKT_S2C_UnitSetCursorReticle = 0x108,
        PKT_S2C_UpdateBuffNumCounter = 0x109,
        PKT_S2C_SetUndoEnabled = 0x10B,
        PKT_S2C_BroadcastSetInventory = 0x10C,
        PKT_S2C_ChangeMissileSpeed = 0x10D,
        PKT_S2C_SurrenderState = 0x10E,
        PKT_S2C_OnAttack = 0x10F,
        PKT_S2C_DestroyObject = 0x110,
        PKT_S2C_SetUnitSpellLevelOverrides = 0x111,
        PKT_S2C_SetUnitMaxLevelOverride = 0x112,
        PKT_S2C_SetUnitPARType = 0x113,
        PKT_S2C_MoveMarker = 0x114,
        PKT_S2C_ChampionDeathTimer = 0x117,
        PKT_S2C_SetSpellActiveState = 0x118,
        PKT_S2C_UpdateBounceMissile = 0x119,
        PKT_S2C_ReplaceShopItem = 0x11C,
        PKT_S2C_ClearReplacedShopItems = 0x11D,
        PKT_S2C_IncrementMinionKills = 0x11F,
        PKT_S2C_UpdateAttackSpeedOverrides = 0x120,
        PKT_S2C_NotifyContextualSituation = 0x121,
        PKT_S2C_CreateMonsterCamp = 0x122,
        PKT_S2C_ChangeSpell_OwnerOnly = 0x125,
        PKT_S2C_SetInventory_MapView = 0x127,
        PKT_S2C_Die_MapView = 0x126,
        PKT_S2C_FloatingText2 = 0x128,
        PKT_S2C_ForceTargetSpell = 0x129,
        PKT_S2C_StopForceTargetSpell = 0x12A,
        PKT_S2C_LockCamera = 0x12B,
        PKT_S2C_SetFadeOut = 0x12D,
        PKT_S2C_UnlockAnimation = 0x12F,
    }
}
