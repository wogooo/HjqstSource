﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using UnityEngine;
using LuaInterface;

public static class LuaBinder
{
	public static void Bind(LuaState L)
	{
		float t = Time.realtimeSinceStartup;
		L.BeginModule(null);
		DebuggerWrap.Register(L);
		UITextOutlineWrap.Register(L);
		LeanTweenWrap.Register(L);
		LTDescrWrap.Register(L);
		LeanTweenTypeWrap.Register(L);
		SingletonMono_Common_Localization_LocalizationControllerWrap.Register(L);
		SingletonMono_Common_ResMgr_ResMgrWrap.Register(L);
		SingletonMono_Logic_UI_UIMgrWrap.Register(L);
		SingletonMono_Logic_Audio_Controller_AudioControllerWrap.Register(L);
		SingletonMono_Logic_Pool_Controller_PoolControllerWrap.Register(L);
		SingletonMono_Logic_Character_Controller_PlayerControllerWrap.Register(L);
		SingletonMono_Logic_Character_Controller_EnemyControllerWrap.Register(L);
		SingletonMono_Logic_Fight_Controller_MechanicsControllerWrap.Register(L);
		SingletonMono_Logic_UI_SoftGuide_Model_SoftGuideProxyWrap.Register(L);
		SingletonMono_Logic_Action_Controller_ActionControllerWrap.Register(L);
		SingletonPersistent_Logic_TalkingData_Controller_TalkingDataControllerWrap.Register(L);
		SingletonPersistent_Logic_AdTracking_Controller_AdTrackingControllerWrap.Register(L);
		SingletonMono_Common_GameTime_Controller_TimeControllerWrap.Register(L);
		L.BeginModule("UnityEngine");
		UnityEngine_CanvasWrap.Register(L);
		UnityEngine_ResourcesWrap.Register(L);
		UnityEngine_ComponentWrap.Register(L);
		UnityEngine_BehaviourWrap.Register(L);
		UnityEngine_MonoBehaviourWrap.Register(L);
		UnityEngine_GameObjectWrap.Register(L);
		UnityEngine_RectTransformWrap.Register(L);
		UnityEngine_RectWrap.Register(L);
		UnityEngine_SpriteWrap.Register(L);
		UnityEngine_CameraWrap.Register(L);
		UnityEngine_RandomWrap.Register(L);
		UnityEngine_MaterialWrap.Register(L);
		UnityEngine_RendererWrap.Register(L);
		UnityEngine_ParticleSystemRendererWrap.Register(L);
		UnityEngine_AudioClipWrap.Register(L);
		UnityEngine_AudioSourceWrap.Register(L);
		UnityEngine_AudioRolloffModeWrap.Register(L);
		UnityEngine_ApplicationWrap.Register(L);
		UnityEngine_TimeWrap.Register(L);
		UnityEngine_PlayerPrefsWrap.Register(L);
		UnityEngine_AnimatorWrap.Register(L);
		UnityEngine_TransformWrap.Register(L);
		L.BeginModule("UI");
		UnityEngine_UI_ImageWrap.Register(L);
		UnityEngine_UI_TextWrap.Register(L);
		UnityEngine_UI_ButtonWrap.Register(L);
		UnityEngine_UI_ToggleWrap.Register(L);
		UnityEngine_UI_SliderWrap.Register(L);
		UnityEngine_UI_InputFieldWrap.Register(L);
		UnityEngine_UI_OutlineWrap.Register(L);
		UnityEngine_UI_DropdownWrap.Register(L);
		UnityEngine_UI_GridLayoutGroupWrap.Register(L);
		UnityEngine_UI_LayoutElementWrap.Register(L);
		UnityEngine_UI_ScrollbarWrap.Register(L);
		UnityEngine_UI_ScrollRectWrap.Register(L);
		UnityEngine_UI_ShadowWrap.Register(L);
		UnityEngine_UI_BaseMeshEffectWrap.Register(L);
		UnityEngine_UI_MaskableGraphicWrap.Register(L);
		UnityEngine_UI_GraphicWrap.Register(L);
		UnityEngine_UI_SelectableWrap.Register(L);
		UnityEngine_UI_LayoutGroupWrap.Register(L);
		L.BeginModule("Dropdown");
		UnityEngine_UI_Dropdown_DropdownEventWrap.Register(L);
		UnityEngine_UI_Dropdown_OptionDataWrap.Register(L);
		L.EndModule();
		L.BeginModule("Button");
		UnityEngine_UI_Button_ButtonClickedEventWrap.Register(L);
		L.EndModule();
		L.BeginModule("Toggle");
		UnityEngine_UI_Toggle_ToggleEventWrap.Register(L);
		L.EndModule();
		L.BeginModule("InputField");
		UnityEngine_UI_InputField_OnChangeEventWrap.Register(L);
		UnityEngine_UI_InputField_SubmitEventWrap.Register(L);
		L.RegFunction("OnValidateInput", UnityEngine_UI_InputField_OnValidateInput);
		L.EndModule();
		L.BeginModule("ScrollRect");
		UnityEngine_UI_ScrollRect_ScrollRectEventWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("EventSystems");
		UnityEngine_EventSystems_UIBehaviourWrap.Register(L);
		L.EndModule();
		L.BeginModule("Experimental");
		L.BeginModule("Director");
		UnityEngine_Experimental_Director_DirectorPlayerWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("Events");
		UnityEngine_Events_UnityEvent_intWrap.Register(L);
		UnityEngine_Events_UnityEventBaseWrap.Register(L);
		UnityEngine_Events_UnityEventWrap.Register(L);
		UnityEngine_Events_UnityEvent_boolWrap.Register(L);
		UnityEngine_Events_UnityEvent_stringWrap.Register(L);
		UnityEngine_Events_UnityEvent_UnityEngine_Vector2Wrap.Register(L);
		UnityEngine_Events_UnityEvent_UnityEngine_GameObject_intWrap.Register(L);
		UnityEngine_Events_UnityEvent_UnityEngine_GameObjectWrap.Register(L);
		L.RegFunction("UnityAction", UnityEngine_Events_UnityAction);
		L.RegFunction("UnityAction_int", UnityEngine_Events_UnityAction_int);
		L.RegFunction("UnityAction_string", UnityEngine_Events_UnityAction_string);
		L.RegFunction("UnityAction_UnityEngine_Vector2", UnityEngine_Events_UnityAction_UnityEngine_Vector2);
		L.RegFunction("UnityAction_UnityEngine_GameObject_int", UnityEngine_Events_UnityAction_UnityEngine_GameObject_int);
		L.RegFunction("UnityAction_UnityEngine_GameObject", UnityEngine_Events_UnityAction_UnityEngine_GameObject);
		L.RegFunction("UnityAction_bool", UnityEngine_Events_UnityAction_bool);
		L.EndModule();
		L.EndModule();
		L.BeginModule("LuaInterface");
		LuaInterface_ToLuaPbWrap.Register(L);
		LuaInterface_ToLuaProtolWrap.Register(L);
		LuaInterface_LuaCsTransferWrap.Register(L);
		L.EndModule();
		L.BeginModule("System");
		System_DateTimeWrap.Register(L);
		System_DayOfWeekWrap.Register(L);
		System_TimeSpanWrap.Register(L);
		L.RegFunction("Action", System_Action);
		L.RegFunction("Action_UnityEngine_GameObject", System_Action_UnityEngine_GameObject);
		L.RegFunction("Action_int", System_Action_int);
		L.RegFunction("Action_float", System_Action_float);
		L.RegFunction("Action_UnityEngine_Vector3", System_Action_UnityEngine_Vector3);
		L.RegFunction("Action_Logic_Character_PlayerEntity", System_Action_Logic_Character_PlayerEntity);
		L.RegFunction("Action_Logic_Character_PetEntity", System_Action_Logic_Character_PetEntity);
		L.RegFunction("Action_Logic_Character_HeroEntity", System_Action_Logic_Character_HeroEntity);
		L.RegFunction("Action_object", System_Action_object);
		L.RegFunction("Action_UnityEngine_Color", System_Action_UnityEngine_Color);
		L.RegFunction("Action_UnityEngine_Vector2", System_Action_UnityEngine_Vector2);
		L.RegFunction("Action_float_object", System_Action_float_object);
		L.RegFunction("Action_LTEvent", System_Action_LTEvent);
		L.RegFunction("Action_float_float", System_Action_float_float);
		L.RegFunction("Action_UnityEngine_Vector3_object", System_Action_UnityEngine_Vector3_object);
		L.RegFunction("Func_Observers_Interfaces_INotification_bool", System_Func_Observers_Interfaces_INotification_bool);
		L.RegFunction("Action_string", System_Action_string);
		L.RegFunction("Action_string_float", System_Action_string_float);
		L.RegFunction("Action_string_Common_ResMgr_ResLoaderObj", System_Action_string_Common_ResMgr_ResLoaderObj);
		L.RegFunction("Action_UnityEngine_Object", System_Action_UnityEngine_Object);
		L.RegFunction("Action_UnityEngine_Sprite", System_Action_UnityEngine_Sprite);
		L.RegFunction("Action_PathologicalGames_SpawnPool", System_Action_PathologicalGames_SpawnPool);
		L.RegFunction("Action_Logic_Character_EnemyPlayerEntity", System_Action_Logic_Character_EnemyPlayerEntity);
		L.RegFunction("Action_Logic_Character_EnemyEntity", System_Action_Logic_Character_EnemyEntity);
		L.RegFunction("Action_bool", System_Action_bool);
		L.RegFunction("Predicate_Logic_Skill_Model_SkillDesInfo", System_Predicate_Logic_Skill_Model_SkillDesInfo);
		L.RegFunction("Action_Logic_Skill_Model_SkillDesInfo", System_Action_Logic_Skill_Model_SkillDesInfo);
		L.RegFunction("Comparison_Logic_Skill_Model_SkillDesInfo", System_Comparison_Logic_Skill_Model_SkillDesInfo);
		L.RegFunction("Predicate_System_Collections_Generic_KeyValuePair_int_float", System_Predicate_System_Collections_Generic_KeyValuePair_int_float);
		L.RegFunction("Action_System_Collections_Generic_KeyValuePair_int_float", System_Action_System_Collections_Generic_KeyValuePair_int_float);
		L.RegFunction("Comparison_System_Collections_Generic_KeyValuePair_int_float", System_Comparison_System_Collections_Generic_KeyValuePair_int_float);
		L.RegFunction("Predicate_UnityEngine_UI_Dropdown_OptionData", System_Predicate_UnityEngine_UI_Dropdown_OptionData);
		L.RegFunction("Action_UnityEngine_UI_Dropdown_OptionData", System_Action_UnityEngine_UI_Dropdown_OptionData);
		L.RegFunction("Comparison_UnityEngine_UI_Dropdown_OptionData", System_Comparison_UnityEngine_UI_Dropdown_OptionData);
		L.RegFunction("Predicate_Logic_Game_Model_GameResData", System_Predicate_Logic_Game_Model_GameResData);
		L.RegFunction("Action_Logic_Game_Model_GameResData", System_Action_Logic_Game_Model_GameResData);
		L.RegFunction("Comparison_Logic_Game_Model_GameResData", System_Comparison_Logic_Game_Model_GameResData);
		L.BeginModule("Collections");
		L.BeginModule("Generic");
		System_Collections_Generic_List_Logic_Skill_Model_SkillDesInfoWrap.Register(L);
		System_Collections_Generic_Dictionary_uint_Logic_Character_HeroEntityWrap.Register(L);
		System_Collections_Generic_KeyValuePair_uint_Logic_Character_HeroEntityWrap.Register(L);
		System_Collections_Generic_Dictionary_uint_Logic_Character_EnemyEntityWrap.Register(L);
		System_Collections_Generic_KeyValuePair_uint_Logic_Character_EnemyEntityWrap.Register(L);
		System_Collections_Generic_KeyValuePair_int_floatWrap.Register(L);
		System_Collections_Generic_List_System_Collections_Generic_KeyValuePair_int_floatWrap.Register(L);
		System_Collections_Generic_List_UnityEngine_UI_Dropdown_OptionDataWrap.Register(L);
		System_Collections_Generic_List_Logic_Game_Model_GameResDataWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.EndModule();
		L.BeginModule("LitJson");
		LitJson_JsonDataWrap.Register(L);
		L.EndModule();
		L.BeginModule("Observers");
		Observers_FacadeWrap.Register(L);
		Observers_NotificationWrap.Register(L);
		L.EndModule();
		L.BeginModule("Common");
		L.BeginModule("Localization");
		Common_Localization_LocalizationControllerWrap.Register(L);
		L.EndModule();
		L.BeginModule("ResMgr");
		Common_ResMgr_ResMgrWrap.Register(L);
		L.EndModule();
		L.BeginModule("Animators");
		Common_Animators_AnimatorUtilWrap.Register(L);
		Common_Animators_AnimationUtilWrap.Register(L);
		L.EndModule();
		L.BeginModule("Util");
		Common_Util_TimeUtilWrap.Register(L);
		Common_Util_TransformUtilWrap.Register(L);
		Common_Util_BlackListWordUtilWrap.Register(L);
		L.EndModule();
		L.BeginModule("UI");
		L.BeginModule("Components");
		Common_UI_Components_SliderValueChangeActionWrap.Register(L);
		Common_UI_Components_ScrollContentExpandWrap.Register(L);
		Common_UI_Components_ScrollContentWrap.Register(L);
		Common_UI_Components_OnResetItemWrap.Register(L);
		Common_UI_Components_ToggleContentWrap.Register(L);
		Common_UI_Components_OnInitCompleteWrap.Register(L);
		Common_UI_Components_EventTriggerDelegateWrap.Register(L);
		Common_UI_Components_UnityEventGameObjectWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("GameTime");
		L.BeginModule("Controller");
		Common_GameTime_Controller_TimeControllerWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.EndModule();
		L.BeginModule("Logic");
		L.BeginModule("Shaders");
		Logic_Shaders_ShadersUtilWrap.Register(L);
		L.EndModule();
		L.BeginModule("UI");
		Logic_UI_UIMgrWrap.Register(L);
		L.BeginModule("CommonAnimations");
		Logic_UI_CommonAnimations_CommonMoveByAnimationWrap.Register(L);
		Logic_UI_CommonAnimations_CommonFadeInAnimationWrap.Register(L);
		Logic_UI_CommonAnimations_CommonFadeToAnimationWrap.Register(L);
		L.EndModule();
		L.BeginModule("SoftGuide");
		L.BeginModule("Model");
		Logic_UI_SoftGuide_Model_SoftGuideProxyWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("Friend");
		L.BeginModule("Model");
		Logic_UI_Friend_Model_FriendInfoWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("RedPoint");
		L.BeginModule("View");
		Logic_UI_RedPoint_View_RedPointViewWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("FightResult");
		L.BeginModule("View");
		Logic_UI_FightResult_View_NumberIncreaseActionWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("GoodsJump");
		L.BeginModule("View");
		Logic_UI_GoodsJump_View_GoodsJumpButtonWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.EndModule();
		L.BeginModule("Audio");
		L.BeginModule("Controller");
		Logic_Audio_Controller_AudioControllerWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("Pool");
		L.BeginModule("Controller");
		Logic_Pool_Controller_PoolControllerWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("Skill");
		Logic_Skill_SkillUtilWrap.Register(L);
		L.BeginModule("Model");
		Logic_Skill_Model_SkillInfoWrap.Register(L);
		Logic_Skill_Model_SkillDataWrap.Register(L);
		Logic_Skill_Model_SkillDesInfoWrap.Register(L);
		Logic_Skill_Model_MechanicsDataWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("Character");
		Logic_Character_CharacterEntityWrap.Register(L);
		Logic_Character_HeroEntityWrap.Register(L);
		Logic_Character_PlayerEntityWrap.Register(L);
		Logic_Character_EnemyEntityWrap.Register(L);
		Logic_Character_EnemyPlayerEntityWrap.Register(L);
		Logic_Character_PetEntityWrap.Register(L);
		L.BeginModule("Model");
		Logic_Character_Model_CharacterBaseInfoWrap.Register(L);
		Logic_Character_Model_BuffInfoWrap.Register(L);
		L.EndModule();
		L.BeginModule("Controller");
		Logic_Character_Controller_PlayerControllerWrap.Register(L);
		Logic_Character_Controller_EnemyControllerWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("Fight");
		L.BeginModule("Controller");
		Logic_Fight_Controller_MechanicsControllerWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("Position");
		L.BeginModule("Model");
		Logic_Position_Model_PositionDataWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("Enums");
		Logic_Enums_SkillTypeWrap.Register(L);
		Logic_Enums_BuffTypeWrap.Register(L);
		Logic_Enums_SkillLevelBuffAddTypeWrap.Register(L);
		Logic_Enums_BuffAddTypeWrap.Register(L);
		Logic_Enums_MechanicsTypeWrap.Register(L);
		Logic_Enums_RoleAttackAttributeTypeWrap.Register(L);
		Logic_Enums_TargetTypeWrap.Register(L);
		Logic_Enums_MechanicsValueTypeWrap.Register(L);
		Logic_Enums_BaseResTypeWrap.Register(L);
		L.EndModule();
		L.BeginModule("Model");
		L.BeginModule("View");
		Logic_Model_View_ModelRotateAndAnimWrap.Register(L);
		Logic_Model_View_ModelBehaviourWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("Action");
		L.BeginModule("Controller");
		Logic_Action_Controller_ActionControllerWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("Game");
		L.BeginModule("Model");
		Logic_Game_Model_GameResDataWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("TalkingData");
		L.BeginModule("Controller");
		Logic_TalkingData_Controller_TalkingDataControllerWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("AdTracking");
		L.BeginModule("Controller");
		Logic_AdTracking_Controller_AdTrackingControllerWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.EndModule();
		L.EndModule();
		Debugger.Log("Register lua type cost time: {0}", Time.realtimeSinceStartup - t);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_UI_InputField_OnValidateInput(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.UI.InputField.OnValidateInput), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction_int(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<int>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction_string(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<string>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction_UnityEngine_Vector2(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<UnityEngine.Vector2>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction_UnityEngine_GameObject_int(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<UnityEngine.GameObject,int>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction_UnityEngine_GameObject(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<UnityEngine.GameObject>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction_bool(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<bool>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_UnityEngine_GameObject(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<UnityEngine.GameObject>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_int(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<int>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_float(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<float>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_UnityEngine_Vector3(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<UnityEngine.Vector3>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_Logic_Character_PlayerEntity(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<Logic.Character.PlayerEntity>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_Logic_Character_PetEntity(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<Logic.Character.PetEntity>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_Logic_Character_HeroEntity(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<Logic.Character.HeroEntity>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_object(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<object>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_UnityEngine_Color(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<UnityEngine.Color>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_UnityEngine_Vector2(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<UnityEngine.Vector2>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_float_object(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<float,object>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_LTEvent(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<LTEvent>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_float_float(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<float,float>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_UnityEngine_Vector3_object(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<UnityEngine.Vector3,object>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Func_Observers_Interfaces_INotification_bool(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Func<Observers.Interfaces.INotification,bool>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_string(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<string>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_string_float(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<string,float>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_string_Common_ResMgr_ResLoaderObj(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<string,Common.ResMgr.ResLoaderObj>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_UnityEngine_Object(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<UnityEngine.Object>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_UnityEngine_Sprite(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<UnityEngine.Sprite>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_PathologicalGames_SpawnPool(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<PathologicalGames.SpawnPool>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_Logic_Character_EnemyPlayerEntity(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<Logic.Character.EnemyPlayerEntity>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_Logic_Character_EnemyEntity(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<Logic.Character.EnemyEntity>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_bool(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<bool>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Predicate_Logic_Skill_Model_SkillDesInfo(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Predicate<Logic.Skill.Model.SkillDesInfo>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_Logic_Skill_Model_SkillDesInfo(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<Logic.Skill.Model.SkillDesInfo>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Comparison_Logic_Skill_Model_SkillDesInfo(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Comparison<Logic.Skill.Model.SkillDesInfo>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Predicate_System_Collections_Generic_KeyValuePair_int_float(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Predicate<System.Collections.Generic.KeyValuePair<int,float>>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_System_Collections_Generic_KeyValuePair_int_float(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<System.Collections.Generic.KeyValuePair<int,float>>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Comparison_System_Collections_Generic_KeyValuePair_int_float(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Comparison<System.Collections.Generic.KeyValuePair<int,float>>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Predicate_UnityEngine_UI_Dropdown_OptionData(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Predicate<UnityEngine.UI.Dropdown.OptionData>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_UnityEngine_UI_Dropdown_OptionData(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<UnityEngine.UI.Dropdown.OptionData>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Comparison_UnityEngine_UI_Dropdown_OptionData(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Comparison<UnityEngine.UI.Dropdown.OptionData>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Predicate_Logic_Game_Model_GameResData(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Predicate<Logic.Game.Model.GameResData>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_Logic_Game_Model_GameResData(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<Logic.Game.Model.GameResData>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Comparison_Logic_Game_Model_GameResData(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Comparison<Logic.Game.Model.GameResData>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
